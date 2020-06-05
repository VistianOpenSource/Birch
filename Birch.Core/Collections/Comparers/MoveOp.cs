using System.Collections.Generic;

namespace Birch.Collections.Comparers
{
    /// <summary>
    /// A move operation
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class MoveOp<T> : Operation<T>
    {
        public override IEnumerable<int> GetIndices()
        {
            yield return From;
            yield return To;
        }

        public override IEnumerable<T> GetItems()
        {
            yield return Item;
        }

        public T Item { get; }
        public int From { get; }
        public int To { get; }
        public MoveOp(int from, int to, T item)
        {
            From = @from;
            To = to;
            Item = item;
        }
    }
}