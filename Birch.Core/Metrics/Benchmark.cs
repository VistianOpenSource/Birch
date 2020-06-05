using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reactive.Disposables;

namespace Birch.Metrics
{
    /// <summary>
    /// Simplistic timing benchmarking block with custom action upon disposal.
    /// </summary>
    public class Benchmark : IDisposable 
    {
        /// <summary>
        /// The action to be performed when the benchmark is completed.
        /// </summary>
        private readonly Action<long,IReadOnlyList<BenchmarkEvent>> _completed;

        /// <summary>
        /// The timer used for measurement.
        /// </summary>
        private readonly Stopwatch _timer = new Stopwatch();

        /// <summary>
        /// The list of optional custom <see cref="BenchmarkEvent"/> events
        /// </summary>
        private List<BenchmarkEvent> _events;

        private static readonly IReadOnlyList<BenchmarkEvent> Empty = new List<BenchmarkEvent>().AsReadOnly();

        /// <summary>
        /// Create an instance,
        /// </summary>
        /// <param name="completed">The action to be performed when the benchmarking has completed</param>
        private Benchmark(Action<long,IReadOnlyList<BenchmarkEvent>> completed)
        {
            _completed = completed;
            _timer.Start();
        }

        /// <summary>
        /// Create a benchmarking instance, if enabled of course.
        /// </summary>
        /// <param name="completed"></param>
        /// <returns></returns>
        public static IDisposable Create(Action<long, IReadOnlyList<BenchmarkEvent>> completed)
        {
            return new Benchmark(completed);
        }

        /// <summary>
        /// On disposal, stop the timer and invoke the completed action.
        /// </summary>
        public void Dispose() 
        {
            _timer.Stop();
            _completed(_timer.ElapsedMilliseconds,_events?.AsReadOnly() ?? Empty);
        }

        /// <summary>
        /// Add an event to the benchmark.
        /// </summary>
        /// <param name="event"></param>
        public void AddEvent(string @event)
        {
            _events ??= new List<BenchmarkEvent>();

            _events.Add(new BenchmarkEvent(_timer.ElapsedMilliseconds,@event));
        }
    }
}