using System.Text;
using Birch.Reflection;

namespace Birch.Metrics
{
    /// <summary>
    /// Basic textual formatter for layout metrics.
    /// </summary>
    public static class LayoutMetricsFormatter
    {
        private const int LevelSpaceMultiplier = 4;

        public static string Format(LayoutInstanceMetric metrics)
        {
            var sb = new StringBuilder();

            var preAppend = metrics.Children.Count > 0 ? "+" : string.Empty;

            sb.AppendLine($"{new string(' ',metrics.Level*LevelSpaceMultiplier)} {preAppend} {metrics.Start:HH:mm:ss.FFF} {metrics.Component.GetType().FriendlyName()} {metrics.ElapsedMilliseconds}ms");

            if (metrics.Children.Count > 0)
            {
                foreach (var child in metrics.Children)
                {
                    sb.Append((string) Format(child));
                }
            }

            return sb.ToString();
        }
    }
}