using System;
using System.Collections.Generic;
using Birch.Collections.Comparers;
using Birch.Components;
using Birch.Diagnostics;
using Birch.Metrics;
using Microsoft.Extensions.Logging;

namespace Birch.Collections
{
    public static class ICollectionComparerExtensions
    {
        /// <summary>
        /// Locally cached detail about whether logging is enabled or not.
        /// </summary>
        private static readonly Lazy<bool> IsLoggingEnabled = new Lazy<bool>(() => LoggingRules.For(Categories.Collections).Any);

        /// <summary>
        /// Extension method for providing a comparison between two lists, indicating changes through collection of callbacks.
        /// </summary>
        /// <param name="comparer"></param>
        /// <param name="originalList"></param>
        /// <param name="newList"></param>
        /// <param name="insert"></param>
        /// <param name="delete"></param>
        /// <param name="move"></param>
        /// <param name="update"></param>
        public static void Compare(this ICollectionComparer<IPrimitive> comparer, IPrimitive[] originalList, IPrimitive[] newList,
            Action<int, IPrimitive> insert,
            Action<int, IPrimitive> delete,
            Action<int, int, IPrimitive> move,
            Action<int, IPrimitive, IPrimitive> update)
        {
            long compareDuration = 0;

            IReadOnlyList<Operation<IPrimitive>> differences;

            if (IsLoggingEnabled.Value)
            {
                using var _ = Benchmark.Create((d, _) =>
                {
                    compareDuration = d;
                });

                differences = comparer.Compare(originalList, newList);
            }
            else
            {
                differences = comparer.Compare(originalList, newList);
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
                    case InsertOp<IPrimitive> op:

                        // this is an insert operation, need to create the views at the specified place...
                        insert(op.Index, op.Item);

                        if (IsLoggingEnabled.Value)
                        {
                            Array.Resize(ref inserts, inserts.Length + 1);
                            inserts[^1] = op.Index;
                        }

                        break;
                    case DeleteOp<IPrimitive> op:

                        delete(op.Index, op.Item);

                        if (IsLoggingEnabled.Value)
                        {
                            Array.Resize(ref deletes, deletes.Length + 1);
                            deletes[^1] = op.Index;
                        }

                        //this is a delete operation, need to delete the views at the specified place...
                        break;

                    case MoveOp<IPrimitive> op:

                        move(op.From, op.To,op.Item);

                        if (IsLoggingEnabled.Value)
                        {
                            Array.Resize(ref moves, moves.Length + 1);
                            moves[^1] = op.From;
                        }

                        break;

                    case UpdateOp<IPrimitive> op:
                        update(op.Index, op.FromItem, op.ToItem);

                        if (IsLoggingEnabled.Value)
                        {
                            Array.Resize(ref updates, updates.Length + 1);
                            updates[^1] = op.Index;
                        }

                        break;
                }
            }

            if (IsLoggingEnabled.Value)
            {
                Logging.Instance.LogInformation(
                    "Collection Compare type:{type} from:{oldLength} to:{newLength} changes:{changeCount} duration:{duration}ms inserts:[{inserts}] updates:[{updates}] moves:[{moves}] deletes:[{deletes}]",
                    comparer.GetType().Name, originalList.Length, newList.Length, differences.Count, compareDuration,inserts,updates, moves,deletes);
            }

        }
    }
}