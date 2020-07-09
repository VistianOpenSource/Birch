using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Reactive.Concurrency;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Threading;
using Birch.Components;
using Birch.Compose;
using Birch.Diagnostics;
using Birch.Metrics;
using Birch.Metrics.Layout;
using Birch.Reflection;
using Birch.Transactions;
using Microsoft.Extensions.Logging;

namespace Birch.Hosts
{
    public abstract class BuildHostInstance:IDisposable
    {
        public static readonly bool IsLoggingEnabled = LoggingRules.For(Categories.Host).Any;

        private readonly RootContainerFactory _rootState;

        /// <summary>
        /// The 'owner' of the build
        /// </summary>
        public BuildOwner BuildOwner { get; private set; }

        /// <summary>
        /// The root stateful container.
        /// </summary>
        public IStatefulContainer RootContainer { get; private set; }

        /// <summary>
        /// The current state
        /// </summary>
        public MutationElementShadowPair CurrentState=MutationElementShadowPair.Empty;

        /// <summary>
        /// Our active <see cref="IJobHostNew"/>
        /// </summary>
        private IJobHostNew _jobHost;

        /// <summary>
        /// The environment under which this host instance will operate
        /// </summary>
        public  HostEnvironment HostEnvironment;

        /// <summary>
        /// Is the host enabled or not
        /// </summary>
        private bool _enabled;

        /// <summary>
        /// Enable or disable to functioning of layout processing
        /// </summary>
        public bool Enabled
        {
            get => _enabled;
            set
            {

                _enabled = value;

                if (_jobHost != null)
                {
                    _jobHost.Enabled = _enabled;
                }
            }
        }


        protected BuildHostInstance(HostEnvironment hostEnvironment,RootContainerFactory rootState)
        {
            _rootState = rootState;

            Initialize(hostEnvironment);
        }

        /// <summary>
        /// Initialize the environment, creating the state container related items.
        /// </summary>
        /// <param name="hostEnvironment"></param>
        private void Initialize(HostEnvironment hostEnvironment)
        {
            HostEnvironment = hostEnvironment;

            // create the owner of the build, this will include all of the state for stateful containers
            BuildOwner = new BuildOwner();

            CurrentState = MutationElementShadowPair.Empty;

            RootContainer = _rootState(new BuildEnvironment(BuildOwner),new LayoutContext(BuildOwner.ModelBag,hostEnvironment.LayoutResolver));
        }

        /// <summary>
        /// Set the <see cref="IJobHostNew"/> current instance
        /// </summary>
        /// <param name="host"></param>
        public void SetHost(IJobHostNew host)
        {
            // dispose of any active job host
            _jobHost?.Dispose();

            _jobHost = host;

            _jobHost.Error += OnLayoutException;

            OnHostChanged(_jobHost);

            _jobHost.Start();
        }

        protected void OnHostChanged(IJobHostNew jobHost)
        {
            HostChanged?.Invoke(this,jobHost);
        }

        public event EventHandler<IJobHostNew> HostChanged;

        /// <summary>
        /// Resets the current environment.
        /// </summary>
        public void Reset()
        {
            CurrentState.ElementShadow?.Shadow.Dispose();

            // re-initialize the environment
            Initialize(HostEnvironment);
        }

        /// <summary>
        /// Start the build host.
        /// </summary>
        /// <returns></returns>
        public void Start()
        {

            // create the default layout host...
            var host = new DefaultLayoutHost(this,HostEnvironment.HostSettings);

            SetHost(host);

            // possibly need to inform that the host has been assigned...
            // we need to create 
        }

        /// <summary>
        /// We have seen an exception on layout.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="exception"></param>
        private void OnLayoutException(object sender, Exception exception)
        {
            // at this point we need to invoke the appropriate error policy...
            var errorPolicy = ErrorPolicy();

            if (errorPolicy == null && IsLoggingEnabled)
            {
                Logging.Instance.LogWarning(exception, "BuildHostInstance:No error policy for Host Instance:{name}",
                    this.GetType().FriendlyName());
            }

            errorPolicy?.Handle(this, exception);
        }

        /// <summary>
        /// Create the <see cref="IShadowContext"/> used during the compare phase.
        /// </summary>
        /// <returns></returns>
        protected abstract IShadowContext CreateShadowContext();

        /// <summary>
        /// Get the <see cref="IBuildErrorPolicy"/> instance.
        /// </summary>
        /// <returns></returns>
        protected virtual IBuildErrorPolicy ErrorPolicy() => null;

        /// <summary>
        /// Given a specified next state, create the transactions to perform the required changes.
        /// </summary>
        /// <param name="next"></param>
        /// <returns></returns>
        public ElementShadowTransition Compare(IPrimitive next)
        {
            _transactionLock.EnterReadLock();

            try
            {
                using var transaction = Transaction.Create();

                var current = CurrentState?.ElementShadow;

                var context = CreateShadowContext();

                var rootShadow = current.Shadow;

                if (current.Shadow == null)
                {
                    rootShadow = HostEnvironment.ShadowMapperFactory.Create(context, next);
                }
                else
                {
                    HostEnvironment.ShadowMapperFactory.Update(context, rootShadow, current.Element, next);
                }
            
                // and return the transactions - note that we don't commit the transactions, but rather but get what is currently there
                return new ElementShadowTransition(current, transaction.TransactionsList, new ElementShadowPair(rootShadow, next));
            }
            finally
            {
                _transactionLock.ExitReadLock();                
            }
        }

        /// <summary>
        /// Commit the outstanding transaction to the UI
        /// </summary>
        /// <param name="elementShadowTransition"></param>
        /// <param name="mutationId"></param>
        public void Commit(ElementShadowTransition elementShadowTransition, int mutationId)
        {
            using var benchmark = Benchmark.Create((t,_) =>
            {
                Record(new TransactionsCommittedEvent(t, elementShadowTransition));
            });

            // load up with the transactions that need to be committed
            using var transaction = Transaction.Create(elementShadowTransition.TransactionsList);

            // construct a write lock for the commit phase of the transactions
            _transactionLock.EnterWriteLock();

            try
            {
                transaction.Commit();
                CurrentState = new MutationElementShadowPair(elementShadowTransition.Next,mutationId);
            }
            finally
            {
                _transactionLock.ExitWriteLock();
            }
        }


        /// <summary>
        /// Record <see cref="ILayoutEvent"/> to the layout monitor.
        /// </summary>
        /// <param name="event"></param>
        private void Record(ILayoutEvent @event)
        {
            HostEnvironment.LayoutMonitor?.Record(@event);
        }

        /// <summary>
        /// Used to control access between transaction changes and application.
        /// </summary>
        /// <remarks>
        /// This is currently a requirement to ensure that consistent read access to shadow views
        /// when updates are applied. In a collection, whilst its easy to transaction the
        /// creation of views, somewhere there has to be a list of the current shadow views, so that
        /// updates can be applied. This list is readonly during the building of transactions to be applied and clearly is read/write when
        /// the transaction is committed. The potential problem comes when you can have a sequence of transactions being built whilst another
        /// transaction is being committed. This leaves open the option of potentially reading a shadow which isn't in-fact reflective of the current state and might end up with
        /// an exception being raised.
        /// So, for now, a simple lock is used, but there does seem to be a few differing options on how to address this:
        /// 1. The update method is the only one that REQUIRES a shadow item to be provided as part of its api, this could instead be changed to a function which looks up the shadow
        /// and this is then used inside the commit phase of the transaction.
        /// 2. Possibly have a list per associated primitive component and then, when the transaction is committed, flip over to a the new one. It sounds slightly convoluted, but...
        /// and would require a 'copying' from one to another on the beginning of the commit.
        /// It should also be noted that for those types of views which are virtualized, e.g. androids RecyclerView , then the actual transactions to perform an update
        /// don't happen on the typical update cycle that exists here. Instead the creation and updating of the view occurs on the main UI thread as a result of a call from the respective
        /// virtualized control so there should be no need for there to be concerns about access to view groups changing, this shouldn't occur which no differences would have occured for this element
        /// since the transactions would have stopped in the appropriate mapper for the virtualized control.
        /// </remarks>
        private readonly ReaderWriterLockSlim _transactionLock = new ReaderWriterLockSlim();


        public virtual void Dispose()
        {
            RootContainer?.Dispose();
            _jobHost?.Dispose();
            _transactionLock?.Dispose();
            BuildOwner?.Dispose();
        }
    }

    public interface IJobHostNew:IDisposable
    {
        public void Start();

        event EventHandler<Exception> Error;

        bool Enabled { get; set; }
    }

    public class MutationElementShadowPair
    {
        public ElementShadowPair ElementShadow { get; }

        public int MutationId { get; }

        public MutationElementShadowPair(ElementShadowPair elementShadow, int mutationId)
        {
            ElementShadow = elementShadow;
            MutationId = mutationId;
        }

        public static MutationElementShadowPair Empty => new MutationElementShadowPair(ElementShadowPair.Empty, ModelBag.MutationUnspecified);
    }
}