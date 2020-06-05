using System;
using System.Collections.Generic;
using Birch.Components;

namespace Birch.Collections
{
    /// <summary>
    /// Base implementation for comparing two <see cref="IPrimitive"/> instances with the mode of comparison being specified
    /// </summary>
    public abstract class PrimitiveEqualityComparer:IEqualityComparer<IPrimitive>
    {
        private readonly ComparisonMode _mode;

        /// <summary>
        /// Create an instance with a specified <see cref="ComparisonMode"/>
        /// </summary>
        /// <param name="mode"></param>
        protected PrimitiveEqualityComparer(ComparisonMode mode)
        {
            _mode = mode;
        }
        public bool Equals(IPrimitive x, IPrimitive y)
        {
            if (x == null && y == null)
            {
                return true;
            }

            if (x == null || y == null)
            {
                return false;
            }

            return ReferenceEquals(x,y) || x.Equals(y,_mode);
        }

        public int GetHashCode(IPrimitive obj)
        {
            return (int)obj?.GetHashCode(_mode);
        }
    }
}