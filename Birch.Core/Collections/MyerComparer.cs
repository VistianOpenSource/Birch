using System;

namespace Birch.Collections
{
    /// <summary>
    /// An implementation of <see cref="ICollectionComparer{T}"/> using the Eugene Myer diff algorithm.
    /// </summary>
    /// <remarks>
    /// This comparer does a full comparison between two lists and can quite easily generate a
    /// minimal set of updates to transition one list to another. 
    /// </remarks>
    public class MyerComparer<T> : StandardCollectionComparer<T> where T : IEquatable<T>
    {
        public static MyerComparer<T> Default = new MyerComparer<T>();

        public MyerComparer() : base(Comparers.Myers.Implementation.Diff)
        {
        }
    }
}