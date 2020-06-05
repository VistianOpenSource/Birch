using System;
using System.Collections.Generic;
using Birch.Transactions;
using Microsoft.Extensions.Logging;

namespace Birch.Diagnostics
{
    /// <summary>
    /// Static class through which logging is channeled
    /// </summary>
    public static class Logging
    {
        private static ILogger _logger;

        /// <summary>
        /// Get the <see cref="Microsoft.Extensions.Logging.ILogger"/> implementation
        /// </summary>
        public static ILogger Instance => _logger ?? NullLogging.Instance;

        /// <summary>
        /// Specify the <see cref="Microsoft.Extensions.Logging.ILogger"/> implementation to use.
        /// </summary>
        /// <param name="logger"></param>
        /// <remarks>
        /// Typically called from the main application code to dictate how logging should be performed.</remarks>
        public static void Set(ILogger logger)
        {
            _logger = logger??NullLogging.Instance;
        }
    }
}