using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Birch.Diagnostics;
using Birch.Hosts;
using Birch.Metrics;
using Birch.Reactive.Concurrency;
using CodedUIExperiment.Views;
using Microsoft.Extensions.Logging;

namespace CodedUIExperiment.Droid
{
    [Activity(Label = "CodedUIExperiment", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);

            global::Xamarin.Forms.Forms.SetFlags(new string[] {"CollectionView_Experimental","RadioButton_Experimental"});
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);


            CodeWip.UIScheduler = new HandlerScheduler(new Handler(Looper.MainLooper), Looper.MainLooper.Thread.Id);


            var pe = PlatformEnvironment.Instance;

            var builder=pe.CreateEnvironmentBuilder();

            var loggerFactory = LoggerFactory.Create(b => b.AddProvider(new Microsoft.Extensions.Logging.Debug.DebugLoggerProvider()));
            var logger = loggerFactory.CreateLogger("Birch");

            //builder.With(Settings.LoggingRules, new LoggingRulesList(){Rule.For(Categories.Reflection, true)});

            builder.With(Settings.Logging, logger);
            builder.With<LayoutCompletedHandler>(Settings.LayoutMetrics, (metrics) =>
            {
                Logging.Instance.LogInformation(LayoutMetricsFormatter.Format(metrics));
            });

            builder.Create();


            LoadApplication(new App());
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}