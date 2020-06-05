using System.Collections.Generic;

namespace Birch.Collections.Comparers
{
    /// <summary>
    /// An update operation
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class UpdateOp<T> : Operation<T>
    {
        public override IEnumerable<int> GetIndices()
        {
            yield return Index;
        }

        public override IEnumerable<T> GetItems()
        {
            yield return FromItem;
            yield return ToItem;
        }

        public T FromItem { get; }

        public T ToItem { get; }

        public int Index { get; }

        public UpdateOp(int index, T fromItem, T toItem)
        {
            Index = index;
            FromItem = fromItem;
            ToItem = toItem;
        }
    }
}