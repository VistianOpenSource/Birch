using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using Birch.Hosts;
using Foundation;
using UIKit;

namespace Birch.iOS.Hosts
{
    class BuildHost
    {
        /// <summary>
        /// The host environment used by all instances.
        /// </summary>
        private readonly HostEnvironment _hostEnvironment;

        /// <summary>
        /// The function that creates an instance.
        /// </summary>
        private readonly Func<HostEnvironment, RootContainerFactory,IosBuildHostInstance> _hostFactory;

        private BuildHost(HostEnvironment hostEnvironment, Func<HostEnvironment, RootContainerFactory,IosBuildHostInstance> hostFactory)
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
            Func<HostEnvironment, RootContainerFactory, IosBuildHostInstance> hostFactory=default)
        {
            if (_instance != null)
            {
                throw new InvalidOperationException("The build host has already been initialized.");
            }

            if (hostFactory == default)
            {
                hostFactory = (environment, container) => new IosBuildHostInstance(environment,container);
            }

            _instance = new BuildHost(hostEnvironment,hostFactory);
        }

        /// <summary>
        /// Create a host instance.
        /// </summary>
        /// <param name="containerFactory"></param>
        /// <returns></returns>
        private IosBuildHostInstance CreateInstance(RootContainerFactory containerFactory)
        {
            var instanceHost = _hostFactory(_hostEnvironment, containerFactory);

            return instanceHost;
        }

        /// <summary>
        /// Create an android host instance associated wth the specified activity and stateful container function.
        /// </summary>
        /// <param name="activity"></param>
        /// <param name="containerFactory"></param>
        /// <returns></returns>
        public static IosBuildHostInstance Create(RootContainerFactory containerFactory)
        {
            if (_instance == null)
            {
                throw new InvalidOperationException("Host has not been initialized\n Add BuildHost.CreateHost(<<environment>>,optional <<hostFactory>>) to your application initialization code.");
            }

            return _instance.CreateInstance(containerFactory);
        }
    }
}