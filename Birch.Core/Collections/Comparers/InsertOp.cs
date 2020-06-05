using System.Collections.Generic;

namespace Birch.Collections.Comparers
{
    /// <summary>
    /// An insert operation
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class InsertOp<T> : Operation<T>
    {
        public override IEnumerable<int> GetIndices()
        {
            yield return Index;
        }

        public override IEnumerable<T> GetItems()
        {
            yield return Item;
        }

        public int Index { get; }

        public T Item { get; }

        public InsertOp(int index, T item)
        {
            Index = index;
            Item = item;
        }
    }
}