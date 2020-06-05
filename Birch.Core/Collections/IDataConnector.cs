using System;
using Birch.Shadows;

namespace Birch.Collections
{
    /// <summary>
    /// Typically conduit between the actual data and the UI.
    /// </summary>
    /// <typeparam name="TItem"></typeparam>
    public interface IDataConnector<in TItem>
    {
        void Insert(int index, TItem item);
        void Move(int oldIndex, int newIndex);
        void Remove(int index,TItem item);
        void Update(int index, TItem current, TItem next);
    }
}