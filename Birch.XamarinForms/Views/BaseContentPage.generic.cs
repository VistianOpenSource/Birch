using System;
using System.Collections.Generic;
using System.Reactive;
using System.Text;
using Birch.Components;
using Birch.Compose;
using Birch.Hosts;
using Birch.Reflection;
using Birch.XamarinForms.Hosts;
using Xamarin.Forms;

namespace Birch.Views
{
    /// <summary>
    /// Base page for <see cref="Xamarin.Forms.ContentPage"/>
    /// </summary>
    [Preserve(AllMembers = true)]
    public abstract class BaseContentPage<TModel> : Xamarin.Forms.ContentPage
    {
        /// <summary>
        /// The associated build host instance
        /// </summary>
        private readonly XamFormsBuildHostInstance _host;

        /// <summary>
        /// Disposable created as a result of spinning up a host instance
        /// </summary>
        private IDisposable _hostDisposable;

        private IStatefulContainer<TModel> _statefulContainer;

        protected BaseContentPage()
        {
            _host = BuildHost.Create(this,(buildEnvironment,layoutContext) =>
            {
                var statefulContainer = CreateStateContainer(buildEnvironment);

                _statefulContainer = statefulContainer;

                Init(buildEnvironment);

                return statefulContainer;
            });

            // now start the host
            _hostDisposable = _host.Start();
        }

        protected void SetModel(TModel model)
        {
            _statefulContainer.SetModel(model);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _host.Enabled = true;
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            _host.Enabled = false;
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
        /// Default layout call, calls <see cref="PerformContentLayout"/>
        /// </summary>
        /// <param name="layoutContext"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        protected virtual IPrimitive PerformContentLayout(LayoutContext layoutContext, TModel model)
        {
            return new Birch.Views.ContentPage(this,PerformLayout(layoutContext,model));
        }

        /// <summary>
        /// Create the root state container. Can be overridden to provide differing behaviour.
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        protected virtual IStatefulContainer<TModel> CreateStateContainer(BuildEnvironment context) => new HostInstanceStatefulContainer<TModel>(context, InitState, PerformContentLayout);
    }
}
