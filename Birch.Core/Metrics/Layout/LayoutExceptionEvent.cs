using System;

namespace Birch.Metrics.Layout
{
    /// <summary>
    /// An exception occured during one of the layouts
    /// </summary>
    public class LayoutExceptionEvent:LayoutEvent
    {
        /// <summary>
        /// Get the exception that occured.
        /// </summary>
        public Exception Exception { get; }

        public LayoutExceptionEvent(Exception exception)
        {
            Exception = exception;
        }

        public override string ToString()
        {
            return $"LayoutException: {Exception.Message} {Exception.StackTrace}";
        }
    }
}