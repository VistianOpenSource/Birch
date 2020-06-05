using System;
using Birch.Metrics.Layout;

namespace Birch.Metrics
{
    public class ConsoleLayoutMonitor:ILayoutMonitor
    {
        public void Record(ILayoutEvent layoutEvent)
        {
            Console.WriteLine(layoutEvent.ToString());
        }
    }
}