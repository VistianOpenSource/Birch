using System;
using Birch.Collections.Comparers.Simple;

namespace Birch.Collections
{
    /// <summary>
    /// An implementation of <see cref="ICollectionComparer{T}"/> using a very simple algorithm.
    /// </summary>
    /// <remarks>
    /// This comparer probably works fine whereby a list doesn't see many updates, or those updates are either
    /// changes to existing items in the list or items being appended to the list.
    /// </remarks>
    public class SimpleComparer<T> : StandardCollectionComparer<T> where T : IEquatable<T>
    {
        public static SimpleComparer<T> Default = new SimpleComparer<T>();

        public SimpleComparer() : base(Implementation.Diff)
        {
        }
    }
}