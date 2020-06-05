using System.Collections.Generic;
using System.Linq;

namespace Birch.Collections
{
    /// <summary>
    /// Simplistic dictionary comparer.
    /// </summary>
    /// <typeparam name="TKey"></typeparam>
    /// <typeparam name="TValue"></typeparam>
    public class DictionaryComparer<TKey, TValue> : IEqualityComparer<Dictionary<TKey, TValue>>
    {
        public static DictionaryComparer<TKey,TValue> Default = new DictionaryComparer<TKey, TValue>();

        public bool Equals(Dictionary<TKey, TValue> x, Dictionary<TKey, TValue> y)
        {
            if (x == null && y == null) return true;

            if (x == null || y == null) return false;

            if (ReferenceEquals(x, y)) return true;

            // now just need to compare and see
            // 1. if length the same 
            // if content matches when have same key...
            if (x.Count != y.Count) return false;

            var equalityComparer = EqualityComparer<TValue>.Default;

            return x.All(left => y.ContainsKey(left.Key) && equalityComparer.Equals(left.Value, y[left.Key]));
        }

        public int GetHashCode(Dictionary<TKey, TValue> obj)
        {
            return (int) obj?.GetHashCode();
        }
    }
}