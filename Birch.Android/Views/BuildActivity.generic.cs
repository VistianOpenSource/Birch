using System;
using Android.OS;
using Android.Support.V7.App;
using Birch.Components;
using Birch.Compose;
using Birch.Hosts;

namespace Birch.Views
{
    /// <summary>
    /// Base activity for a layout 
    /// </summary>
    [Preserve(AllMembers = true)]
    public abstract class BuildActivity<TModel> : AppCompatActivity
    {
        /// <summary>
        /// The associated build host instance
        /// </summary>
        private AndroidBuildHostInstance _host;


        /// <summary>
        /// Create the environment to allow for Model View Update to operate for this activity.
        /// </summary>
        /// <param name="savedInstanceState"></param>
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);


            _host = BuildHost.Create(this,(buildEnvironment,layoutContext) =>
            {
                var statefulContainer = CreateStateContainer(buildEnvironment);

                Init(buildEnvironment);

                return statefulContainer;
            });


            // now start the host
            _host.Start();
        }

        /// <summary>
        /// Pause the host
        /// </summary>
        protected override void OnPause()
        {
            base.OnPause();
            _host.Enabled = false;
        }

        /// <summary>
        /// Resume the host
        /// </summary>
        protected override void OnResume()
        {
            base.OnResume();
            _host.Enabled = true;
        }

        /// <summary>
        /// We are being destroyed, dispose of the host
        /// </summary>
        protected override void OnDestroy()
        {
            _host?.Dispose();
            base.OnDestroy();
        }

        /// <summary>
        /// Invoked when the environment has been created.
        /// </summary>
        /// <param name="buildEnvironment"></param>
        public virtual void Init(BuildEnvironment buildEnvironment)
        {
        }

        /// <summary>
        /// Default init state call
        /// </summary>
        /// <returns></returns>
        public abstract TModel InitState();

        /// <summary>
        /// Default layout call.
        /// </summary>
        /// <param name="layoutContext"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        protected abstract IPrimitive PerformLayout(LayoutContext layoutContext,TModel model);

        /// <summary>
        /// Create the root state container. Can be overridden to provide differing behaviour.
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        protected virtual IStatefulContainer<TModel> CreateStateContainer(BuildEnvironment context) => new HostInstanceStatefulContainer<TModel>(context, InitState, PerformLayout);
    }
}