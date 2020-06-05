using System;
using System.Collections.Generic;
using System.Text;

namespace Birch.Collections.Comparers.Myers
{
    /// <summary>
    /// Types of edit activity in text
    /// </summary>
    public enum TextEditType
    {
        /// <summary>
        /// None
        /// </summary>
        None = 0,
        /// <summary>
        /// Delete
        /// </summary>
        Delete = 1,
        /// <summary>
        /// Insert
        /// </summary>
        Insert = 2,
        /// <summary>
        /// Change
        /// </summary>
        Change = 3,
    }
}
