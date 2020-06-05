using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Birch.Collections.Comparers.Myers
{
    /// <summary>
    /// Represent one whole edit part
    /// </summary>
    [DebuggerDisplay("Type = {EditType}, StartA = {StartA}, StartB = {StartB}, Length = {Length}")]
    public sealed class Edit
    {
        /// <summary>
        /// Length of change
        /// </summary>
        public int Length { get; }

        /// <summary>
        /// Start index in sequence A
        /// </summary>
        public int StartA { get; private set; }

        /// <summary>
        /// Start index in sequence B
        /// </summary>
        public int StartB { get; private set; }

        /// <summary>
        /// Type of edit
        /// </summary>
        public TextEditType EditType { get; }

        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="editType">Type of edit</param>
        /// <param name="startA">Start index in sequence A</param>
        /// <param name="startB">Start index in sequence B</param>
        /// <param name="length">Length of change</param>
        internal Edit(TextEditType editType, int startA, int startB, int length)
        {
            EditType = editType;
            StartA = startA;
            StartB = startB;
            Length = length;
        }

        /// <summary>
        /// Make offset of this edit
        /// </summary>
        /// <param name="offsetA">Offset in sequence A</param>
        /// <param name="offsetB">Offset in sequence B</param>
        public void Offset(int offsetA, int offsetB)
        {
            StartA += offsetA;
            StartB += offsetB;
        }
    }}
