using System;
using System.Reactive.Concurrency;
using System.Reactive.Disposables;
using Android.OS;

namespace Birch.Reactive.Concurrency
{
    /// <summary>
    /// HandlerScheduler is a scheduler that schedules items on a running 
    /// Activity's main thread. This is the moral equivalent of DispatcherScheduler.
    /// </summary>
    /// <remarks>
    /// Shamelessly taken from https://github.com/reactiveui/ReactiveUI/blob/master/src/ReactiveUI/Platforms/android/HandlerScheduler.cs given its the only
    /// part of ReactiveUI that is used within this solution and it makes more sense to take the source for one file than bring in a complete library.
    /// </remarks>
    public class HandlerScheduler : IScheduler
    {
        public static IScheduler MainThreadScheduler = new HandlerScheduler(new Handler(Looper.MainLooper), Looper.MainLooper.Thread.Id);

        private readonly Handler _handler;
        private readonly long _looperId;

        public HandlerScheduler(Handler handler, long? threadIdAssociatedWithHandler)
        {
            _handler = handler;
            _looperId = threadIdAssociatedWithHandler ?? -1;
        }

        public IDisposable Schedule<TState>(TState state, Func<IScheduler, TState, IDisposable> action)
        {
            var isCancelled = false;
            
            if (_looperId > 0 && _looperId == Java.Lang.Thread.CurrentThread().Id) 
            {
                return action(this, state);
            }

            var innerDisposable = new SerialDisposable() { Disposable = Disposable.Empty };

            _handler.Post(() => {
                if (isCancelled) return;
                innerDisposable.Disposable = action(this, state);
            });

            return new CompositeDisposable(Disposable.Create(() => isCancelled = true), innerDisposable);
        }

        public IDisposable Schedule<TState>(TState state, TimeSpan dueTime, Func<IScheduler, TState, IDisposable> action)
        {
            var isCancelled = false;
            var innerDisposable = new SerialDisposable() { Disposable = Disposable.Empty };

            _handler.PostDelayed(() => {
                if (isCancelled) return;
                innerDisposable.Disposable = action(this, state);
            }, dueTime.Ticks / 10 / 1000);

            return new CompositeDisposable(
                Disposable.Create(() => isCancelled = true),
                innerDisposable);
        }

        public IDisposable Schedule<TState>(TState state, DateTimeOffset dueTime, Func<IScheduler, TState, IDisposable> action)
        {
            return dueTime <= Now ? Schedule(state, action) : Schedule(state, dueTime - Now, action);
        }

        public DateTimeOffset Now => DateTimeOffset.Now;
    }
}