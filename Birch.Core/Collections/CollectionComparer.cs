using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Birch.Collections
{
    /// <summary>
    /// Default implementation of collection comparer.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public static class CollectionComparer<T> 
    {
        public static ICollectionComparer<T> Default(IEqualityComparer<T> equalityComparer=default) => new MyerComparer<T>(equalityComparer);
    }
}
