using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Concurrency;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Birch.Collections;
using Birch.Components;
using Birch.Compose;
using Birch.Diagnostics;
using Birch.Environment;
using Birch.Metrics;
using Birch.Views;
using Microsoft.Extensions.Logging;

namespace Birch.Hosts
{
    /// <summary>
    /// Android platform initializer
    /// </summary>
    public class PlatformEnvironment:IPlatformEnvironment
    {
        public static PlatformEnvironment Instance { get; } = new PlatformEnvironment();

        private class AndroidHostEnvironmentBuilder : HostEnvironmentBuilder
        {
            public override void Apply(HostEnvironment settings)
            {
                BuildHost.CreateHost(settings);
            }
        }

        public EnvironmentBuilder CreateEnvironmentBuilder()
        {
            var layoutEngineOptions = new LayoutEngineOptions(TaskPoolScheduler.Default, Birch.Reactive.Concurrency.HandlerScheduler.MainThreadScheduler);

            var environmentBuilder = new EnvironmentBuilder().With<AndroidHostEnvironmentBuilder,HostEnvironment>(
                new HostEnvironment(new ShadowMapperFactory(), new DefaultErrorPolicy(), null, new LayoutResolver(),
                    layoutEngineOptions,LayoutHostSettings.Default));

            return environmentBuilder;
        }

        /// <summary>
        /// Create a host and initialize the environment.
        /// </summary>
        /// <param name="builder"></param>
        public void Init(EnvironmentBuilder builder)
        {
            builder.Create();

            // create the main build host
            BuildHost.CreateHost(builder.Get<HostEnvironment>());
        }
    }
}