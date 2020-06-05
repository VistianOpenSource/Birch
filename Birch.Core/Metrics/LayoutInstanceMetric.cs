using System;
using System.Collections.Generic;
using System.Diagnostics;
using Birch.Components;

namespace Birch.Metrics
{
    public sealed class LayoutInstanceMetric
    {
        /// <summary>
        /// The parent of the layout metric 
        /// </summary>
        public LayoutInstanceMetric Parent { get; }

        /// <summary>
        /// The component associated with this metric
        /// </summary>
        public IElement Component { get; }

        /// <summary>
        /// The level of this layout metric.
        /// </summary>
        public int Level { get; }

        private readonly Stopwatch _sw;

        /// <summary>
        /// Get the total number of milliseconds
        /// </summary>
        public long ElapsedMilliseconds { get; private set; }

        /// <summary>
        /// Get the date when this metric started being recorded
        /// </summary>
        public DateTimeOffset Start { get;  }

        public IList<LayoutInstanceMetric> Children { get; } = new List<LayoutInstanceMetric>();

        public LayoutInstanceMetric(LayoutInstanceMetric parent,int level,IElement component)
        {
            Level = level;
            Parent = parent;
            Component = component;
            Start = DateTimeOffset.Now;
            _sw = Stopwatch.StartNew();
        }

        public void Add(LayoutInstanceMetric layoutInstanceMetric)
        {
            Children.Add(layoutInstanceMetric);
        }

        public void Stop()
        {
            ElapsedMilliseconds = _sw.ElapsedMilliseconds;
            _sw.Stop();
        }
    }
}