namespace Birch.Components
{
    /// <summary>
    /// A composite <see cref="IElement"/>.
    /// </summary>
    /// <remarks>
    /// An <see cref="IComposite"/> would have an associated layout implementation which would
    /// convert it into a <see cref="IPrimitive"/> representation
    /// </remarks>
    public interface IComposite:IElement
    {
    }
}