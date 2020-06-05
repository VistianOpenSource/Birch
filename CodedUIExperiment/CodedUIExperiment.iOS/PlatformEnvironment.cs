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
using Birch.iOS.Hosts;
using Birch.XamarinForms.Hosts;
using Foundation;
using UIKit;
using Logging = Birch.Diagnostics.Logging;

namespace CodedUIExperiment.iOS
{
    public class PlatformEnvironment:IPlatformEnvironment
    {
        public static PlatformEnvironment Instance { get; } = new PlatformEnvironment();

        private class IosHostEnvironment : HostEnvironmentBuilder
        {
            public override void Apply(HostEnvironment settings)
            {
                Birch.XamarinForms.Hosts.BuildHost.CreateHost(settings);
            }
        }

        public EnvironmentBuilder CreateEnvironmentBuilder()
        {
            var layoutEngineOptions = new LayoutEngineOptions(TaskPoolScheduler.Default, Birch.iOS.Reactive.Concurrency.DispatchScheduler.MainThreadScheduler);

            var builder = new EnvironmentBuilder().With<IosHostEnvironment, HostEnvironment>(
                new HostEnvironment(new ShadowMapperFactory(), new DefaultErrorPolicy(), null, new LayoutResolver(),
                    layoutEngineOptions));

            return builder;
        }
    }
}