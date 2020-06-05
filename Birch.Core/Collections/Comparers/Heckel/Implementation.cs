using System;
using System.Collections.Generic;
using System.Linq;


namespace Birch.Collections.Comparers.Heckel
{
    /// <summary>
    /// Implementation of the Heckel Diff algorithm.
    /// </summary>
    /// <remarks>
    /// Original implementation taken from https://github.com/kobi2294/MvvmKit/blob/master/Source/MvvmKit/Tools/Algorithms/Heckel.cs
    /// and then adjusted to have less allocations and to have greater performance.</remarks>
    public static class Implementation
    {
        public static IList<Operation<T>> Diff<T>(T[] old, T[] @new, IEqualityComparer<T> comparer) where T : IEquatable<T>
        {
            var steps = new List<Operation<T>>(Math.Max(@new.Length,@old.Length));
            
            // Setup the arrays to store our entries
            var newArray = new Entry[@new.Length];
            var oldArray = new Entry[old.Length];

            var newLength = newArray.Length;
            var oldLength = oldArray.Length;

            var table = new Dictionary<T, SymbolEntry<T>>(Math.Max(old.Length, @new.Length),comparer);               // var table = [Int: SymbolEntry]()

            // Pass 1 comprises the following: (a) each line i of file N is read in sequence; (b) a symbol
            // table entry for each line i is created if it does not already exist; (c) NC for the line's
            // symbol table entry is incremented; and (d) NA [i] is set to point to the symbol table entry of

            void Pass1()
            {
                for (var index = 0; index < newLength; index++) // for item in new {
                {
                    var theItem = @new[index];

                    var entry = new SymbolEntry<T>(theItem,comparer);

                    try
                    {
                        // This may appear a little odd, and why it isn't a lookup followed by an assign
                        // when the lookup fails, but strangely under the scenarios of minimal hash collision
                        // its actually quicker to setup for an exception and instead to just try the add.
                        // In the majority of cases the add is quicker then performing two operations
                        // to the table

                        table.Add(theItem, entry);
                    }
                    catch (ArgumentException)
                    {
                        entry = table[theItem];
                    }

                    entry.NewCounter++; // entry.nc.increment()
                    newArray[index] = entry; // na.append(.symbol(entry))
                }
            }


            ;

            // Pass 2 is identical to pass 1 except that it acts on file O, array OA, and counter OC,
            // and OLNO for the symbol table entry is set to the line's number.

            void Pass2()
            {
                for (var index = 0; index < oldLength; index++) // for (index, item) in old.enumerated()
                {
                    var theItem = old[index];
                    var hash = comparer.GetHashCode(theItem);

                    var t = table.TryGetValue(theItem, out var entry);

                    if (!t)
                    {
                        entry = new SymbolEntry<T>(theItem,comparer);
                        table[theItem] = entry;
                    }

                    entry.AddOldNumber(index); // entry.olno.append(index)
                    oldArray[index] = entry; // oa.append(.symbol(entry))
                }
            }

            // In pass 3 we use observation 1 and process only those lines having NC = OC = 1. Since each
            // represents (we assume) the same unmodified line, for each we replace the symbol table pointers
            // in NA and OA by the number of the line in the other file. For example, if NA[i] corresponds to
            // such a line, we look NA[i] up in the symbol table and set NA[i] to OLNO and OA[OLNO] to i.
            // In pass 3 we also "find" unique virtual lines immediately before the first and immediately
            // after the last lines of the files.

            void Pass3()
            {
                for (var index = 0; index < newLength; index++)
                {
                    var item = newArray[index];

                    if ((item is SymbolEntry<T> entry) // if case let .symbol(entry) = item,                     
                        && entry.OccursInBoth // entry.occursInBoth, 
                        && entry.OldCounter > 0) // !entry.olno.isEmpty {
                    {
                        var oldIndex = entry.GetOldAndRemove(); // let oldIndex = entry.olno.removeFirst()

                        newArray[index] = new IndexEntry(oldIndex); // na[index] = .index(oldIndex)
                        oldArray[oldIndex] = new IndexEntry(index); // oa[oldIndex] = .index(index)
                    }
                }
            }

            // In pass 4, we apply observation 2 and process each line in NA in ascending order: If NA[i]
            // points to OA[j] and NA[i + 1] and OA[j + 1] contain identical symbol table entry pointers, then
            // OA[j + 1] is set to line i + 1 and NA[i + 1] is set to line j + 1.

            void Pass4()
            {
                var i = 1; // var i = 1
                while (i < newLength - 1) // while i < na.count - 1 {
                {
                    if ((newArray[i] is IndexEntry j) // if case let .index(j) = na[i]
                        && (j.Index < oldLength - 1) //      , j + 1 < oa.count,
                        && (newArray[i + 1] is SymbolEntry<T> newEntry) //      case let .symbol(newEntry) = na[i + 1],
                        && (oldArray[
                            j.Index + 1] is SymbolEntry<T> oldEntry) //      case let .symbol(oldEntry) = oa[j + 1], 
                        && oldEntry == newEntry) //      newEntry === oldEntry {
                    {
                        newArray[i + 1] = new IndexEntry(j.Index + 1); //      na[i + 1] = .index(j + 1)
                        oldArray[j.Index + 1] = new IndexEntry(i + 1); //      oa[j + 1] = .index(i + 1)
                    } // }

                    i++; // i += 1
                }
            }


            // In pass 5, we also apply observation 2 and process each entry in descending order: if NA[i]
            // points to OA[j] and NA[i - 1] and OA[j - 1] contain identical symbol table pointers, then
            // NA[i - 1] is replaced by j - 1 and OA[j - 1] is replaced by i - 1.

            void Pass5()
            {
                var i = newLength - 1; // i = na.count - 1
                while (i > 0) // while i > 0 {
                {
                    if ((newArray[i] is IndexEntry j) //  if case let .index(j) = na[i]
                        && (j.Index >= 1) //      , j - 1 >= 0,
                        && (newArray[i - 1] is SymbolEntry<T> newEntry) //      case let .symbol(newEntry) = na[i - 1],
                        && (oldArray[
                            j.Index - 1] is SymbolEntry<T> oldEntry) //      case let .symbol(oldEntry) = oa[j - 1],
                        && newEntry == oldEntry) //      newEntry === oldEntry {
                    {
                        newArray[i - 1] = new IndexEntry(j.Index - 1); //      na[i - 1] = .index(j - 1)
                        oldArray[j.Index - 1] = new IndexEntry(i - 1); //      oa[j - 1] = .index(i - 1)
                    } //      }

                    i--; //  i -= 1
                }
            } // }

            Pass1();
            Pass2();
            Pass3();
            Pass4();
            Pass5();

            // yield return replaces the need to hold and a list        // var steps = [Operation]()
            var deleteOffsets = new int[oldLength];//Enumerable.Repeat(0, old.Count)     // var deleteOffsets = Array(repeating: 0, count: old.count)
                                                   //.ToArray();
            var runningOffset = 0;                                      // var runningOffset = 0

            for (var index = 0; index < oldLength; index++)                // for (index, item) in oa.enumerated() {
            {
                var item = oldArray[index];
                deleteOffsets[index] = runningOffset;                   // deleteOffsets[index] = runningOffset
                if (item is SymbolEntry<T> se)                                // if case .symbol = item {
                {
                    steps.Add( new DeleteOp<T>(index,se.OldItem));
                    runningOffset++;                                 // runningOffset += 1
                }
            }

            runningOffset = 0;                                          // runningOffset = 0

            for (var index = 0; index < newLength; index++)                      // for (index, item) in na.enumerated() {
            {
                var item = newArray[index];

                switch (item)                                           // switch item {
                {
                    case SymbolEntry<T> se:                             //  case .symbol:
                        steps.Add(new  InsertOp<T>(index,se.OldItem));//      steps.append(.insert(index))
                        runningOffset++;                             //      runningOffset += 1
                        break;
                    case IndexEntry oldIndex:                           // case let .index(oldIndex):

                        // The object has changed, so it should be updated.
                        // TODO: I believe this can never happen , 
                        if (!comparer.Equals(old[oldIndex.Index], @new[index])) // if old[oldIndex] != new[index] {
                        {
                            steps.Add(new UpdateOp<T>(index, old[oldIndex.Index], @new[index]));// steps.append(.update(index))
                        }                                                           // }

                        var deleteOffset = deleteOffsets[oldIndex.Index];           // let deleteOffset = deleteOffsets[oldIndex]
                        // The object is not at the expected position, so move it.

                        var oldCalculatedIndex = oldIndex.Index - deleteOffset + runningOffset;
                        if (oldCalculatedIndex != index)   // if (oldIndex - deleteOffset + runningOffset) != index {
                        {
                            steps.Add(new MoveOp<T>(oldIndex.Index, index, old[oldIndex.Index])); // steps.append(.move(oldIndex, index))
                        }
                        break;
                }
            }

            return steps;
        }

        /// <summary>
        /// Perform an ordered diff, this is typically what can be used by UI libraries to apply changes in a logical fashion.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="old"></param>
        /// <param name="new"></param>
        /// <param name="comparer"></param>
        /// <returns></returns>
        public static IReadOnlyList<Operation<T>> OrderedDiff<T>(T[] old, T[] @new, IEqualityComparer<T> comparer) where T : IEquatable<T>
        {
            var steps = Diff(old, @new, comparer);

            var insertions = new List<Operation<T>>();
            var updates = new List<Operation<T>>();

            var possibleDeletions = new Operation<T>[old.Length];

            void Action(int fromIndex, Operation<T> step)
            {
                if (possibleDeletions[fromIndex] == null)
                {
                    possibleDeletions[fromIndex] = step;
                }
            }

            foreach (var step in steps)
            {
                switch (step)
                {
                    case InsertOp<T> _:
                        insertions.Add(step);
                        break;
                    case DeleteOp<T> del:
                        Action(del.Index, step);
                        break;
                    case MoveOp<T> mov:
                        insertions.Add(new InsertOp<T>(mov.To, mov.Item));
                        Action(mov.From, new DeleteOp<T>(mov.From, mov.Item));
                        break;
                    case UpdateOp<T> _:
                        updates.Add(step);
                        break;
                }
            }

            var deletions = possibleDeletions.Where(x => x != null).Reverse();


            return deletions.Concat(insertions).Concat(updates).ToList();
        }
    }
}