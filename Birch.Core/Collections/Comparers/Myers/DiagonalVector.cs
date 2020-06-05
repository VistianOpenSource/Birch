using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Birch.Collections.Comparers.Myers
{
    /// <summary>
    /// Implements a vector from -MAX to MAX
    /// </summary>
    internal sealed class DiagonalVector
    {
        private readonly int[] _data;
        private readonly int _max;

        /// <summary>
        /// Access data by user index
        /// </summary>
        /// <param name="userIndex">User index</param>
        /// <returns>Vector data</returns>
        public int this[int userIndex]
        {
            get => _data[GetActualIndex(userIndex)];

            set => _data[GetActualIndex(userIndex)] = value;
        }

        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="n">Count of elements in sequence A</param>
        /// <param name="m">Count of elements in sequence B</param>
        public DiagonalVector(int n, int m)
        {
            var delta = n - m;

            // We have to add Delta to support reverse vectors, which are
            // centered around the Delta diagonal instead of the 0 diagonal.
            _max = n + m + Math.Abs(delta);

            // Create an array of size 2*MAX+1 to hold -MAX..+MAX.
            _data = new int[2 * _max + 1];
        }

        /// <summary>
        /// Makes check for user index
        /// </summary>
        /// <param name="userIndex">User index</param>
        /// <returns>Data array index</returns>
        private int GetActualIndex(int userIndex)
        {
            var result = userIndex + _max;

            Debug.Assert(result >= 0 && result < _data.Length,
                "The actual index must be within the actual _data array's bounds.");
            return result;
        }
    }
}
