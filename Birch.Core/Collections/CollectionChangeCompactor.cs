using System;
using System.Collections.Generic;
using System.Linq;
using Birch.Collections.Comparers;
using Birch.Components;

namespace Birch.Collections
{
    /// <summary>
    /// Attempts to reduce the number of update operations to a <see cref="IList{IPrimitive}"/> 
    /// </summary>
    /// <remarks>
    /// In principle this class looks for Inserts and Deletes which it can merge into a single Update.
    /// An update can be made on the assumption that the type of the IPrimitive is the same.
    /// </remarks>
    public partial class CollectionChangeCompactor
    {
        private readonly List<Entry> _snapShot;

        /// <summary>
        /// Initialize with our base collection of <see cref="IPrimitive"/>
        /// </summary>
        /// <param name="primitives"></param>
        public CollectionChangeCompactor(IEnumerable<IPrimitive> primitives)
        {
            _snapShot = primitives.Select((p, i) => Entry.Create(i, p)).ToList();
        }

        /// <summary>
        /// Delete the item at the specified index
        /// </summary>
        /// <param name="currentIndex"></param>
        public void Delete(int currentIndex)
        {
            // need to find the 'n'th entry and mark it as deleted
            var item = _snapShot.FirstOrDefault(s => s.OriginalIndex == currentIndex);

            if (item == null || item.State == TransactionState.Deleted)
            {
                throw new ArgumentException($"Should be available to delete but can't {currentIndex}");
            }
            else
            {
                // mark as deleted
                item.Delete();
            }
        }

        /// <summary>
        /// Insert an item at the specified index
        /// </summary>
        /// <param name="nextIndex"></param>
        /// <param name="next"></param>
        public void Insert(int nextIndex, IPrimitive next)
        {
            // when we insert, we not only need to find the correct position, BUT, we also need to 
            var start = GetStartingIndex(nextIndex, false);

            // if beyond end of list, just create an insert
            if (start >= _snapShot.Count)
            {
                _snapShot.Add(Entry.Insert(next));
                return;
            }

            // look up the item
            var item = _snapShot[start];

            // if its deleted
            if (item.State == TransactionState.Deleted)
            {
                // we need to try and see if we can re-use here...

                var loopIndex = start;

                // loop over the deleted items from this point looking for something of the same type
                while (loopIndex < _snapShot.Count && _snapShot[loopIndex].State == TransactionState.Deleted &&
                       _snapShot[loopIndex].Current.GetType() != next.GetType())
                {
                    ++loopIndex;
                }

                // if we didn't find one, lets do an insert
                if (loopIndex == _snapShot.Count)
                {
                    _snapShot.Insert(start,Entry.Insert(next));
                }
                else
                {
                    // we did get one, lets update it to an update
                    var loopItem = _snapShot[loopIndex];

                    if (loopItem.State == TransactionState.Deleted)
                    {
                        // ah - ha we can apply an update ...
                        loopItem.Update(next);
                    }
                    else
                    {
                        // we can't apply an update, its time to insert
                        _snapShot.Insert(start,Entry.Insert(next));
                    }
                }
            }
            else
            {
                _snapShot.Insert(start,Entry.Insert(next));
            }
        }

        /// <summary>
        /// Update the item at a specified index.
        /// </summary>
        /// <param name="currentIndex"></param>
        /// <param name="primitive"></param>
        public void Update(int currentIndex, IPrimitive primitive)
        {
            var item = _snapShot.FirstOrDefault(s => s.OriginalIndex == currentIndex);

            if (item == null || item.State == TransactionState.Deleted)
            {
                throw new ArgumentException($"Should be available to update but can't {currentIndex}");
            }
            else
            {
                item.Update(primitive);
            }
        }

        /// <summary>
        /// Get the starting index for an operation.
        /// </summary>
        /// <param name="index"></param>
        /// <param name="includeDeleted"></param>
        /// <returns></returns>
        public int GetStartingIndex(int index,bool includeDeleted=false)
        {
            var runningIndex = 0;

            if (runningIndex == index)
            {
                return runningIndex;
            }

            if (includeDeleted)
            {
                return index;
            }

            int amountLeft = index;

            foreach (var t in _snapShot)
            {
                if (amountLeft==0)
                {
                    // now then, are we at the end of the list ?
                    // if so return that 
                    return Math.Min(runningIndex, _snapShot.Count);
                }

                if (t.State != TransactionState.Deleted)
                {
                    --amountLeft;
                }

                ++runningIndex;
            }

            return runningIndex;
        }


        /// <summary>
        /// Get all of the changes in order, so they can be applied.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Operation<IPrimitive>> GetChangOps()
        {
            // do the updates first, since we need the positions where things are NOW
            for (var i = 0; i <= _snapShot.Count - 1; i++)
            {
                var item = _snapShot[i];
                    
                if (item.State == TransactionState.Updated)
                {
                    yield return new UpdateOp<IPrimitive>(item.OriginalIndex,item.Current,item.Next);
                }
            }

            // do the deletes first, backwards
            for (var i = _snapShot.Count - 1; i >= 0; i--)
            {
                var item = _snapShot[i];

                if (item.State == TransactionState.Deleted)
                {
                    yield return new DeleteOp<IPrimitive>(item.OriginalIndex,item.Current);
                }

            }

            // and now do the inserts
            var runningDeleteCounts = 0;

            for (var i = 0; i <= _snapShot.Count - 1; i++)
            {
                var item = _snapShot[i];
                    
                // now we are doing the non deletions, so if deleted, 
                if (item.State == TransactionState.Deleted)
                {
                    ++runningDeleteCounts;
                }

                if (item.State == TransactionState.Inserted)
                {
                    yield return new InsertOp<IPrimitive>(i-runningDeleteCounts,item.Next);

                }
            }
        }

        /// <summary>
        /// Get all of the changes in order, so they can be applied.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<(int index, Entry item)> GetChanges()
        {
            // do the updates first, since we need the positions where things are NOW
            for (var i = 0; i <= _snapShot.Count - 1; i++)
            {
                var item = _snapShot[i];
                    
                if (item.State == TransactionState.Updated)
                {
                    yield return (i,item);
                }
            }

            // do the deletes first, backwards
            for (var i = _snapShot.Count - 1; i >= 0; i--)
            {
                var item = _snapShot[i];

                if (item.State == TransactionState.Deleted)
                {
                    yield return (i,item);
                }

            }

            // and now do the inserts
            var runningDeleteCounts = 0;

            for (var i = 0; i <= _snapShot.Count - 1; i++)
            {
                var item = _snapShot[i];
                    
                // now we are doing the non deletions, so if deleted, 
                if (item.State == TransactionState.Deleted)
                {
                    ++runningDeleteCounts;
                }

                if (item.State == TransactionState.Inserted)
                {
                    yield return (i-runningDeleteCounts,item);
                }
            }
        }
    }


    public partial class CollectionChangeCompactor<T>
    {
        private readonly List<Entry> _snapShot;

        /// <summary>
        /// Initialize with our base collection of <see cref="IPrimitive"/>
        /// </summary>
        public CollectionChangeCompactor(IEnumerable<T> items)
        {
            _snapShot = items.Select((p, i) => Entry.Create(i, p)).ToList();
        }

        /// <summary>
        /// Delete the item at the specified index
        /// </summary>
        /// <param name="currentIndex"></param>
        public void Delete(int currentIndex)
        {
            // need to find the 'n'th entry and mark it as deleted
            var item = _snapShot.FirstOrDefault(s => s.OriginalIndex == currentIndex);

            if (item == null || item.State == TransactionState.Deleted)
            {
                throw new ArgumentException($"Should be available to delete but can't {currentIndex}");
            }
            else
            {
                // mark as deleted
                item.Delete();
            }
        }

        /// <summary>
        /// Insert an item at the specified index
        /// </summary>
        /// <param name="nextIndex"></param>
        /// <param name="next"></param>
        public void Insert(int nextIndex, T next)
        {
            // when we insert, we not only need to find the correct position, BUT, we also need to 
            var start = GetStartingIndex(nextIndex, false);

            // if beyond end of list, just create an insert
            if (start >= _snapShot.Count)
            {
                _snapShot.Add(Entry.Insert(next));
                return;
            }

            // look up the item
            var item = _snapShot[start];

            // if its deleted
            if (item.State == TransactionState.Deleted)
            {
                // we need to try and see if we can re-use here...

                var loopIndex = start;

                // loop over the deleted items from this point looking for something of the same type
                while (loopIndex < _snapShot.Count && _snapShot[loopIndex].State == TransactionState.Deleted &&
                       _snapShot[loopIndex].Current.GetType() != next.GetType())
                {
                    ++loopIndex;
                }

                // if we didn't find one, lets do an insert
                if (loopIndex == _snapShot.Count)
                {
                    _snapShot.Insert(start,Entry.Insert(next));
                }
                else
                {
                    // we did get one, lets update it to an update
                    var loopItem = _snapShot[loopIndex];

                    if (loopItem.State == TransactionState.Deleted)
                    {
                        // ah - ha we can apply an update ...
                        loopItem.Update(next);
                    }
                    else
                    {
                        // we can't apply an update, its time to insert
                        _snapShot.Insert(start,Entry.Insert(next));
                    }
                }
            }
            else
            {
                _snapShot.Insert(start,Entry.Insert(next));
            }
        }

        /// <summary>
        /// Update the item at a specified index.
        /// </summary>
        /// <param name="currentIndex"></param>
        /// <param name="next"></param>
        public void Update(int currentIndex, T next)
        {
            var item = _snapShot.FirstOrDefault(s => s.OriginalIndex == currentIndex);

            if (item == null || item.State == TransactionState.Deleted)
            {
                throw new ArgumentException($"Should be available to update but can't {currentIndex}");
            }
            else
            {
                item.Update(next);
            }
        }

        /// <summary>
        /// Get the starting index for an operation.
        /// </summary>
        /// <param name="index"></param>
        /// <param name="includeDeleted"></param>
        /// <returns></returns>
        public int GetStartingIndex(int index,bool includeDeleted=false)
        {
            var runningIndex = 0;

            if (runningIndex == index)
            {
                return runningIndex;
            }

            if (includeDeleted)
            {
                return index;
            }

            int amountLeft = index;

            foreach (var t in _snapShot)
            {
                if (amountLeft==0)
                {
                    // now then, are we at the end of the list ?
                    // if so return that 
                    return Math.Min(runningIndex, _snapShot.Count);
                }

                if (t.State != TransactionState.Deleted)
                {
                    --amountLeft;
                }

                ++runningIndex;
            }

            return runningIndex;
        }


        /// <summary>
        /// Get all of the changes in order, so they can be applied.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Operation<T>> GetChangOps()
        {
            // do the updates first, since we need the positions where things are NOW
            for (var i = 0; i <= _snapShot.Count - 1; i++)
            {
                var item = _snapShot[i];
                    
                if (item.State == TransactionState.Updated)
                {
                    yield return new UpdateOp<T>(item.OriginalIndex,item.Current,item.Next);
                }
            }

            // do the deletes first, backwards
            for (var i = _snapShot.Count - 1; i >= 0; i--)
            {
                var item = _snapShot[i];

                if (item.State == TransactionState.Deleted)
                {
                    yield return new DeleteOp<T>(item.OriginalIndex,item.Current);
                }

            }

            // and now do the inserts
            var runningDeleteCounts = 0;

            for (var i = 0; i <= _snapShot.Count - 1; i++)
            {
                var item = _snapShot[i];
                    
                // now we are doing the non deletions, so if deleted, 
                if (item.State == TransactionState.Deleted)
                {
                    ++runningDeleteCounts;
                }

                if (item.State == TransactionState.Inserted)
                {
                    yield return new InsertOp<T>(i-runningDeleteCounts,item.Next);

                }
            }
        }

        /// <summary>
        /// Get all of the changes in order, so they can be applied.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<(int index, Entry item)> GetChanges()
        {
            // do the updates first, since we need the positions where things are NOW
            for (var i = 0; i <= _snapShot.Count - 1; i++)
            {
                var item = _snapShot[i];
                    
                if (item.State == TransactionState.Updated)
                {
                    yield return (i,item);
                }
            }

            // do the deletes first, backwards
            for (var i = _snapShot.Count - 1; i >= 0; i--)
            {
                var item = _snapShot[i];

                if (item.State == TransactionState.Deleted)
                {
                    yield return (i,item);
                }

            }

            // and now do the inserts
            var runningDeleteCounts = 0;

            for (var i = 0; i <= _snapShot.Count - 1; i++)
            {
                var item = _snapShot[i];
                    
                // now we are doing the non deletions, so if deleted, 
                if (item.State == TransactionState.Deleted)
                {
                    ++runningDeleteCounts;
                }

                if (item.State == TransactionState.Inserted)
                {
                    yield return (i-runningDeleteCounts,item);
                }
            }
        }
    }

}