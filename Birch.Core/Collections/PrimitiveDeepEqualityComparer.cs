using System.Collections.Generic;
using Birch.Components;

namespace Birch.Collections
{
    /// <summary>
    /// A <see cref="IEqualityComparer{IPrimtive}"/> comparer, but comparing the objects deeply.
    /// </summary>
    public class PrimitiveDeepEqualityComparer:PrimitiveEqualityComparer
    {
        public static PrimitiveDeepEqualityComparer Default = new PrimitiveDeepEqualityComparer();

        public PrimitiveDeepEqualityComparer() : base(ComparisonMode.Deep)
        {
        }
    }
}