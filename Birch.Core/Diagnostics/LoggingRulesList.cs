using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Logging;

namespace Birch.Diagnostics
{
    /// <summary>
    /// Container for Logging Rules.
    /// </summary>
    /// <remarks>
    /// Can be initialized using the collection initializer approach.</remarks>
    public class LoggingRulesList:IEnumerable<ILoggingRule>
    {
        private readonly bool _defaultEnabled;

        private readonly List<ILoggingRule> _rules = new List<ILoggingRule>();

        /// <summary>
        /// Create an instance
        /// </summary>
        /// <param name="defaultEnabled">The default logging enabled state when no rule matches.</param>
        public LoggingRulesList(bool defaultEnabled=false)
        {
            _defaultEnabled = defaultEnabled;
        }

        /// <summary>
        /// Create an instance from a list of <see cref="ILoggingRule"/>
        /// </summary>
        /// <param name="defaultEnabled"></param>
        /// <param name="rules"></param>
        public LoggingRulesList(bool defaultEnabled, List<ILoggingRule> rules)
        {
            _defaultEnabled = defaultEnabled;
            _rules = rules;
        }

        /// <summary>
        /// Create a <see cref="LoggingRulesList"/> from an enumeration
        /// </summary>
        /// <param name="defaultEnabled"></param>
        /// <param name="loggingRules"></param>
        /// <returns></returns>
        public static LoggingRulesList Create(bool defaultEnabled, IEnumerable<ILoggingRule> loggingRules)
        {
            var rules = loggingRules.ToList();

            return new LoggingRulesList(defaultEnabled,rules);
        }

        /// <summary>
        /// Determine whether logging is enabled or not.
        /// </summary>
        /// <param name="category"></param>
        /// <param name="level"></param>
        /// <returns></returns>
        public bool IsLoggingEnabled(int category, LogLevel? level)
        {
            var rule = _rules.FirstOrDefault(r => r.IsMatch(category, level));

            return rule?.Enabled ?? _defaultEnabled;
        }

        /// <summary>
        /// Enumerable all of the <see cref="ILoggingRule"/> instances.
        /// </summary>
        /// <returns></returns>
        public IEnumerator<ILoggingRule> GetEnumerator()
        {
            return _rules.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        /// <summary>
        /// Add a logging rule.
        /// </summary>
        /// <param name="rule"></param>
        public LoggingRulesList Add(ILoggingRule rule)
        {
            _rules.Add(rule);
            return this;
        }
    }
}