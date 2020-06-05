using System;
using Microsoft.Extensions.Logging;

namespace Birch.Diagnostics
{
    /// <summary>
    /// Specification of a single logging rule.
    /// </summary>
    public interface ILoggingRule
    {
        /// <summary>
        /// Whether this logging rule is valid 
        /// </summary>
        /// <param name="category"></param>
        /// <param name="level"></param>
        /// <returns></returns>
        bool IsMatch(int category, LogLevel? level);

        /// <summary>
        /// Whether logging is enabled when this is a match.
        /// </summary>
        bool Enabled { get; }
    }
}