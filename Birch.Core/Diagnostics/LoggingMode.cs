using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Logging;

namespace Birch.Diagnostics
{
    /// <summary>
    /// Represents whether differing levels of logging is enabled or not.
    /// </summary>
    public readonly struct LoggingModes
    {
        public bool Debug { get;  }

        public bool Critical { get;  }

        public bool Error { get; }

        public bool Information { get; }

        public bool Trace { get; }

        public bool Warning { get; }

        public bool Any { get; }

        public LoggingModes(bool debug, bool critical, bool error, bool information, bool trace, bool warning)
        {
            Debug = debug;
            Critical = critical;
            Error = error;
            Information = information;
            Trace = trace;
            Warning = warning;

            Any = debug || critical || error || information || trace || warning;

        }
    }

    internal static class LoggingModesExtensions
    {
        public static bool IsEnabled(this LoggingModes modes,LogLevel level)
        {
            return level switch
            {
                LogLevel.Trace => modes.Trace,
                LogLevel.Debug => modes.Debug,
                LogLevel.Information => modes.Information,
                LogLevel.Warning => modes.Warning,
                LogLevel.Error => modes.Error,
                LogLevel.Critical => modes.Critical,
                LogLevel.None => throw new ArgumentOutOfRangeException(nameof(level), level, $"None Not allowed"),
                _ => throw new ArgumentOutOfRangeException(nameof(level), level, $"Not allowed")
            };
        }
    }

}
