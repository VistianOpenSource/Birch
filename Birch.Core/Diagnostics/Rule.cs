using System;
using Microsoft.Extensions.Logging;

namespace Birch.Diagnostics
{
    /// <summary>
    /// Simple <see cref="Func{T1,T2,TResult}"/> based <see cref="ILoggingRule"/>
    /// </summary>
    public class Rule : ILoggingRule
    {
        private readonly Func<int, LogLevel?, bool> _matchFunc;

        public Rule(Func<int, LogLevel?, bool> matchFunc, bool enabled)
        {
            _matchFunc = matchFunc;
            Enabled = enabled;
        }
        public bool IsMatch(int category, LogLevel? level)
        {
            return _matchFunc(category, level);
        }

        public bool Enabled { get; }

        /// <summary>
        /// Factory for a simple, single category rule.
        /// </summary>
        /// <param name="category"></param>
        /// <param name="enabled"></param>
        /// <returns></returns>
        public static Rule For(int category,bool enabled=true) => new Rule((c,l) => c == category,enabled);
    }
}