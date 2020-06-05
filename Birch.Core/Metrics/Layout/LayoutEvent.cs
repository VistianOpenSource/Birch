using System;

namespace Birch.Metrics.Layout
{
    /// <summary>
    /// Base class from which <see cref="ILayoutEvent"/> can inherit
    /// </summary>
    public abstract class LayoutEvent:ILayoutEvent
    {
        /// <summary>
        /// Get the <see cref="DateTimeOffset"/> when this event occured
        /// </summary>
        public DateTimeOffset When { get; } = DateTimeOffset.Now;
    }
}