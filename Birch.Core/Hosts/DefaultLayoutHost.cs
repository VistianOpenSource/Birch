using Birch.Components;
using Birch.Compose;
using Birch.Metrics.Layout;

namespace Birch.Hosts
{
    /// <summary>
    /// Standard Layout host which monitors changes to the <see cref="BuildOwner"/> to trigger layout changes
    /// </summary>
    public class DefaultLayoutHost : LayoutHost<LayoutRequest>
    {
        private readonly IStatefulContainer _rootContainer;

        public DefaultLayoutHost(BuildHostInstance buildHostInstance,LayoutHostSettings settings=default) : base(buildHostInstance,settings)
        {
            _rootContainer = buildHostInstance.RootContainer;
        }

        /// <summary>
        /// We only propagate changes when we are enabled AND the requested mutation id is the latest one known.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        protected override bool ShouldPropagate(LayoutRequest request) => BuildOwner.IsLatestMutation(request.MutationId) && Enabled;

        protected override IPrimitive PerformLayout(LayoutRequest request)
        {
            return _rootContainer.Layout(request.LayoutContext);
        }

        public override void Start()
        {
            // monitor the build owner for changes in the model(s) state
            BuildOwner.Changed += (sender, args) =>
            {
                // record the model value in the model bag
                BuildOwner.ModelBag.SetModel(args.Change.Container,args.Change.Model,args.Change.MutationId);

                Record(new ModelChangedEvent(args.Change));

                // now create the layout request and send it on its way
                var changedRequest = new LayoutRequest(LayoutContext.Create(BuildOwner.ModelBag, BuildHostInstance.HostEnvironment.LayoutResolver),args.Change.MutationId);
                this.Execute(changedRequest,Settings.Mode == LayoutMode.Sync);
            };

            // our initial request
            var request = new LayoutRequest(LayoutContext.Create(BuildOwner.ModelBag, BuildHostInstance.HostEnvironment.LayoutResolver),BuildOwner.StartMutationId);

            // execute the first pass
            Execute(request,Settings.Mode != LayoutMode.Async);
        }

        public override void Dispose()
        {
            BuildOwner.Changed = null;

            base.Dispose();
        }
    }
}