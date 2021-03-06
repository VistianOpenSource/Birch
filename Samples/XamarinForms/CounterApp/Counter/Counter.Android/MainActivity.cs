﻿using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Birch.Diagnostics;
using Birch.Hosts;
using Birch.Metrics;
using Birch.Transactions;
using Birch.XamarinForms.Android.Hosts;
using Microsoft.Extensions.Logging;

namespace Counter.Droid
{
    [Activity(Label = "Counter", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize )]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);

            var pe = PlatformEnvironment.Instance;

            var builder=pe.CreateEnvironmentBuilder();
            var loggerFactory = LoggerFactory.Create(b => b.AddProvider(new Microsoft.Extensions.Logging.Debug.DebugLoggerProvider()));
            var logger = loggerFactory.CreateLogger("Birch");

            //builder.With(Settings.Logging, logger);
            //builder.With(Settings.LoggingRules,new LoggingRulesList() {Rule.For(Categories.Collections), Rule.For(Categories.Reflection)});

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