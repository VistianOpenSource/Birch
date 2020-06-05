using System;
using Birch.Diagnostics;

namespace Birch.Components
{
    /// <summary>
    /// Base class for actual implementation of backing store update handlers.
    /// </summary>
    /// <remarks>
    /// Exists primarily for storage of single logging flag and internal classes for calculating changes.</remarks>
    public abstract class BackingStoreUpdateHandler
    {
        /// <summary>
        /// Whether this as a logging source is enabled or not.
        /// </summary>
        protected static readonly Lazy<bool> IsLoggingEnabled = new Lazy<bool>(() => LoggingRules.For(Categories.Collections).Any);


        /// <summary>
        /// unique id for logging
        /// </summary>
        protected static long LoggingId;
    }
}