using System;
using System.Collections.Generic;
using System.Text;
using Birch.Components;
using Birch.Compose;
using Xamarin.Forms;

namespace Birch.Hosts
{
    /// <summary>
    /// Xamarin forms implementation of <see cref="BuildHostInstance"/>
    /// </summary>
    public class XamFormsBuildHostInstance:BuildHostInstance
    {
        /// <summary>
        /// The environment for hosted instances
        /// </summary>
        private readonly HostEnvironment _hostEnvironment;

        public ContentPage ContentPage { get; }

        public XamFormsBuildHostInstance(HostEnvironment hostEnvironment,Xamarin.Forms.ContentPage contentPage,RootContainerFactory rootState) : base(hostEnvironment,rootState)
        {
            ContentPage = contentPage;
            _hostEnvironment = hostEnvironment;
        }

        protected override void FatalError(Exception exception)
        {
            _hostEnvironment.ErrorPolicy.FatalError(this,exception);
        }

        protected override ElementShadowTransition DefaultLayoutError(LayoutContext layoutContext, Exception exception, ElementShadowPair current)
        {
            var errorLayout= _hostEnvironment.ErrorPolicy.LayoutErrorFormat(this,exception).Layout(layoutContext);

            var mst = CreateChangeTransactionalSet(current, errorLayout);
            return mst;
        }

        protected override IShadowContext CreateContext()
        {
            return new XamFormsContext(_hostEnvironment.ShadowMapperFactory, BuildOwner);
        }
    }
}
