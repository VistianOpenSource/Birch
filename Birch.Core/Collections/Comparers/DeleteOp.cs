using System.Collections.Generic;

namespace Birch.Collections.Comparers
{
    /// <summary>
    /// A delete operation
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class DeleteOp<T> : Operation<T>
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

        public DeleteOp(int index, T item)
        {
            Index = index;
            Item = item;
        }
    }
}