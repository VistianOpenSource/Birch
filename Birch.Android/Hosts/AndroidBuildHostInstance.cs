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
        /// The environment for hosted instances
        /// </summary>
        private readonly HostEnvironment _hostEnvironment;

        /// <summary>
        /// The associated activity
        /// </summary>
        public Android.App.Activity Activity { get; }

        public AndroidBuildHostInstance(HostEnvironment hostEnvironment, Android.App.Activity activity,
            RootContainerFactory rootState) : base(hostEnvironment,rootState)
        {
            _hostEnvironment = hostEnvironment;
            Activity = activity;
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
        /// Create the context for an Android build.
        /// </summary>
        /// <returns></returns>
        protected override IShadowContext CreateContext()
        {
            return new AndroidContext(HostEnvironment.ShadowMapperFactory,Activity,(d) => new Android.Views.ViewGroup.LayoutParams(d.Width,d.Height),BuildOwner);;
        }
    }
}