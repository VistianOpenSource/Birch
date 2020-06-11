using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Birch.Compose;
using Birch.Environment;
using Birch.Hosts;
using System.Reactive.Concurrency;

namespace Birch.XamarinForms.Android.Hosts
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
                new HostEnvironment(new ShadowMapperFactory(), new Birch.XamarinForms.Hosts.DefaultErrorPolicy(),  null, new LayoutResolver(),
                    layoutEngineOptions,LayoutHostSettings.Default));

            return builder;
        }
    }
}