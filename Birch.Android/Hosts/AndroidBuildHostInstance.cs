using System;
using System.Reactive.Concurrency;
using Birch.Components;
using Birch.Compose;

namespace Birch.Hosts
{
    /// <summary>
    /// Android Activity based build host.
    /// </summary>
    public class AndroidBuildHostInstance : BuildHostInstance
    {
        /// <summary>
        /// The associated activity
        /// </summary>
        public Android.App.Activity Activity { get; }

        public AndroidBuildHostInstance(HostEnvironment hostEnvironment, Android.App.Activity activity,
            RootContainerFactory rootState) : base(hostEnvironment,rootState)
        {
            Activity = activity;
        }


        protected override IBuildErrorPolicy ErrorPolicy() => new DefaultErrorPolicy();

        /// <summary>
        /// Create the context for an Android build.
        /// </summary>
        /// <returns></returns>
        protected override IShadowContext CreateShadowContext()
        {
            return new AndroidContext(HostEnvironment.ShadowMapperFactory,Activity,(d) => new Android.Views.ViewGroup.LayoutParams(d.Width,d.Height),BuildOwner);;
        }
    }
}