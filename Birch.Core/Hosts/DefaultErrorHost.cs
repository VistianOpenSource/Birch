using System;
using Birch.Components;
using Birch.Compose;

namespace Birch.Hosts
{
    /// <summary>
    /// Default layout host for errors, with a custom layout being presented to show exceptions.
    /// </summary>
    /// <typeparam name="TBuildHostInstance"></typeparam>
    /// 
    public class DefaultErrorHost<TBuildHostInstance>:LayoutHost<LayoutRequest> where TBuildHostInstance:BuildHostInstance
    {
        private readonly Func<TBuildHostInstance, Exception, IElement> _errorPolicy;
        private readonly Exception _exception;
        private readonly LayoutContext _layoutContext;

        public DefaultErrorHost(BuildHostInstance buildHostInstance, Func<TBuildHostInstance, Exception,IElement> errorPolicy, Exception exception, LayoutContext layoutContext,LayoutHostSettings settings=default) :
            base(buildHostInstance,settings)
        {
            _errorPolicy = errorPolicy;
            _exception = exception;
            _layoutContext = layoutContext;
        }

        /// <summary>
        /// 
        /// </summary>
        public override void Start()
        {
            var request = new LayoutRequest( LayoutContext.Create(BuildOwner.ModelBag, BuildHostInstance.HostEnvironment.LayoutResolver),BuildOwner.StartMutationId);

            this.Execute(request,Settings.Mode != LayoutMode.Async);
        }

        /// <summary>
        /// Get the layout from the provided error policy function.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        protected override IPrimitive PerformLayout(LayoutRequest request)
        {
            return _errorPolicy((TBuildHostInstance)BuildHostInstance,_exception).Layout(_layoutContext);
        }
    }
}