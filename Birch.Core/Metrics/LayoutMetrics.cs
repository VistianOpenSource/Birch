using System.Diagnostics;
using Birch.Components;

namespace Birch.Metrics
{
    public delegate void LayoutCompletedHandler(LayoutInstanceMetric metric);

    /// <summary>
    /// Simple layout metric recorder.
    /// </summary>
    public static class LayoutMetrics
    {
        /// <summary>
        /// the current metric in play
        /// </summary>
        private static LayoutInstanceMetric _current;

        /// <summary>
        /// A counter of the current level which the metrics are at
        /// </summary>
        private static int _level;

        /// <summary>
        /// Lock to avoid read/update issues
        /// </summary>
        private static readonly object Lock = new object();

        /// <summary>
        /// Event used for each set of completed Layout Completions.
        /// </summary>
        public static LayoutCompletedHandler LayoutCompleted;

        private static bool _enabled = false;
        /// <summary>
        /// Get or set whether metric recording is enabled.
        /// </summary>
        /// 
        public static bool Enabled
        {
            get => _enabled;
            set
            {
                // if transitioning to disabled then clear down any current log entry
                if (!value && _enabled)
                {
                    lock (Lock)
                    {
                        _current = null;
                    }
                }

                _enabled = value;
            }
        }

        /// <summary>
        /// Start the recording of a new set of layout metrics for a specified component
        /// </summary>
        /// <param name="component"></param>
        [Conditional("DEBUG")]
        [DebuggerStepThrough]
        public static void Record(IElement component)
        {
            if (Enabled)
            {
                lock (Lock)
                {

                    var newLevel = ++_level;

                    var newMetric = new LayoutInstanceMetric(_current, newLevel, component);

                    // if already have a level metrics, add it to the 
                    // list of the current metric
                    if (newLevel > 1)
                    {
                        _current.Add(newMetric);
                    }

                    // and now make the current metric the new one
                    _current = newMetric;
                }
            }
        }

        /// <summary>
        /// The layout has completed, record how long it took and
        /// 
        /// </summary>
        [Conditional("DEBUG")]
        [DebuggerStepThrough]
        public static void Complete()
        {
            if (Enabled)
            {
                LayoutInstanceMetric completed = default;
                lock (Lock)
                {
                    _current.Stop();

                    var reducedLevel = --_level;

                    if (reducedLevel == 0)
                    {
                        completed = _current;
                    }

                    _current = reducedLevel == 0 ? null : _current.Parent;
                }

                // and if we have completed, invoke the event 
                if (completed != default)
                {
                    LayoutCompleted?.Invoke(completed);
                }
            }
        }
    }
}