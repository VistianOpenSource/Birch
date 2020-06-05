using System;
using System.Collections.Generic;
using System.Linq;
using Birch.Diagnostics;
using Birch.Hosts;
using Birch.Metrics;
using Birch.XamarinForms.Hosts;
using CodedUIExperiment.Views;
using Foundation;
using Microsoft.Extensions.Logging;
//using Microsoft.Extensions.Logging;
using UIKit;

namespace CodedUIExperiment.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        //
        // This method is invoked when the application has loaded and is ready to run. In this 
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        //
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.SetFlags(new string[] {"CollectionView_Experimental","RadioButton_Experimental"});
            global::Xamarin.Forms.Forms.Init();

            var pe = CodedUIExperiment.iOS.PlatformEnvironment.Instance;

            var builder=pe.CreateEnvironmentBuilder();

            var loggerFactory = LoggerFactory.Create(b => b.AddProvider(new Microsoft.Extensions.Logging.Debug.DebugLoggerProvider()));
            var logger = loggerFactory.CreateLogger("Birch");

            //builder.With(Settings.LoggingRules, new LoggingRulesList().Add(Rule.For(Categories.Reflection, true)).Add(Rule.For(Categories.Collections, true)));
            builder.With(Settings.Logging, logger);
            builder.With<LayoutCompletedHandler>(Settings.LayoutMetrics, (metrics) =>
            {
                Logging.Instance.LogInformation(LayoutMetricsFormatter.Format(metrics));
            });

            //var loggerFactory = LoggerFactory.Create(b => b.AddProvider(new Microsoft.Extensions.Logging.Debug.DebugLoggerProvider()));
            //var logger = loggerFactory.CreateLogger("Birch");

           //builder
                //.Logging(logger)
                //.LayoutMonitor(new LoggingLayoutMonitor())
                //.ErrorPolicy(new DefaultErrorPolicy())
                //  .LoggingRules(Rule.For(Categories.Reflection, true))
                //.LoggingRules(Rule.For(Categories.Collections, true))
                //.LoggingRules(Rule.For(Categories.Primitives,true));
                ;

                builder.Create();

                CodeWip.UIScheduler = Birch.iOS.Reactive.Concurrency.DispatchScheduler.MainThreadScheduler;

            LoadApplication(new App());


            return base.FinishedLaunching(app, options);
        }
    }
}
