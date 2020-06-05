using System.Dynamic;
using Birch.Components;

namespace Birch.Collections
{
    public partial class CollectionChangeCompactor
    {
        /// <summary>
        /// Represents a single entry in a <see cref="CollectionChangeCompactor"/>
        /// </summary>
        public sealed class Entry
        {
            /// <summary>
            /// Get the current <see cref="IPrimitive"/>, if relevant
            /// </summary>
            public IPrimitive Current { get; private set; }

            /// <summary>
            /// Get the next <see cref="IPrimitive"/>, if relevant
            /// </summary>
            public IPrimitive Next { get; private set; }

            /// <summary>
            /// The state of change applied to this entry
            /// </summary>
            public TransactionState State { get; private set; }

            /// <summary>
            /// The original index this entry occupied.
            /// </summary>
            public int OriginalIndex { get; private set; }

            private Entry(TransactionState state)
            {
                State = state;
            }

            public static Entry Create(int index, IPrimitive current)
            {
                return new Entry(TransactionState.NoChange) {OriginalIndex = index, Current = current};
            }

            public static Entry Insert(IPrimitive next)
            {
                return new Entry(TransactionState.Inserted) {Next = next};
            }

            public void Delete()
            {
                State = TransactionState.Deleted;
            }

            public void Update(IPrimitive next)
            {
                State = TransactionState.Updated;
                Next = next;
            }
        }
    }


    public partial class CollectionChangeCompactor<T>
    {
        /// <summary>
        /// Represents a single entry in a <see cref="CollectionChangeCompactor"/>
        /// </summary>
        public sealed class Entry
        {
            /// <summary>
            /// Get the current <see cref="T"/>, if relevant
            /// </summary>
            public T Current { get; private set; }

            /// <summary>
            /// Get the next <see cref="IPrimitive"/>, if relevant
            /// </summary>
            public T Next { get; private set; }

            /// <summary>
            /// The state of change applied to this entry
            /// </summary>
            public TransactionState State { get; private set; }

            /// <summary>
            /// The original index this entry occupied.
            /// </summary>
            public int OriginalIndex { get; private set; }

            private Entry(TransactionState state)
            {
                State = state;
            }

            public static Entry Create(int index, T current)
            {
                return new Entry(TransactionState.NoChange) {OriginalIndex = index, Current = current};
            }

            public static Entry Insert(T next)
            {
                return new Entry(TransactionState.Inserted) {Next = next};
            }

            public void Delete()
            {
                State = TransactionState.Deleted;
            }

            public void Update(T next)
            {
                State = TransactionState.Updated;
                Next = next;
            }
        }
    }

}