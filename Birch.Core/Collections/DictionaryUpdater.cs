using System;
using System.Collections.Generic;
using System.IO.MemoryMappedFiles;
using System.Linq;

namespace Birch.Collections
{
    /// <summary>
    /// Compares two dictionaries (with a common key and value type) for differences and emits sequences of operations for the differences that exist.
    /// </summary>
    /// <typeparam name="TKey"></typeparam>
    /// <typeparam name="TValue"></typeparam>
    public class DictionaryUpdater<TKey, TValue>
    {
        /// <summary>
        /// Static implementation of the dictionary updater.
        /// </summary>
        public static DictionaryUpdater<TKey,TValue> Default = new DictionaryUpdater<TKey, TValue>();

        public IEnumerable<Operation> Compare(IReadOnlyDictionary<TKey, TValue> left, IReadOnlyDictionary<TKey, TValue> right,IEqualityComparer<TValue> equalityComparer=default)
        {
            equalityComparer ??= EqualityComparer<TValue>.Default;

            // Do updates first
            var updatedItems = left.Where(l => right.ContainsKey(l.Key) && !equalityComparer.Equals(l.Value, right[l.Key]));

            foreach (var (key, value) in updatedItems)
            {
                yield return new Update(key,value,right[key]);
            }

            // now the removals
            var removedItems = left.Where(l => !right.ContainsKey(l.Key));

            foreach (var (key, value) in removedItems)
            {
                yield return new Remove(key,value);
            }

            // and finally the additions
            var addedItems = right.Where(r => !left.ContainsKey(r.Key));

            foreach (var (key, value) in addedItems)
            {
                yield return new Add(key,value);
            }
        }

        public abstract class Operation
        {
            public TKey Key { get; }

            protected Operation(TKey key)
            {
                Key = key;
            }
        }

        public class Add:Operation
        {
            public TValue Value { get; }

            public Add(TKey key, TValue value):base(key)
            {
                Value = value;
            }
        }

        public class Update:Operation
        {
            public TValue From { get; }
            public TValue To { get; }

            public Update(TKey key, TValue @from, TValue to):base(key)
            {
                From = @from;
                To = to;
            }
        }

        public class Remove:Operation
        {
            public TValue Value { get; }

            public Remove(TKey key, TValue value):base(key)
            {
                Value = value;
            }
        }
    }

}