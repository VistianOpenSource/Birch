using System;
using System.Diagnostics.CodeAnalysis;
using Birch.Components;
using Birch.Compose;

namespace Birch.Hosts
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
        private readonly Func<Android.App.Activity, HostEnvironment, RootContainerFactory,AndroidBuildHostInstance> _hostFactory;

        private BuildHost(HostEnvironment hostEnvironment, Func<Android.App.Activity, 
                        HostEnvironment, RootContainerFactory,AndroidBuildHostInstance> hostFactory)
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
            Func<Android.App.Activity, HostEnvironment, RootContainerFactory, AndroidBuildHostInstance> hostFactory=default)
        {
            if (_instance != null)
            {
                throw new InvalidOperationException("The build host has already been initialized.");
            }

            if (hostFactory == default)
            {
                hostFactory = (activity, environment, container) => new AndroidBuildHostInstance(environment,activity, container);
            }

            _instance = new BuildHost(hostEnvironment,hostFactory);
        }

        /// <summary>
        /// Create a host instance.
        /// </summary>
        /// <param name="activity"></param>
        /// <param name="containerFactory"></param>
        /// <returns></returns>
        private AndroidBuildHostInstance CreateInstance(Android.App.Activity activity, RootContainerFactory containerFactory)
        {
            var instanceHost = _hostFactory(activity, _hostEnvironment, containerFactory);

            return instanceHost;
        }

        /// <summary>
        /// Create an android host instance associated wth the specified activity and stateful container function.
        /// </summary>
        /// <param name="activity"></param>
        /// <param name="containerFactory"></param>
        /// <returns></returns>
        public static AndroidBuildHostInstance Create(Android.App.Activity activity, RootContainerFactory containerFactory)
        {
            if (_instance == null)
            {
                throw new InvalidOperationException("Host has not been initialized\n Add BuildHost.CreateHost(<<environment>>,optional <<hostFactory>>) to your application initialization code.");
            }

            return _instance.CreateInstance(activity, containerFactory);
        }
    }
}