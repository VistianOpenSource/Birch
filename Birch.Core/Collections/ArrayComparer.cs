using System;
using System.Collections.Generic;
using System.Linq;

namespace Birch.Collections
{
    /// <summary>
    /// An <see cref="IEqualityComparer{T}"/> implementation for Arrays which performs a deep comparison
    /// comparing each item in the array.
    /// </summary>
    /// <typeparam name="TItem"></typeparam>
    public class ArrayComparer<TItem> : IEqualityComparer<TItem[]>
    {
        public static ArrayComparer<TItem> Default = new ArrayComparer<TItem>();

        private static IEqualityComparer<TItem> _equalityComparer;

        public ArrayComparer(IEqualityComparer<TItem> equalityComparer = default)
        {
            _equalityComparer = equalityComparer ?? EqualityComparer<TItem>.Default;
        }
        public bool Equals(TItem[] x, TItem[] y)
        {
            if (x == null && y == null)
            {
                return true;
            }

            if (x == null || y == null)
            {
                return false;
            }

            if (ReferenceEquals(x, y)) return true;

            return x.Length == y.Length && x.SequenceEqual(y,_equalityComparer);
        }

        /// <summary>
        /// Generate a hash code 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int GetHashCode(TItem[] obj)
        {
            unchecked
            {
                var hashCode = 0;

                foreach (var item in obj)
                {
                    hashCode *= 397;

                    if (item != null)
                    {
                        hashCode ^= item.GetHashCode();
                    }
                }
                return hashCode;
            }
        }
    }
}