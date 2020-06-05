using System.Collections.Generic;
using Birch.Components;

namespace Birch.Collections
{
    /// <summary>
    /// A <see cref="IEqualityComparer{T}"/> comparer, comparing the objects at only their root level.
    /// </summary>
    public class PrimitiveShallowEqualityComparer:PrimitiveEqualityComparer
    {
        public static PrimitiveShallowEqualityComparer Default = new PrimitiveShallowEqualityComparer();

        public PrimitiveShallowEqualityComparer() : base(ComparisonMode.Shallow)
        {
        }
    }
}