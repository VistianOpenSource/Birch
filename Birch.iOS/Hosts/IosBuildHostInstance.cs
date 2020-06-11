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
    public class IosBuildHostInstance: BuildHostInstance
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
        /// Get the error policy to be used, currently null.
        /// </summary>
        /// <returns></returns>
        protected override IBuildErrorPolicy ErrorPolicy() => null;

        /// <summary>
        /// Create the shadow context for an iOS build.
        /// </summary>
        /// <returns></returns>
        protected override IShadowContext CreateShadowContext()
        {
            return new IosContext(HostEnvironment.ShadowMapperFactory,BuildOwner);;
        }
    }
}