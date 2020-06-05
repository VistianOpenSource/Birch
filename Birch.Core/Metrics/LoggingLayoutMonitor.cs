using Birch.Diagnostics;
using Birch.Metrics.Layout;
using Microsoft.Extensions.Logging;

namespace Birch.Metrics
{
    /// <summary>
    /// Simplistic monitor for layouts which writes to the log.
    /// </summary>
    public class LoggingLayoutMonitor : ILayoutMonitor
    {
        public void Record(ILayoutEvent layoutEvent)
        {
            Logging.Instance.LogInformation(layoutEvent.ToString());
        }
    }
}