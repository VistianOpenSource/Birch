using System.Collections.Generic;

namespace Birch.Components
{
    /// <summary>
    /// Shallow attribute <see cref="IEqualityComparer{T}"/> comparer.
    /// </summary>
    public sealed class AttributeShallowEqualityComparer : AttributeEqualityComparer
    {
        public static AttributeShallowEqualityComparer Default = new AttributeShallowEqualityComparer();

        public AttributeShallowEqualityComparer() : base(true)
        {
        }
    }
}