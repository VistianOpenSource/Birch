using System;
using System.Collections.Generic;
using System.Linq;

namespace Birch.Collections.Comparers.Heckel
{
    public class SymbolEntry<T>: Entry, IEquatable<SymbolEntry<T>>
    {
        public T OldItem { get; }

        // Occurrences of symbol in Old array
        public int OldCounter => _oldNumbersCount-_oldIndex;

        // Occurrences of symbol in New array
        public int NewCounter { get; set; }

        /// <summary>
        /// we use a counter for the number of old items
        /// </summary>
        /// 
        private int _oldNumbersCount ;

        /// <summary>
        /// The first old item 
        /// </summary>
        /// <remarks>
        /// Given that typically one doesn't have multiple duplicates in a list
        /// we can reduce the number of allocations by keeping the first
        /// value of old numbers not in a list but in an array</remarks>
        private int _oldNumberIndex0;

        /// <summary>
        /// The old numbers when we have more than one old number
        /// </summary>
        public int[] OldNumbers;

        public void AddOldNumber(int oldNumber)
        {
            if (_oldNumbersCount == 0)
            {
                _oldNumbersCount = 1;
                _oldNumberIndex0 = oldNumber;
            }
            else if (_oldNumbersCount == 1)
            {
                OldNumbers = new[] {_oldNumberIndex0, oldNumber};
                _oldNumbersCount = 2;
            }
            else
            {
                Array.Resize(ref OldNumbers,OldNumbers.Length+1);
                OldNumbers[^1] = oldNumber;
                ++_oldNumbersCount;
            }
        }



        /// <summary>
        /// Counter to where the next old number is to be pulled from.
        /// </summary>
        /// <remarks>
        /// We do this to try and reduce allocations by resizing
        /// the array of old numbers</remarks>
        private int _oldIndex ;

        private readonly IEqualityComparer<T> _equalityComparer;

        public int GetOldAndRemove()
        {
            // we only have one old number
            if (_oldNumbersCount == 1)
            {
                _oldNumbersCount = 0;
                ++_oldIndex;
                return _oldNumberIndex0;
            }
            else
            {
                // we have more than one old number, so take it from the array
                    
                var retVal = OldNumbers[_oldIndex];

                ++_oldIndex;

                --_oldNumbersCount;
                return retVal;
            }
        }
     

        public bool OccursInBoth => (OldCounter > 0) && (NewCounter > 0);

        public SymbolEntry(T item,IEqualityComparer<T> equalityComparer=default)
        {
            _equalityComparer = equalityComparer ?? EqualityComparer<T>.Default;
            OldItem = item;
        }

        public bool Equals(SymbolEntry<T> other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return OldCounter == other.OldCounter && NewCounter == other.NewCounter
                                                  && OldNumbersEqual(other) && _equalityComparer.Equals(OldItem, other.OldItem);
        }

        private bool OldNumbersEqual(SymbolEntry<T> other)
        {

            if (_oldIndex != other._oldIndex) return false;

            if (_oldIndex == 1)
            {
                return _oldNumberIndex0 == other._oldNumberIndex0;
            }

            if (OldNumbers == null && other.OldNumbers == null) return true;

            if (OldNumbers == null || other.OldNumbers == null) return false;

            return OldNumbers.SequenceEqual(other.OldNumbers);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == this.GetType() && Equals((SymbolEntry<T>) obj);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(OldNumbers, OldItem, OldCounter, NewCounter);
        }

        public static bool operator ==(SymbolEntry<T> left, SymbolEntry<T> right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SymbolEntry<T> left, SymbolEntry<T> right)
        {
            return !Equals(left, right);
        }
    }
}