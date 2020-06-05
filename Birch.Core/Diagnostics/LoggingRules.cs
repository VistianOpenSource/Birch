using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;

namespace Birch.Diagnostics
{
    /// <summary>
    /// Static class for specified logging <see cref="LoggingRulesList"/>
    /// </summary>
    /// <remarks>
    /// It should be noted that logging rules are optional and in no way change what it actually logged; there is a separation of
    /// the actual logging and what should be locked, the rules are primarily just to filter out the generation of logging information.
    /// </remarks>
    public static class LoggingRules
    {
        /// <summary>
        /// Get or Set the <see cref="LoggingRulesList"/> to be applied when the IsLoggingEnabled methods are utilized.
        /// </summary>
        private static LoggingRulesList RulesList { get; set; } = new LoggingRulesList();

        public static void SetRules(LoggingRulesList loggingRulesList)
        {
            RulesList = loggingRulesList??new LoggingRulesList();
        }

        /// <summary>
        /// For a specified type, return the <see cref="Diagnostics.LoggingModes"/> associated with it.
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>
        internal static LoggingModes GetModesFor(int category)
        {
            var debug = RulesList.IsLoggingEnabled(category, LogLevel.Debug);

            var critical = RulesList.IsLoggingEnabled(category, LogLevel.Critical);

            var error = RulesList.IsLoggingEnabled(category, LogLevel.Critical);

            var information = RulesList.IsLoggingEnabled(category, LogLevel.Information);

            var trace = RulesList.IsLoggingEnabled(category, LogLevel.Trace);

            var warning = RulesList.IsLoggingEnabled(category, LogLevel.Warning);

            return new LoggingModes(debug,critical,error,information,trace,warning);
        }

        internal static readonly Dictionary<int,LoggingModes> LoggingModes = new Dictionary<int, LoggingModes>();

        /// <summary>
        /// Get/Build the logging types for a specified type
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>
        public static LoggingModes For(int category)
        {
            if (!LoggingModes.TryGetValue(category,out var loggingModes))
            {
                loggingModes = GetModesFor(category);
                LoggingModes[category] = loggingModes;
            }

            return loggingModes;
        }
    }
}