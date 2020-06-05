namespace Birch.Components
{
    /// <summary>
    /// How a comparison of <see cref="IPrimitive"/> should be performed.
    /// </summary>
    public enum ComparisonMode
    {
        Shallow,    // Shallow comparison, no recursive comparison
        Deep        // Deep comparison, recursive comparison
    };
}