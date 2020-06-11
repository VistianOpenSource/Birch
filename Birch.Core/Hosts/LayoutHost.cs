using System;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using Birch.Components;
using Birch.Compose;
using Birch.Diagnostics;
using Birch.Metrics;
using Birch.Metrics.Layout;
using Microsoft.Extensions.Logging;

namespace Birch.Hosts
{
    /// <summary>
    /// Base implementation for the layout,compare,commit phases.
    /// </summary>
    /// <typeparam name="TRequest"></typeparam>
    /// <remarks>
    /// Uses TPL Data flow to allow for background and foreground processing layouts.</remarks>
    public abstract class LayoutHost<TRequest>:IJobHostNew where TRequest:ILayoutRequest
    {
        /// <summary>
        /// Associated build host
        /// </summary>
        protected readonly BuildHostInstance BuildHostInstance;

        protected readonly BuildOwner BuildOwner;

        /// <summary>
        /// The starting point for the data flow
        /// </summary>
        protected readonly TransformBlock<TRequest,(TRequest request,IPrimitive layout)> LayoutBlock;

        /// <summary>
        /// Settings which dicttate how the layout host will operate
        /// </summary>
        protected LayoutHostSettings Settings { get; }

        /// <summary>
        /// Create an instance and setup the dataflow for layout operations.
        /// </summary>
        /// <param name="buildHostInstance"></param>
        /// <param name="settings"></param>
        protected LayoutHost(BuildHostInstance buildHostInstance,LayoutHostSettings settings=default)
        {
            BuildHostInstance = buildHostInstance;
            BuildOwner = buildHostInstance.BuildOwner;

            settings ??= LayoutHostSettings.Default;
            Settings = settings;

            var backgroundBlockOptions = new ExecutionDataflowBlockOptions() {TaskScheduler = settings.Layout};

            LayoutBlock = new TransformBlock<TRequest, (TRequest request,IPrimitive layout)>(Layout, backgroundBlockOptions);
            var compareBlock = new TransformBlock<(TRequest request,IPrimitive layout), (TRequest request,ElementShadowTransition est)>(Compare, backgroundBlockOptions);
            var commitBlock = new ActionBlock<(TRequest request,ElementShadowTransition est)>(Commit, new ExecutionDataflowBlockOptions() {TaskScheduler = settings.Commit});

            LayoutBlock.LinkTo(compareBlock, new DataflowLinkOptions() {PropagateCompletion = true},(r) => ShouldPropagate(r.request));
            LayoutBlock.LinkTo(DataflowBlock.NullTarget< (TRequest,IPrimitive)>());
            compareBlock.LinkTo(commitBlock, new DataflowLinkOptions() {PropagateCompletion = true},(r) => ShouldPropagate(r.request));
            compareBlock.LinkTo(DataflowBlock.NullTarget<(TRequest,ElementShadowTransition)>());

            commitBlock.Completion.ContinueWith(x =>
            {
                if (x.IsFaulted)
                {
                    OnException(x.Exception);
                }
            }, settings.Commit);
        }

        protected void ExecuteSync(TRequest request)
        {
            try
            {
                var layoutResult = Layout(request);
                var compareResult = Compare(layoutResult);
                Commit(compareResult);
            }
            catch (Exception exception)
            {
                OnException(exception);
            }
        }

        protected abstract IPrimitive PerformLayout(TRequest request);

        protected (TRequest request,IPrimitive layout) Layout(TRequest request)
        {
            if (BuildHostInstance.IsLoggingEnabled)
            {
                Logging.Instance.LogInformation("BuildHostInstance:PerformingLayout Mutation:{mutationId},IsCurrent:{isCurrentMutation}", request.MutationId, BuildOwner.IsLatestMutation(request.MutationId));
            }

            var primitive = PerformLayout(request);

            return (request,primitive);
        }

        protected (TRequest,ElementShadowTransition) Compare((TRequest request,IPrimitive layout) compare)
        {
            long elapsed = 0;

            ElementShadowTransition est = null;

            using (var _ = Benchmark.Create((t, __) => elapsed = t))
            {
                est = BuildHostInstance.Compare(BuildHostInstance.CurrentState?.ElementShadow,compare.layout);
            }

            Record(new ChangeSetBuildEvent(elapsed, false,est));

            return (compare.request,est);
        }


        protected void Commit((TRequest request,ElementShadowTransition est) commit)
        {
            using var benchmark = Benchmark.Create((t,_) =>
            {
                Record(new TransactionsCommittedEvent(t, commit.est));
            });


            BuildHostInstance.Commit(commit.est,commit.request.MutationId);
        }


        protected void Execute(TRequest job,bool sync=true)
        {
            if (sync)
            {
                ExecuteSync(job);
            }
            else
            {
                LayoutBlock.Post(job);
            }
        }

        protected void Record(ILayoutEvent @event)
        {
            BuildHostInstance.HostEnvironment.LayoutMonitor?.Record(@event);
        }


        /// <summary>
        /// Log that an exception has occured and then look to let others know about it
        /// </summary>
        /// <param name="exception"></param>
        private void OnException(Exception exception)
        {
            Logging.Instance.LogError(exception,"BuildHostInstance:Commit failure {element}, Mutation:{mutationId}");

            // need to log the error
            OnError(exception);
        }

        /// <summary>
        /// Rule on how things should propagate through the data flow.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        protected virtual bool ShouldPropagate(TRequest request) => Enabled;

        /// <summary>
        /// Is this host enabled 
        /// </summary>
        public bool Enabled { get; set; } = true;

        /// <summary>
        /// Invoked when an exception has occured in the dataflow.
        /// </summary>
        /// <param name="exception"></param>
        protected virtual void OnError(Exception exception)
        {
            Error?.Invoke(this,exception);
        }

        public abstract void Start();

        /// <summary>
        /// Event for any exception that is raised
        /// </summary>
        public event EventHandler<Exception> Error;

        public virtual void Dispose()
        {
            Error = null;
            BuildOwner?.Dispose();
        }
    }
}