using System;
using System.Diagnostics;
using System.Reactive.Concurrency;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Threading;
using Birch.Components;
using Birch.Compose;
using Birch.Diagnostics;
using Birch.Metrics;
using Birch.Metrics.Layout;
using Birch.Transactions;
using Microsoft.Extensions.Logging;

namespace Birch.Hosts
{
    public abstract class BuildHostInstance
    {
        /// <summary>
        /// Helper class for the reactive extensions observable
        /// </summary>
        internal class MutationLayoutPair
        {
            public int MutationId { get; }

            public MutationElementShadowPair Current { get; }

            public ElementShadowTransition Next { get; }

            public MutationLayoutPair(int mutationId,MutationElementShadowPair current, ElementShadowTransition next)
            {
                MutationId = mutationId;
                Current = current;
                Next = next;
            }
        }
        /// <summary>
        /// The 'owner' of the build
        /// </summary>
        protected BuildOwner BuildOwner;

        /// <summary>
        /// Observable for changes to stateful changes
        /// </summary>
        private IObservable<ModelChange> _modelChangeObservable;

        /// <summary>
        /// Is the layout engine enabled
        /// </summary>
        private bool _enabled = true;

        /// <summary>
        /// A backing subject used to control the layout engine
        /// </summary>
        private readonly ISubject<bool> _enabledSubject = Subject.Synchronize(new BehaviorSubject<bool>(true));

        /// <summary>
        /// The root stateful container.
        /// </summary>
        private readonly IStatefulContainer _rootContainer;

        /// <summary>
        /// Is this class enabled as a source of logging information 
        /// </summary>
        private static readonly Lazy<bool> IsLoggingEnabled = new Lazy<bool>(() => LoggingRules.For(Categories.Host).Any);

        /// <summary>
        /// Enable or disable to functioning of layout processing
        /// </summary>
        public bool Enabled
        {
            get => _enabled;
            set
            {
                _enabled = value;
                _enabledSubject.OnNext(_enabled);
            }
        }

        protected BuildHostInstance(HostEnvironment hostEnvironment,RootContainerFactory rootState)
        {
            Initialize(hostEnvironment);

            _rootContainer = rootState(new BuildEnvironment(BuildOwner),new LayoutContext(BuildOwner.ModelBag,hostEnvironment.LayoutResolver));
        }

        private readonly ISubject<ModelChange> _modelChangeSubject = Subject.Synchronize(new Subject<ModelChange>());

        private void Initialize(HostEnvironment hostEnvironment)
        {
            HostEnvironment = hostEnvironment;

            _modelChangeObservable = _modelChangeSubject.AsObservable();
            // create the owner of the build, this will include all of the state for stateful containers
            BuildOwner = new BuildOwner();

            // when ever a model changes then push it to a model which will potentially perform a new layout
            BuildOwner.Changed += (sender, args) => _modelChangeSubject.OnNext(args.Change);
        }

        private readonly ISubject<MutationElementShadowPair> _currentStateSubject = Subject.Synchronize(new BehaviorSubject<MutationElementShadowPair>(MutationElementShadowPair.Empty));

        /// <summary>
        /// Start the build host.
        /// </summary>
        /// <returns></returns>
        public IDisposable Start()
        {
            return _modelChangeObservable.
                ObserveOn(HostEnvironment.LayoutEngineOptions.LayoutScheduler).
                Do(change=> {BuildOwner.ModelBag.SetModel(change.Container,change.Model,change.MutationId);}).
                Do(change => Record(new ModelChangedEvent(change))).
                Select(change => change.MutationId).
                StartWith(0).
                CombineLatest(_enabledSubject,_currentStateSubject, (mutationId,enabled,currentState) => (MutationId: mutationId,CurrentState:currentState, Enabled: enabled)).
                Where(ce => ce.Enabled && (!HostEnvironment.LayoutEngineOptions.IgnoreOldMutations || BuildOwner.IsLatestMutation(ce.MutationId)) && (ce.CurrentState == null || ce.CurrentState.MutationId < ce.MutationId) ).
                Select(ce =>
                {
                    var (mutationId, currentState, _) = ce;

                    if (IsLoggingEnabled.Value)
                    {
                        Logging.Instance.LogDebug(
                            "BuildHostInstance Building , Mutation:{mutationId},IsCurrent:{isCurrentMutation},current Element:{current}",
                            mutationId, BuildOwner.IsLatestMutation(mutationId),
                            currentState?.ElementShadow?.Element);
                    }

                    // create a new context which will contain a snapshot of the current stateful containers state
                    var context = LayoutContext.Create(BuildOwner.ModelBag,HostEnvironment.LayoutResolver);

                    try
                    {
                        var layout = Layout(context, currentState?.ElementShadow);
                        return new MutationLayoutPair(mutationId,currentState,layout);
                    }
                    catch (Exception exception)
                    {
                        throw new LayoutException(context,currentState,mutationId, exception);
                    }
                }).
                Do(_ => { }, (exception) => { Record(new LayoutExceptionEvent(exception)); }).
                Where(c => BuildOwner.IsLatestMutation(c.MutationId)).
                ObserveOn(HostEnvironment.LayoutEngineOptions.CommitScheduler).
                CombineLatest(_currentStateSubject,(c,cs) => (Proposed:c,CurrentState:cs)).
                Where(c => ReferenceEquals(c.Proposed.Current.ElementShadow,c.CurrentState.ElementShadow) && c.CurrentState.MutationId != c.Proposed.MutationId && BuildOwner.IsLatestMutation(c.Proposed.MutationId)).
                Select(c => c.Proposed).
                Catch<MutationLayoutPair,LayoutException>(exception => Observable.Return(new MutationLayoutPair(exception.MutationId,exception.CurrentState,DefaultLayoutError(exception.Context,exception,exception.CurrentState.ElementShadow)))).
                Do(r =>
                {
                    try
                    {
                        Commit(r.Next);
                    }
                    catch (Exception exception)
                    {
                        Logging.Instance.LogError(exception,"BuildHostInstance:Commit failure {element}, Mutation:{mutationId}",r.Next.Next.Element,r.MutationId);
                        throw new CommitException(exception);
                    }

                    if (IsLoggingEnabled.Value)
                    {
                        Logging.Instance.LogDebug("BuildHostInstance Changing, Mutation:{mutationId},IsCurrent:{isCurrentMutation},Current {current}",r.MutationId,BuildOwner.IsLatestMutation(r.MutationId),r.Next.Next.Element);
                    }

                    _currentStateSubject.OnNext(new MutationElementShadowPair(r.Next.Next,r.MutationId));
                }).
                Do(_ => { }, (exception) => { Record(new LayoutExceptionEvent(exception)); }).
                Do(_ => { },FatalError).
                Subscribe();
        }

        /// <summary>
        /// Invoked when we have a fatal error during the commit phase
        /// </summary>
        /// <param name="exception"></param>
        protected abstract void FatalError(Exception exception);

        /// <summary>
        /// Invoked when we have a recoverable error during the build phase, typically
        /// used to resolve the layout to be used to show the error.
        /// </summary>
        /// <param name="layoutContext"></param>
        /// <param name="exception"></param>
        /// <param name="current"></param>
        /// <returns></returns>
        protected abstract ElementShadowTransition DefaultLayoutError(LayoutContext layoutContext, Exception exception, ElementShadowPair current);

        protected abstract IShadowContext CreateContext();

        /// <summary>
        /// Get the current changes
        /// </summary>
        /// <param name="layoutContext"></param>
        /// <param name="current"></param>
        /// <returns></returns>
        private ElementShadowTransition Layout(LayoutContext layoutContext,ElementShadowPair current)
        {
            long elapsed = 0;

            ElementShadowTransition mst;

            using (var _ = Benchmark.Create((t, _) => elapsed = t))
            {
                mst = GetChanges(current, layoutContext);
            }

            Record(new ChangeSetBuildEvent(elapsed, false, mst));

            return mst;
        }

        /// <summary>
        /// Commit the outstanding transaction to the UI
        /// </summary>
        /// <param name="elementShadowTransition"></param>
        public void Commit(ElementShadowTransition elementShadowTransition)
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
            }
            finally
            {
                _transactionLock.ExitWriteLock();
            }
        }

        /// <summary>
        /// Given a specified current and next state, create the transactions to perform the required changes.
        /// </summary>
        /// <param name="current"></param>
        /// <param name="next"></param>
        /// <returns></returns>
        protected ElementShadowTransition CreateChangeTransactionalSet(ElementShadowPair current,IPrimitive next)
        {
            using var transaction = Transaction.Create();

            var context = CreateContext();

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

        protected HostEnvironment HostEnvironment;

        /// <summary>
        /// Given a current state , perform a layout and create the transactional change set to transaction to the new layout
        /// </summary>
        /// <param name="current"></param>
        /// <param name="layoutContext"></param>
        /// <returns></returns>
        private ElementShadowTransition GetChanges(ElementShadowPair current, LayoutContext layoutContext)
        {
            var layout = _rootContainer.Layout(layoutContext);

            // lock the state so that read consistency can be maintained
            _transactionLock.EnterReadLock();

            try
            {
                var mst = CreateChangeTransactionalSet(current, layout);

                return mst;
            }
            finally
            {
                _transactionLock.ExitReadLock();                
            }
        }
    }

    internal class MutationElementShadowPair
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