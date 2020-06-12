using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Dynamic;
using System.Text;

namespace Birch.Reflection
{
    /// <summary>
    /// Static class holding any globally defined custom equality comparer.
    /// </summary>
    public static class CustomEqualityComparer
    {
        private static readonly ConcurrentDictionary<Type,object> CustomComparers = new ConcurrentDictionary<Type, object>();

        /// <summary>
        /// Register a pre-defined equality comparer
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="comparer"></param>
        public static void Register<T>([NotNull]IEqualityComparer<T> comparer)
        {
            CustomComparers[typeof(T)] = comparer;
        }

        /// <summary>
        /// Try and get a comparer for a specified type.
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static (bool exists,object comparer) TryGetValue(Type type)
        {
            return CustomComparers.TryGetValue(type, out var comparer) ? (true, comparer) : (false, null);
        }

        /// <summary>
        /// Either get a custom registered <see cref="IEqualityComparer{T}"/> or the default implementation.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static IEqualityComparer<T> GetOrDefault<T>()
        {
            if (CustomComparers.TryGetValue(typeof(T), out var comparer))
            {
                return (IEqualityComparer<T>) comparer;
            }
            else
            {
                return EqualityComparer<T>.Default;
            }
        }
    }
}