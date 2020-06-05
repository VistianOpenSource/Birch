using System;

namespace Birch.Shadows
{
    /// <summary>
    /// The base type of a shadow.
    /// </summary>
    public interface IShadow:IDisposable
    {
        /// <summary>
        /// Get the <see cref="ContainerBag"/> which holds the shadows state
        /// </summary>
        ContainerBag State { get; }
    }

    /// <summary>
    /// Generic implementation of <see cref="IShadow"/>
    /// </summary>
    /// <typeparam name="TItem"></typeparam>
    public interface IShadow<out TItem>:IShadow
    {
        TItem Item { get; }
    }
}