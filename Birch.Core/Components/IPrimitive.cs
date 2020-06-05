using System;

namespace Birch.Components
{
    /// <summary>
    /// All native/low level primitive elements implement this interface.
    /// </summary>
    public interface IPrimitive:IElement,IEquatable<IPrimitive>,IAttributes
    {
        /// <summary>
        /// Get the hash code
        /// </summary>
        /// <param name="mode"></param>
        /// <returns></returns>
        int GetHashCode(ComparisonMode mode);

        /// <summary>
        /// Compare with another <see cref="IPrimitive"/> using the specified <see cref="ComparisonMode"/>
        /// </summary>
        /// <param name="component"></param>
        /// <param name="mode"></param>
        /// <returns></returns>
        bool Equals(IPrimitive component, ComparisonMode mode);
    }
}