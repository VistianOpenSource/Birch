using System;
using System.Collections.Generic;
using System.Text;

namespace Birch.Collections
{
    public static class IList
    {
        public static void SmartInsert<T>(this IList<T> list, int index, T item)
        {
            if (index == list.Count)
            {
                list.Add(item);
            }
            else
            {
                list.Insert(index,item);
            }
        }
    }
}
