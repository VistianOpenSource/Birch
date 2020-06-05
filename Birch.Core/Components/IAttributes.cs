namespace Birch.Components
{
    /// <summary>
    /// Specification of a component that stores properties in an <see cref="Attributes"/> instance.
    /// </summary>
    public interface IAttributes
    {
        Attributes Attributes { get; set; }
    }
}