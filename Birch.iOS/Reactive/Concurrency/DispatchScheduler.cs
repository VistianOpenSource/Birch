using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Concurrency;
using System.Reactive.Disposables;
using System.Text;
using CoreFoundation;
using Foundation;
using UIKit;

namespace Birch.iOS.Reactive.Concurrency
{
    public class DispatchScheduler:IScheduler
    {
        public static IScheduler MainThreadScheduler = new DispatchScheduler();

        /// <inheritdoc/>
        public DateTimeOffset Now => DateTimeOffset.Now;

        /// <inheritdoc/>
        public IDisposable Schedule<TState>(TState state, Func<IScheduler, TState, IDisposable> action)
        {
            var innerDisposable = new SingleAssignmentDisposable();

            DispatchQueue.MainQueue.DispatchAsync(() =>
            {
                if (!innerDisposable.IsDisposed)
                {
                    innerDisposable.Disposable = action(this, state);
                }
            });

            return innerDisposable;
        }

        /// <inheritdoc/>
        public IDisposable Schedule<TState>(TState state, DateTimeOffset dueTime, Func<IScheduler, TState, IDisposable> action)
        {
            if (dueTime <= Now)
            {
                return Schedule(state, action);
            }

            return Schedule(state, dueTime - Now, action);
        }

        /// <inheritdoc/>
        public IDisposable Schedule<TState>(TState state, TimeSpan dueTime, Func<IScheduler, TState, IDisposable> action)
        {
            var innerDisposable = Disposable.Empty;
            var isCancelled = false;

            var timer = NSTimer.CreateScheduledTimer(dueTime, _ =>
            {
                if (!isCancelled)
                {
                    innerDisposable = action(this, state);
                }
            });

            return Disposable.Create(() =>
            {
                isCancelled = true;
                timer.Invalidate();
                innerDisposable.Dispose();
            });
        }
    }
}