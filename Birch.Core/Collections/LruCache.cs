using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Birch.Collections
{
/// <summary>
    /// A thread safe, least-recently-used cache stored like a dictionary.
    /// </summary>
    /// <typeparam name="TKey"> The type of the key to the cached item
    /// </typeparam>
    /// <typeparam name="TValue">
    /// The type of the cached item.
    /// </typeparam>
    /// <remarks>
    /// Derived from https://stackoverflow.com/a/3719378/240845
    /// </remarks>
public class LruCache<TKey, TValue>
    {
        /// <summary>
        /// The dictionary to lookup an individual record
        /// </summary>
        private readonly Dictionary<TKey, LinkedListNode<LruCacheItem>> _cacheMap = new Dictionary<TKey, LinkedListNode<LruCacheItem>>();

        /// <summary>
        /// The linked list of items in the LRU
        /// </summary>
        private readonly LinkedList<LruCacheItem> _lruList = new LinkedList<LruCacheItem>();

        /// <summary>
        /// The lock to ensure proper controlled access to the cache
        /// </summary>
        private readonly ReaderWriterLockSlim _lock = new ReaderWriterLockSlim();

        /// <summary>
        /// An optional action to be performed when an item is 'removed' from the cache.
        /// </summary>
        private readonly Action<TValue> _dispose;

        /// <summary>
        /// Initializes a new instance of the <see cref="LruCache{TKey, TValue}"/>
        /// class.
        /// </summary>
        /// <param name="capacity">
        /// Maximum number of elements to cache.
        /// </param>
        /// <param name="dispose">
        /// When elements cycle out of the cache, disposes them. May be null.
        /// </param>
        public LruCache(int capacity, Action<TValue> dispose = null)
        {
            this.Capacity = capacity;
            this._dispose = dispose;
        }

        /// <summary>
        /// Gets the capacity of the cache.
        /// </summary>
        public int Capacity { get; }

        /// <summary>Gets the value associated with the specified key.</summary>
        /// <param name="key">
        /// The key of the value to get.
        /// </param>
        /// <param name="value">
        /// When this method returns, contains the value associated with the specified
        /// key, if the key is found; otherwise, the default value for the type of the 
        /// <paramref name="value" /> parameter. This parameter is passed
        /// uninitialized.
        /// </param>
        /// <returns>
        /// true if the <see cref="T:System.Collections.Generic.Dictionary`2" /> 
        /// contains an element with the specified key; otherwise, false.
        /// </returns>
        public bool TryGetValue(TKey key, out TValue value)
        {
            _lock.EnterUpgradeableReadLock();

            try
            {
                if (_cacheMap.TryGetValue(key, out var node))
                {
                    value = node.Value.Value;

                    _lock.EnterWriteLock();

                    try
                    {
                        _lruList.Remove(node);
                        _lruList.AddLast(node);
                        return true;

                    }
                    finally
                    {
                        _lock.ExitWriteLock();
                    }
                }

                value = default;
                return false;
            }
            finally
            {
                _lock.ExitUpgradeableReadLock();
            }
        }

        /// <summary>
        /// Get whether the LRU is full.
        /// </summary>
        public bool IsFull => Capacity == _cacheMap.Count;

        /// <summary>
        /// Get a read only collection of the keys in the cache
        /// </summary>
        public IReadOnlyCollection<TKey> Keys
        {
            get
            {
                _lock.EnterReadLock();

                try
                {
                    return _cacheMap.Keys.Select(k => k).ToList().AsReadOnly();
                }
                finally
                {
                    _lock.ExitReadLock();
                }
            }
        }

        /// <summary>
        /// Looks for a value for the matching <paramref name="key"/>. If not found, 
        /// calls <paramref name="valueGenerator"/> to retrieve the value and add it to
        /// the cache.
        /// </summary>
        /// <param name="key">
        /// The key of the value to look up.
        /// </param>
        /// <param name="valueGenerator">
        /// Generates a value if one isn't found.
        /// </param>
        /// <returns>
        /// The requested value.
        /// </returns>
        public TValue Get(TKey key, Func<TValue> valueGenerator)
        {
            _lock.EnterUpgradeableReadLock();

            try
            {
                TValue value;
                if (this._cacheMap.TryGetValue(key, out var node))
                {
                    value = node.Value.Value;

                    _lock.EnterWriteLock();

                    try
                    {
                        this._lruList.Remove(node);
                        this._lruList.AddLast(node);

                    }
                    finally
                    {
                        _lock.ExitWriteLock();
                    }
                }
                else
                {
                    value = valueGenerator();

                    var cacheItem = new LruCacheItem(key, value);
                    node = new LinkedListNode<LruCacheItem>(cacheItem);

                    _lock.EnterWriteLock();

                    try
                    {
                        if (this._cacheMap.Count >= this.Capacity)
                        {
                            this.RemoveFirst();
                        }

                        this._lruList.AddLast(node);
                        this._cacheMap[key] = node;

                    }
                    finally
                    {
                        _lock.ExitWriteLock();
                    }
                }

                return value;
            }
            finally
            {
                _lock.ExitUpgradeableReadLock();
            }
        }


        /// <summary>
        /// Adds the specified key and value to the dictionary.
        /// </summary>
        /// <param name="key">
        /// The key of the element to add.
        /// </param>
        /// <param name="value">
        /// The value of the element to add. The value can be null for reference types.
        /// </param>
        public void Add(TKey key, TValue value)
        {
            var cacheItem = new LruCacheItem(key, value);
            var node =new LinkedListNode<LruCacheItem>(cacheItem);

            _lock.EnterWriteLock();

            try
            {
                if (this._cacheMap.Count >= this.Capacity)
                {
                    this.RemoveFirst();
                }

                this._lruList.AddLast(node);
                this._cacheMap[key] = node;
            }
            finally
            {
                _lock.ExitWriteLock();
            }
        }

        /// <summary>
        /// Remove the first item from the LRU
        /// </summary>
        private void RemoveFirst()
        {
            // Remove from LRUPriority
            var node = this._lruList.First;
            this._lruList.RemoveFirst();

            // Remove from cache
            this._cacheMap.Remove(node.Value.Key);

            // dispose
            this._dispose?.Invoke(node.Value.Value);
        }

        /// <summary>
        /// Remove the entry from the cache associated with a specified key.
        /// </summary>
        /// <param name="key"></param>
        public void Remove(TKey key)
        {
            _lock.EnterUpgradeableReadLock();

            try
            {
                if (_cacheMap.TryGetValue(key, out var node))
                {
                    _lock.EnterWriteLock();

                    try
                    {
                        _lruList.Remove(node);
                        _cacheMap.Remove(key);
                    }
                    finally
                    {
                        _lock.ExitWriteLock();
                    }
                }
            }
            finally
            {
                _lock.ExitUpgradeableReadLock();
            }
        }

        /// <summary>
        /// Internal class for an individual item in the cache
        /// </summary>
        private class LruCacheItem
        {
            public TKey Key { get; }

            public TValue Value { get; }

            public LruCacheItem(TKey k, TValue v)
            {
                Key = k;
                Value = v;
            }
        }
    }
}