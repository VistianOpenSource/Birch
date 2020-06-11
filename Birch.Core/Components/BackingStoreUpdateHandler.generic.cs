using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Birch.Collections;
using Birch.Collections.Comparers;
using Birch.Compose;
using Birch.Diagnostics;
using Birch.Metrics;
using Birch.Reflection;
using Microsoft.Extensions.Logging;

namespace Birch.Components
{
    /// <summary>
    /// Takes changes between view elements and applies them to a backing store.
    /// </summary>
    /// <remarks>
    /// This would be invoked from a <see cref="IShadowMapper"/> implementation during the layout/comparison phase.
    /// This means that the call in would be whilst from either an update or a remove call and hence under the assumption of a
    /// transaction being in place. The actual usage of the transaction is down to the specific connector, this code is just a simple mechanism
    /// to try and keep the changes between the current and next states down to an absolute minimum.
    /// </remarks>
    public class BackingStoreUpdateHandler<TContext,TItem,TTarget>:BackingStoreUpdateHandler,IBackingDataHandler<TContext,TItem> where TItem : class
    {
        /// <summary>
        /// The connector to the data 
        /// </summary>
        private readonly IDataConnector<TTarget> _connector;

        private readonly Attribute<TTarget[]> _attribute;

        /// <summary>
        /// THe collection comparer implementation
        /// </summary>
        private readonly ICollectionComparer<TTarget> _collectionComparer;

        public BackingStoreUpdateHandler(IDataConnector<TTarget> connector,Attribute<TTarget[]> attribute,ICollectionComparer<TTarget> collectionComparer=default)
        {
            _connector = connector;
            _attribute = attribute;
            _collectionComparer = collectionComparer;
        }

        public void Update(TContext context, BasePrimitive<TItem> current, BasePrimitive<TItem> next)
        {
            var currentList = current?.Attributes.GetAttributeOrDefault(_attribute);
            var nextList = next?.Attributes.GetAttributeOrDefault(_attribute);

            // get an id to allow for easy viewing
            long loggingId = 0;


            if (IsLoggingEnabled.Value)
            {
                loggingId = Interlocked.Increment(ref LoggingId);
                Logging.Instance.LogInformation("CollectionUpdate:Begin {id} current Length:{currentLength} next Length:{nextLength}",loggingId,currentList?.Length??0,nextList?.Length??0);
            }

            IEnumerable<Operation<TTarget>> operations;

            // get a list of operations that transform currentList to nextList

            IReadOnlyList<Operation<TTarget>> comparisonOperations;
            
            if (IsLoggingEnabled.Value)
            {
                using var _ = Benchmark.Create((d, __) =>
                {
                    Logging.Instance.LogInformation("CollectionUpdate:Timings {id} duration:{duration}ms, algorithm:{algorithm}",loggingId,d,_collectionComparer.GetType().FriendlyName());
                });

                comparisonOperations = _collectionComparer.Compare(currentList, nextList);
            }
            else
            {
                comparisonOperations = _collectionComparer.Compare(currentList, nextList);
            }

            if (IsLoggingEnabled.Value)
            {
                Logging.Instance.LogInformation("CollectionUpdate:Raw {id} change count:{count}",loggingId,comparisonOperations.Count);
            }


            // only perform an attempt at a compaction if there is an insert and a delete both in existence
            if (comparisonOperations.Count >= 2 && comparisonOperations.Any(f => f.GetType() == typeof(DeleteOp<IPrimitive>)) && comparisonOperations.Any(f => f.GetType() == typeof(InsertOp<IPrimitive>)))
            {
                if (IsLoggingEnabled.Value)
                {
                    Logging.Instance.LogInformation("CollectionUpdate:Compacting Changes");
                }

                // create our collection change compactor which will look to reduce the number of updates made

                var collectionChangeCompactor = new CollectionChangeCompactor<TTarget>(currentList??nextList);

                foreach (var operation in comparisonOperations)
                {
                    switch (operation)
                    {
                        case InsertOp<TTarget> op:
                            collectionChangeCompactor.Insert(op.Index,op.Item);
                            break;

                        case DeleteOp<TTarget> op:
                            collectionChangeCompactor.Delete(op.Index);
                            break;

                        case MoveOp<TTarget> op:
                            collectionChangeCompactor.Delete(op.From);
                            collectionChangeCompactor.Insert(op.To,op.Item);
                            break;

                        case UpdateOp<TTarget> op:
                            collectionChangeCompactor.Update(op.Index,op.ToItem);
                            break;
                    }
                }

                operations = collectionChangeCompactor.GetChangOps();
            }
            else
            {
                operations = comparisonOperations;
            }
            
            // now apply changes

            foreach (var operation in operations)
            {
                switch (operation)
                {
                    case UpdateOp<TTarget> op:

                        if (IsLoggingEnabled.Value)
                        {
                            Logging.Instance.LogInformation("CollectionUpdate:Update {id} {index}:{item}",loggingId,op.Index,op.FromItem,op.ToItem);
                        }

                        _connector.Update(op.Index,op.FromItem,op.ToItem);
                        break;

                    case DeleteOp<TTarget> op:

                        if (IsLoggingEnabled.Value)
                        {
                            Logging.Instance.LogInformation("CollectionUpdate:Delete {id} {index}:{item}",loggingId,op.Index,op.Item);
                        }

                        _connector.Remove(op.Index,op.Item);
                        break;

                    case InsertOp<TTarget> op:

                        if (IsLoggingEnabled.Value)
                        {
                            Logging.Instance.LogInformation("CollectionUpdate:Insert {id} {index}:{item}",loggingId,op.Index,op.Item);
                        }

                        _connector.Insert(op.Index,op.Item);
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }

            if (IsLoggingEnabled.Value)
            {
                Logging.Instance.LogInformation("CollectionUpdate:End {id}",loggingId);
            }
        }


        /// <summary>
        /// Remove all of the children
        /// </summary>
        /// <param name="context"></param>
        /// <param name="current"></param>
        public void Remove(TContext context, BasePrimitive<TItem> current)
        {
            var children = current?.Attributes.GetAttributeOrDefault(_attribute);

            if (children != null)
            {
                // work from the top downwards, otherwise we will throw an exception due to 
                // out of range indices
                for (var i = children.Length - 1; i >= 0; i--)
                {
                    var i1 = i;
                    _connector.Remove(i1,children[i1]);
                }
            }
        }
    }

}