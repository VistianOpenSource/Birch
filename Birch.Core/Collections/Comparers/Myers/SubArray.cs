using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Birch.Collections.Comparers.Myers
{
    /// <summary>
    /// Allows 1..M access for a selected portion of an int array.
    /// </summary>
    internal struct SubArray<T>
    {
        private readonly IList<T> _data;

        /// <summary>
        /// Data length
        /// </summary>
        public int Length { get; }

        /// <summary>
        /// Data lookup offset
        /// </summary>
        public int Offset { get; }

        /// <summary>
        /// Indexed data access
        /// </summary>
        /// <param name="index">Index of data</param>
        /// <returns>Data on selected index + offset</returns>
        public T this[int index] => _data[Offset + index - 1];

        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="data">Raw data</param>
        public SubArray(IList<T> data)
        {
            _data = data;
            Offset = 0;
            Length = _data.Count;
        }

        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="data">Raw data</param>
        /// <param name="offset">Data lookup offset</param>
        /// <param name="length">Data lenght</param>
        public SubArray(SubArray<T> data, int offset, int length)
        {
            _data = data._data;

            // Subtract 1 here because _offset will be 1-based
            Offset = data.Offset + offset - 1;
            Length = length;
        }

        /// <summary>
        /// Text representation of this object
        /// </summary>
        /// <returns>Text representation</returns>
        public override string ToString()
        {
            var sb = new StringBuilder(3 * Length);
            for (var i = 0; i < Length; i++)
            {
                sb.AppendFormat(CultureInfo.InvariantCulture, "{0} ", _data[Offset + i]);
            }

            return sb.ToString();
        }
    }}
