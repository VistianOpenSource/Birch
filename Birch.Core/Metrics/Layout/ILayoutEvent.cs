using System;

namespace Birch.Metrics.Layout
{
    /// <summary>
    /// Specification of a layout event
    /// </summary>
    public interface ILayoutEvent
    {
        /// <summary>
        /// Get the <see cref="DateTimeOffset"/> when this event occured.
        /// </summary>
        public DateTimeOffset When { get; }
    }
}