using System.Reactive.Concurrency;
using Birch.Collections;
using Birch.Components;
using Birch.Compose;
using Birch.Diagnostics;
using Birch.Environment;
using Birch.Hosts;
using Logging = Birch.Diagnostics.Logging;

namespace CodedUIExperiment.Droid
{
    /// <summary>
    /// Android platform initializer
    /// </summary>
    public class PlatformEnvironment:IPlatformEnvironment
    {
        public static PlatformEnvironment Instance { get; } = new PlatformEnvironment();

        private class AndroidXamFormsHostEnvironmentBuilder : HostEnvironmentBuilder
        {
            public override void Apply(HostEnvironment settings)
            {
                Birch.XamarinForms.Hosts.BuildHost.CreateHost(settings);
            }
        }

        public EnvironmentBuilder CreateEnvironmentBuilder()
        {
            var layoutEngineOptions = new LayoutEngineOptions(Scheduler.Default, Birch.Reactive.Concurrency.HandlerScheduler.MainThreadScheduler);

            var builder = new EnvironmentBuilder().With<AndroidXamFormsHostEnvironmentBuilder, HostEnvironment>(
                new HostEnvironment(new ShadowMapperFactory(), new DefaultErrorPolicy(), null, new LayoutResolver(),
                    layoutEngineOptions));

            return builder;
        }
    }
}