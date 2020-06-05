using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Birch.Components;
using Birch.Compose;
using Birch.Hosts;
using Birch.iOS.Compose;
using Foundation;
using UIKit;

namespace Birch.iOS.Hosts
{
    class IosBuildHostInstance: BuildHostInstance
    {
        /// <summary>
        /// The environment for hosted instances
        /// </summary>
        private readonly HostEnvironment _hostEnvironment;


        public IosBuildHostInstance(HostEnvironment hostEnvironment, RootContainerFactory rootState) : base(hostEnvironment,rootState)
        {
            _hostEnvironment = hostEnvironment;
        }

        /// <summary>
        /// The layout engine has had a fatal error, pass it on to the error policy.
        /// </summary>
        /// <param name="exception"></param>
        protected override void FatalError(Exception exception)
        {
            _hostEnvironment.ErrorPolicy.FatalError(this,exception);
        }

        /// <summary>
        /// The layout engine has had an error which it wants to try and show an error message for.
        /// </summary>
        /// <param name="layoutContext"></param>
        /// <param name="exception"></param>
        /// <param name="current"></param>
        /// <returns></returns>
        protected override ElementShadowTransition DefaultLayoutError(LayoutContext layoutContext, Exception exception, ElementShadowPair current)
        {
            var errorLayout= _hostEnvironment.ErrorPolicy.LayoutErrorFormat(this,exception).Layout(layoutContext);

            var mst = CreateChangeTransactionalSet(current, errorLayout);
            return mst;
        }

        /// <summary>
        /// Create the context for an iOS build.
        /// </summary>
        /// <returns></returns>
        protected override IShadowContext CreateContext()
        {
            return new IosContext(HostEnvironment.ShadowMapperFactory,BuildOwner);;
        }
    }
}