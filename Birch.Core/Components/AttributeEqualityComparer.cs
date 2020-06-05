using System.Collections.Generic;

namespace Birch.Components
{
    /// <summary>
    /// Base class for perform equality tests between Attributes
    /// </summary>
    /// <remarks>
    /// Optionally can be told to ignore those attributes which contain descendents </remarks>
    public abstract class AttributeEqualityComparer : IEqualityComparer<KeyValuePair<int, object>>
    {
        private readonly bool _ignoreDescendents;

        protected AttributeEqualityComparer(bool ignoreDescendents)
        {
            _ignoreDescendents = ignoreDescendents;
        }

        public bool Equals(KeyValuePair<int, object> x, KeyValuePair<int, object> y)
        {
            if (x.Key != y.Key) return false;

            if (x.Value == y.Value) return true;

            if (x.Value?.GetType() != y.Value?.GetType()) return false;

            var attribute = AttributeStore.Default.GetAttributeForId(x.Key);

            if (_ignoreDescendents)
            {
                return (!attribute.ContainsDescendents) && attribute.CompareValues(x.Value, y.Value);
            }
            else
            {
                return attribute.CompareValues(x.Value, y.Value);
            }
        }

        public int GetHashCode(KeyValuePair<int, object> obj)
        {
            return (obj.Key.GetHashCode()* 397) ^ obj.GetHashCode();
        }
    }
}