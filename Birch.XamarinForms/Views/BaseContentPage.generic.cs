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
using static Birch.Views.Primitives;

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
        protected readonly XamFormsBuildHostInstance Host;

        private IStatefulContainer<TModel> _statefulContainer;

        protected BaseContentPage()
        {
            Host = BuildHost.Create(this,(buildEnvironment,layoutContext) =>
            {
                var statefulContainer = CreateStateContainer(buildEnvironment);

                _statefulContainer = statefulContainer;

                Init(buildEnvironment);

                return statefulContainer;
            });


            // now start the host
            Host.Start();
        }

        protected void SetModel(TModel model)
        {
            _statefulContainer.SetModel(model);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            Host.Enabled = true;
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            Host.Enabled = false;
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
            return ContentPage(this,PerformLayout(layoutContext,model));
        }

        /// <summary>
        /// Create the root state container. Can be overridden to provide differing behaviour.
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        protected virtual IStatefulContainer<TModel> CreateStateContainer(BuildEnvironment context) => new HostInstanceStatefulContainer<TModel>(context, InitState, PerformContentLayout);
    }
}
