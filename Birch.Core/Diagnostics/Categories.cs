using System;
using System.Collections.Generic;
using System.Text;

namespace Birch.Diagnostics
{
    /// <summary>
    /// The categories of logging supported.
    /// </summary>
    public static class Categories
    {
        private enum CategoriesInternal
        {
            Reflection,
            Host,
            Transaction,
            Primitives,
            Collections
        };

        /// <summary>
        /// Logging from components associated with the reflection elements used to specify, set and call methods.
        /// </summary>
        public static readonly int Reflection = (int)CategoriesInternal.Reflection;

        /// <summary>
        /// Logging from build hosts.
        /// </summary>
        public static readonly int Host = (int)CategoriesInternal.Host;

        /// <summary>
        /// Logging from transactions
        /// </summary>
        public static readonly int Transactions = (int)CategoriesInternal.Transaction;

        /// <summary>
        /// Logging from primitive elements
        /// </summary>
        public static readonly int Primitives = (int)CategoriesInternal.Primitives;

        /// <summary>
        /// Logging from components related to collections including supporting classes for channeling of collection changes.
        /// </summary>
        public static readonly int Collections = (int)CategoriesInternal.Collections;

        /// <summary>
        /// The last used category identifier.
        /// </summary>
        public static readonly int Last = Collections;
    }
}
