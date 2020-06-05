using System;
using Birch.Components;
using Birch.Compose;

namespace Birch.Hosts
{
    /// <summary>
    /// Stateful container which forms the root state container.
    /// </summary>
    /// <typeparam name="TModel"></typeparam>
    public class HostInstanceStatefulContainer<TModel> : StatefulContainer<TModel>
    {
        private readonly Func<TModel> _initState;
        private readonly Func<LayoutContext, TModel, IPrimitive> _performLayout;

        public HostInstanceStatefulContainer(BuildEnvironment environment,Func<TModel> initState,Func<LayoutContext,TModel,IPrimitive> performLayout) : base(environment)
        {
            _initState = initState;
            _performLayout = performLayout;
        }

        public override TModel InitState() => _initState();

        protected override IPrimitive PerformLayout(LayoutContext layoutContext, TModel model) =>  _performLayout(layoutContext, model);
    }
}