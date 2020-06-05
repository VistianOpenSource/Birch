using System;
using System.Collections.Generic;
using System.Diagnostics;
using Birch.Collections.Comparers;
using Birch.Collections.Comparers.Heckel;

namespace Birch.Collections
{
    public delegate IReadOnlyList<Operation<T>> Comparer<T>(T[] old, T[] @new, IEqualityComparer<T> comparer) where T : IEquatable<T>;

    /// <summary>
    /// An implementation of <see cref="ICollectionComparer{T}"/> using the heckel diff algorithm.
    /// </summary>
    /// <remarks>
    /// This comparer does a full comparison between two lists and can quite easily generate a
    /// minimal set of updates to transition one list to another. 
    /// </remarks>
    public class HeckelComparer<T> : StandardCollectionComparer<T> where T : IEquatable<T>
    {
        public static HeckelComparer<T> Default = new HeckelComparer<T>();

        public HeckelComparer() : base(Implementation.OrderedDiff)
        {
        }
    }
}