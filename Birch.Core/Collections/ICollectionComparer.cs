using System;
using System.Collections.Generic;
using Birch.Collections.Comparers;
using Birch.Components;

namespace Birch.Collections
{
    public interface ICollectionComparer<T>
    {
        IReadOnlyList<Operation<T>> Compare(T[] originalList, T[] newList);
    }

}