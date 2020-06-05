using System;
using System.Reactive.Disposables;
using Microsoft.Extensions.Logging;

namespace Birch.Diagnostics
{
    /// <summary>
    /// Do nothing <see cref="ILogger"/> implementation for when nothing has been specified.
    /// </summary>
    internal class NullLogging : ILogger
    {
        public static ILogger Instance = new NullLogging();

        /// <summary>
        /// Main logging function implementation, in this particular case do nothing.
        /// </summary>
        /// <typeparam name="TState"></typeparam>
        /// <param name="logLevel"></param>
        /// <param name="eventId"></param>
        /// <param name="state"></param>
        /// <param name="exception"></param>
        /// <param name="formatter"></param>
        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
        {
        }

        /// <summary>
        /// Indicate that not enabled for logging.
        /// </summary>
        /// <param name="logLevel"></param>
        /// <returns></returns>
        public bool IsEnabled(LogLevel logLevel)
        {
            return false;
        }

        public IDisposable BeginScope<TState>(TState state)
        {
            return Disposable.Empty;
        }
    }
}