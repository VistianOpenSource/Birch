using System.Collections.Generic;
using System.Linq;

namespace Birch.Collections.Comparers.Simple
{
    /// <summary>
    /// Simplistic list comparison algorithm.
    /// </summary>
    /// <remarks>
    /// Algorithm approximately as follows:
    /// 1. For each item in new list, compare against same position in old list
    /// 2. if old item didn't exist then we insert this new item at the specified position
    /// 3. if old item did exist we compare them.
    /// 4. If they are the same we do nothing.
    /// 5. If different we compare their types (which includes we could 'update' if of same type)
    /// 6. If types are the same we attempt an update/// 
    /// 7. If types aren't the same we do a delete and insert sequence of operations.
    /// 8. If new list shorter than old list, remove all items until lists are of same length
    /// </remarks>
    public class Implementation
    {
        /// <summary>
        /// Given a collection and a previous version of that collection, perform a reduced number clear/add/remove/insert operations
        /// </summary>
        /// <param name="old"></param>
        /// <param name="new"></param>
        /// <param name="comparer"></param>
        /// <remarks>
        /// As with all of these implementations, the order is very important in which the results are returned.
        /// </remarks>
        public static IReadOnlyList<Operation<T>> Diff<T>(T[] old, T[] @new,IEqualityComparer<T> comparer)
        {
            var updates = new List<Operation<T>>();
            var deletes = new List<Operation<T>>();
            var inserts = new List<Operation<T>>();

            var n = old.Length;

            // loop over each new item
            for (var i = 0; i < @new.Length; i++)
            {
                var newItem = @new[i];

                // are we looking into the old list or not
                if (i < n)
                {
                    var oldItem = old[i];

                    // see if changed
                    if (!comparer.Equals(newItem, oldItem))
                    {
                        // not the same, but type the same , if so we can try an update, which can reduce UI ops
                        if (oldItem.GetType() == newItem.GetType())
                        {
                            updates.Add(new UpdateOp<T>(i,oldItem,newItem));
                        }
                        else
                        {
                            deletes.Add(new DeleteOp<T>(i,oldItem));
                            inserts.Add(new InsertOp<T>(i,newItem));
                            // type wasn't the same, delete and insert
                        }
                    }
                }
                else
                {
                    // this is a create
                    inserts.Add(new InsertOp<T>(i,newItem));
                }
            }

            // remove the excess items that no longer exists
            for (var i = @new.Length;i < old.Length; i++)
            {
                deletes.Add(new DeleteOp<T>(i,old[i]));
            }

            // reverse the deletions, since need to do in reverse order otherwise might
            // get indexes that don't exist !
            deletes.Reverse();

            // and we apply the updates first, followed by the deletes then the inserts
            return updates.Concat(deletes).Concat(inserts).ToList();
        }
    }
}