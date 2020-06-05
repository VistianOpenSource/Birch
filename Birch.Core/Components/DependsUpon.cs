using System;
using Birch.Collections;
using Birch.Components;
using Birch.Compose;

namespace Birch.Components
{
    /// <summary>
    /// Provide caching capabilities of rendered layout to potentially improve performance.
    /// </summary>
    /// <typeparam name="TDependency"></typeparam>
    /// <remarks>
    /// Typically a tuple is used for the actual TDependency value.</remarks>
    public class DependsUpon<TDependency>:IComposite
    {
        /// <summary>
        /// The dependency key
        /// </summary>
        private readonly TDependency _dependency;

        /// <summary>
        /// Get the <see cref="IElement"/>
        /// </summary>
        private readonly Func<TDependency,IElement> _item;

        private static LruCache<(Type,TDependency),WeakReference<IPrimitive>> _cache;

        public DependsUpon(TDependency dependency, Func<TDependency,IElement> item,int capacity=50)
        {
            if (_cache == null)
            {
                _cache = new LruCache<(Type, TDependency), WeakReference<IPrimitive>>(capacity);
            }
            _dependency = dependency;
            _item = item;
        }

        /// <summary>
        /// Upon disposal, we look to dispose of any items that are no longer required and their associated weak references
        /// are no longer used.
        /// </summary>
        ~DependsUpon()
        {
            FlushExpired();
        }

        /// <summary>
        /// Remove old expired items from the cache
        /// </summary>
        /// <remarks>
        /// </remarks>
        private void FlushExpired()
        {
            // We don't attempt to flush items from the cache when it isn't full, otherwise this could result in a lot
            // of wasted effort.
            if (_cache.IsFull)
            {
                var keys = _cache.Keys;

                foreach (var key in keys)
                {
                    // if we can get the value from the cache but the target of the weak reference is no longer there
                    // then remove from the cache.
                    if (_cache.TryGetValue(key, out var weakReference) && !weakReference.TryGetTarget(out var primitive))
                    {
                        _cache.Remove(key);
                    }
                }
            }
        }

        /// <summary>
        /// Perform the layout.
        /// </summary>
        /// <param name="layoutContext"></param>
        /// <returns></returns>
        /// <remarks>
        /// The type of the factory function (used to build the actual layout) and the dependency value are combined to form a key into the LRU cache.
        /// If the item isn't present then the factory function is used and the resultant value cached.
        /// </remarks>
        [Preserve(AllMembers = true)]
        public IPrimitive PerformLayout(LayoutContext layoutContext)
        {
            if (!_cache.TryGetValue((_item.GetType(),_dependency),out var item) || !item.TryGetTarget(out var primitiveComponent))
            {
                var vc = _item(_dependency);

                primitiveComponent = vc.Layout(layoutContext);

                var componentReference = new WeakReference<IPrimitive>(primitiveComponent);

                _cache.Add((_item.GetType(),_dependency),componentReference);
            }

            return primitiveComponent;
        }
    }
}