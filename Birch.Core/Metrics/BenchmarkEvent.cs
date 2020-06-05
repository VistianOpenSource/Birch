namespace Birch.Metrics
{
    /// <summary>
    /// A single benchmark event
    /// </summary>
    public readonly struct BenchmarkEvent
    {
        /// <summary>
        /// The duration in milliseconds from when the benchmark started
        /// </summary>
        public long ElapsedMilliseconds { get;  }

        /// <summary>
        /// The event to be recorded
        /// </summary>
        public string Event { get; }

        public BenchmarkEvent(long elapsedMilliseconds, string @event)
        {
            ElapsedMilliseconds = elapsedMilliseconds;
            Event = @event;
        }
    }
}