using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics;
using System.Linq;
using Birch.Collections.Comparers;
using Birch.Collections.Comparers.Heckel;
using Birch.Components;
using Birch.Diagnostics;
using Birch.Metrics;
using Birch.Shadows;
using Microsoft.Extensions.Logging;

namespace Birch.Collections
{
    /// <summary>
    /// <see cref="ICollectionComparer{T}"/> implementation utilizing a provided function to perform array comparisons.
    /// </summary>
    public abstract class StandardCollectionComparer<TItem>:ICollectionComparer<TItem> 
    {
        private readonly Comparer<TItem> _comparer;
        private readonly IEqualityComparer<TItem> _equalityComparer;

        private static readonly IEqualityComparer<TItem> DefaultEqualityComparer = EqualityComparer<TItem>.Default;

        // TODO: move to another base non generic class to avoid multiple instances?
        private static readonly bool IsLoggingEnabled = LoggingRules.For(Categories.Collections).Any;

        protected StandardCollectionComparer(Comparer<TItem> comparer,IEqualityComparer<TItem> equalityComparer=default)
        {
            _comparer = comparer;
            _equalityComparer = equalityComparer??DefaultEqualityComparer;
        }
        /// <summary>
        /// Compare two arrays of <see cref="IPrimitive"/> performing the appropriate operations depending upon
        /// the changes that are seen between the two arrays.
        /// </summary>
        /// <param name="originalList"></param>
        /// <param name="newList"></param>
        /// <param name="insert"></param>
        /// <param name="delete"></param>
        /// <param name="move"></param>
        /// <param name="update"></param>
        public void Compare(TItem[] originalList, TItem[] newList, Action<int, TItem> insert, Action<int, TItem> delete, Action<int, int,TItem> move, Action<int, TItem, TItem> update)
        {
            if (newList == null && originalList == null)
            {
                return;
            }

            if (ReferenceEquals(newList, originalList))
            {
                return;
            }

            // if they are identical
            if (newList?.Length == originalList?.Length && newList?.Length > 0 && newList.SequenceEqual(originalList,_equalityComparer))
            {
                return;
            }

            // and the actual implementation
            CompareImpl(originalList, newList, insert, delete, move, update);                
        }

        private static readonly List<Operation<TItem>> Empty = new List<Operation<TItem>>();

        public IReadOnlyList<Operation<TItem>> Compare(TItem[] originalList, TItem[] newList)
        {
            if (newList == null && originalList == null)
            {
                return Empty;
            }

            if (ReferenceEquals(newList, originalList))
            {
                return Empty;
            }

            // if they are identical
            if (newList?.Length == originalList?.Length && newList?.Length > 0 && newList.SequenceEqual(originalList,_equalityComparer))
            {
                return Empty;
            }

            // we have new values, but no prior ones
            if ((newList?.Length >= 0) && (originalList == null || originalList.Length == 0))
            {
                var insertions= new List<Operation<TItem>>(newList.Length);

                for (var i = newList.Length - 1; i >= 0; i--)
                {
                    insertions.Add(new InsertOp<TItem>(0,newList[i]));
                }

                return insertions;
            }

            // we don't have new values, but we have prior ones
            if ((newList?.Length == 0) && (originalList?.Length > 0))
            {
                var originalLength = originalList.Length;

                var deletions = Enumerable.Range(0,originalList.Length)
                    .Select(i => new DeleteOp<TItem>(originalLength-i-1, originalList[originalLength-i-1])).ToList();

                return deletions;
            }

            IReadOnlyList<Operation<TItem>> differences;

            // the duration of the compare , only used when logging
            long compareDuration = 0;

            if (IsLoggingEnabled)
            {
                using var _ = Benchmark.Create((d, _) =>
                {
                    compareDuration = d;
                });
                differences = _comparer(originalList, newList, _equalityComparer);
            }
            else
            {
                differences = _comparer(originalList, newList, _equalityComparer);
            }

            return differences;
        }

        private void CompareImpl(TItem[] originalList, TItem[] newList, Action<int, TItem> insert,
            Action<int, TItem> delete, Action<int, int,TItem> move, Action<int, TItem, TItem> update)
        {
            // we have new values, but no prior ones
            if ((newList?.Length >= 0) && (originalList == null || originalList.Length == 0))
            {
                for (var i = newList.Length - 1; i >= 0; i--)
                {
                    insert(0, newList[i]);
                }

                return;
            }

            // we don't have new values, but we have prior ones
            if ((newList?.Length == 0) && (originalList?.Length > 0))
            {
                foreach (var i in Enumerable.Range(originalList.Length - 1, 0))
                {
                    delete(i, originalList[i]);
                }
            }

            IReadOnlyList<Operation<TItem>> differences;

            // the duration of the compare , only used when logging
            long compareDuration = 0;

            if (IsLoggingEnabled)
            {
                using var _ = Benchmark.Create((d, _) =>
                {
                    compareDuration = d;
                });
                differences = _comparer(originalList, newList, _equalityComparer);
            }
            else
            {
                differences = _comparer(originalList, newList, _equalityComparer);
            }

            // counters used when we are ONLY logging
            var inserts = new int[0];
            var deletes = new int[0];
            var moves =  new int[0];
            var updates = new int[0];

            foreach (var diff in differences)
            {
                switch (diff)
                {
                    case InsertOp<TItem> op:

                        // this is an insert operation, need to create the views at the specified place...
                        insert(op.Index, op.Item);

                        if (IsLoggingEnabled)
                        {
                            Array.Resize(ref inserts, inserts.Length + 1);
                            inserts[^1] = op.Index;
                        }

                        break;
                    case DeleteOp<TItem> op:

                        delete(op.Index, op.Item);

                        if (IsLoggingEnabled)
                        {
                            Array.Resize(ref deletes, deletes.Length + 1);
                            deletes[^1] = op.Index;
                        }

                        //this is a delete operation, need to delete the views at the specified place...
                        break;

                    case MoveOp<TItem> op:

                        move(op.From, op.To,op.Item);

                        if (IsLoggingEnabled)
                        {
                            Array.Resize(ref moves, moves.Length + 1);
                            moves[^1] = op.From;
                        }

                        break;

                    case UpdateOp<TItem> op:
                        update(op.Index, op.FromItem, op.ToItem);

                        if (IsLoggingEnabled)
                        {
                            Array.Resize(ref updates, updates.Length + 1);
                            updates[^1] = op.Index;
                        }

                        break;
                }
            }

            if (IsLoggingEnabled)
            {
                Logging.Instance.LogInformation(
                    "Collection Compare type:{type} from:{oldLength} to:{newLength} changes:{changeCount} duration:{duration}ms inserts:[{inserts}] updates:[{updates}] moves:[{moves}] deletes:[{deletes}]",
                    this.GetType().Name, originalList.Length, newList.Length, differences.Count, compareDuration,inserts,updates, moves,deletes);
            }
        }
    }

}