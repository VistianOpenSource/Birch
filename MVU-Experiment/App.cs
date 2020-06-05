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
using Birch.Compose;
using Birch.Diagnostics;
using Birch.Hosts;
using Birch.Metrics;
using Birch.Reflection;
using Birch.Views;
using Microsoft.Extensions.Logging;
using Logging = Birch.Diagnostics.Logging;

namespace MVU_Experiment
{
#if DEBUG
    [Application(Debuggable=true)]
#else
[Application(Debuggable = false)]
#endif
    public class App:Application
    {
        public App(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer) { }

        public override void OnCreate()
        {
            base.OnCreate();

            var pe = PlatformEnvironment.Instance;

            var builder=pe.CreateEnvironmentBuilder();

            var loggerFactory = LoggerFactory.Create(b => b.AddProvider(new Microsoft.Extensions.Logging.Debug.DebugLoggerProvider()));
            var logger = loggerFactory.CreateLogger("Birch");

            //builder.With<Birch.Hosts.Logging, ILogger>(logger);

                //.Logging(logger)
                //.LayoutMonitor(new LoggingLayoutMonitor())
                //.ErrorPolicy(new DefaultErrorPolicy())
                //.LoggingRules(Rule.For(Categories.Reflection, true))
                //.LoggingRules(Rule.For(Categories.Collections, true)).
                //.LoggingRules(Rule.For(Categories.Primitives,true));
                ;


            builder.Create();
            //pe.Init(builder);


            LayoutMetrics.Enabled = false;
            LayoutMetrics.LayoutCompleted += metric =>
            {
                Logging.Instance.LogInformation(LayoutMetricsFormatter.Format(metric));
            };
        }
    }
}