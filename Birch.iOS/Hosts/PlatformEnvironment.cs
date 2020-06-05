using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Concurrency;
using System.Text;
using Birch.Components;
using Birch.Compose;
using Birch.Diagnostics;
using Birch.Environment;
using Birch.Hosts;
using Foundation;
using UIKit;

namespace Birch.iOS.Hosts
{
    public class PlatformEnvironment:IPlatformEnvironment
    {
        public static PlatformEnvironment Instance { get; } = new PlatformEnvironment();

        public HostEnvironment.Builder CreateDefaultBuilder()
        {
            var layoutEngineOptions = new LayoutEngineOptions(Scheduler.Default, Birch.iOS.Reactive.Concurrency.DispatchScheduler.MainThreadScheduler);

            var builder = new HostEnvironment.Builder()
//                ErrorPolicy(new DefaultErrorPolicy())
                .LayoutOptions(layoutEngineOptions);

            return builder;
        }

        /// <summary>
        /// Create a host and initialize the environment.
        /// </summary>
        /// <param name="builder"></param>
        public void Init(HostEnvironment.Builder builder)
        {
            var hostEnvironment = builder.Create();

            // setup any logging rules
            LoggingRules.SetRules(LoggingRulesList.Create(false,hostEnvironment.LoggingRules));

            // create the main build host
            BuildHost.CreateHost(hostEnvironment);

            // now hang on, we need to do the appropriate registration and setup 
            Logging.Set(hostEnvironment.Logger);

            // set the default collection comparer for children 
            PrimitiveCollectionComparer.SetDefault(hostEnvironment.DefaultCollectionComparer);
        }
    }
}