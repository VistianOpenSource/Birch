using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Birch.Tasks
{
    /// <summary>Provides an observable for a readable channel.</summary>
    ///
    /// <remarks>
    /// Taken from https://github.com/dotnet/corefxlab/blob/fb40c77a708f2161a4d1469a2f118ea4c81bd31d/src/System.Threading.Tasks.Channels/System/Threading/Tasks/Channels/ReadableChannel.cs</remarks>
    public sealed class ChannelObservable<T> : IObservable<T>
    {
        /*
        /// <summary>Table mapping from a channel to the shared observable wrapping it.</summary>
        private static ConditionalWeakTable<ChannelReader<T>, ChannelObservable<T>> s_channelToObservable;

        
        public virtual IObservable<T> AsObservable() =>
            LazyInitializer.EnsureInitialized(ref s_channelToObservable).GetValue(this, s => new ChannelObservable<T>(s));
        */
        /// <summary>Creates an observable for this channel.</summary>
        /// <returns>An observable that pulls data from this channel.</returns>


        private readonly List<IObserver<T>> _observers = new List<IObserver<T>>();

        private readonly ChannelReader<T> _channel;
        private bool _active;

        internal ChannelObservable(ChannelReader<T> channel)
        {
            Debug.Assert(channel != null);
            _channel = channel;
        }

        public IDisposable Subscribe(IObserver<T> observer)
        {
            if (observer == null)
            {
                throw new ArgumentNullException(nameof(observer));
            }

            lock (_observers)
            {
                _observers.Add(observer);
                QueueLoopIfNecessary();
            }

            return new Unsubscribe<T>(this, observer);
        }

        private void QueueLoopIfNecessary()
        {
            Debug.Assert(Monitor.IsEntered(_observers));
            if (!_active && _observers.Count > 0)
            {
                _active = true;
                Task.Factory.StartNew(s => ((ChannelObservable<T>) s).ForwardLoopAsync(), this,
                    CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default);
            }
        }

        private async void ForwardLoopAsync()
        {
            Exception error = null;
            try
            {
                while (await _channel.WaitToReadAsync().ConfigureAwait(false))
                {
                    lock (_observers)
                    {
                        if (_observers.Count == 0)
                        {
                            break;
                        }

                        if (_channel.TryRead(out T item))
                        {
                            foreach (IObserver<T> observer in _observers)
                            {
                                observer.OnNext(item);
                            }
                        }
                    }
                }
            }
            catch (ChannelClosedException exc)
            {
                error = exc.InnerException;
            }
            catch (Exception exc)
            {
                error = exc;
            }
            finally
            {
                lock (_observers)
                {
                    _active = false;
                    if (_channel.Completion.IsCompleted)
                    {
                        if (_channel.Completion.IsFaulted)
                        {
                            error = _channel.Completion.Exception.InnerException;
                            Debug.Assert(error != null);
                        }
                        else if (_channel.Completion.IsCanceled)
                        {
                            try
                            {
                                _channel.Completion.GetAwaiter().GetResult();
                            }
                            catch (Exception e)
                            {
                                error = e;
                            }

                            Debug.Assert(error != null);
                        }

                        foreach (IObserver<T> observer in _observers)
                        {
                            if (error != null)
                            {
                                observer.OnError(error);
                            }
                            else
                            {
                                observer.OnCompleted();
                            }
                        }

                        _observers.Clear();
                    }
                    else
                    {
                        QueueLoopIfNecessary();
                    }
                }
            }
        }

        private sealed class Unsubscribe<T> : IDisposable
        {
            private readonly ChannelObservable<T> _observable;
            private IObserver<T> _observer;

            internal Unsubscribe(ChannelObservable<T> observable, IObserver<T> observer)
            {
                Debug.Assert(observable != null);
                Debug.Assert(observer != null);

                _observable = observable;
                _observer = observer;
            }

            public void Dispose()
            {
                lock (_observable._observers)
                {
                    if (_observer != null)
                    {
                        if (!_observable._channel.Completion.IsCompleted)
                        {
                            bool removed = _observable._observers.Remove(_observer);
                            Debug.Assert(removed);
                        }

                        _observer = null;
                    }
                }
            }
        }
    }
}