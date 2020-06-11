using System;
using System.Collections.Generic;
using System.Text;
using Birch.Components;
using Birch.Compose;
using Birch.XamarinForms.Hosts;
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

        protected override IBuildErrorPolicy ErrorPolicy() => new DefaultErrorPolicy();
        


        protected override IShadowContext CreateShadowContext()
        {
            return new XamFormsContext(_hostEnvironment.ShadowMapperFactory, BuildOwner);
        }
    }
}
