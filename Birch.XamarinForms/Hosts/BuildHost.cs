using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using Birch.Hosts;
using Xamarin.Forms.PlatformConfiguration;

namespace Birch.XamarinForms.Hosts
{
    /// <summary>
    /// The main Android default build host.
    /// </summary>
    public class BuildHost 
    {
        /// <summary>
        /// The host environment used by all instances.
        /// </summary>
        private readonly HostEnvironment _hostEnvironment;

        /// <summary>
        /// The function that creates an instance.
        /// </summary>
        private readonly Func<Xamarin.Forms.ContentPage,HostEnvironment, RootContainerFactory,XamFormsBuildHostInstance> _hostFactory;

        private BuildHost(HostEnvironment hostEnvironment, Func<Xamarin.Forms.ContentPage,HostEnvironment, RootContainerFactory,XamFormsBuildHostInstance> hostFactory)
        {
            _hostEnvironment = hostEnvironment;
            _hostFactory = hostFactory;
        }

        /// <summary>
        /// Our build host.
        /// </summary>
        private static BuildHost _instance;

        /// <summary>
        /// Create the build host
        /// </summary>
        /// <param name="hostEnvironment"></param>
        /// <param name="hostFactory"></param>
        public static void CreateHost([NotNull]HostEnvironment hostEnvironment,
            Func<Xamarin.Forms.ContentPage,HostEnvironment, RootContainerFactory, XamFormsBuildHostInstance> hostFactory=default)
        {
            if (_instance != null)
            {
                throw new InvalidOperationException("The build host has already been initialized.");
            }

            if (hostFactory == default)
            {
                hostFactory = (contentPage,environment, container) => new XamFormsBuildHostInstance(environment,contentPage,container);
            }

            _instance = new BuildHost(hostEnvironment,hostFactory);
        }

        /// <summary>
        /// Create a host instance.
        /// </summary>
        /// <param name="contentPage"></param>
        /// <param name="containerFactory"></param>
        /// <returns></returns>
        private XamFormsBuildHostInstance CreateInstance(Xamarin.Forms.ContentPage contentPage,RootContainerFactory containerFactory)
        {
            var instanceHost = _hostFactory(contentPage,_hostEnvironment, containerFactory);

            return instanceHost;
        }

        /// <summary>
        /// Create an android host instance associated wth the specified activity and stateful container function.
        /// </summary>
        /// <param name="contentPage"></param>
        /// <param name="containerFactory"></param>
        /// <returns></returns>
        public static XamFormsBuildHostInstance Create(Xamarin.Forms.ContentPage contentPage,RootContainerFactory containerFactory)
        {
            if (_instance == null)
            {
                throw new InvalidOperationException("Host has not been initialized\n Add BuildHost.CreateHost(<<environment>>,optional <<hostFactory>>) to your application initialization code.");
            }

            return _instance.CreateInstance(contentPage,containerFactory);
        }
    }
}
