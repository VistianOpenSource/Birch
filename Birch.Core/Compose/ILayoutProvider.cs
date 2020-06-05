using Birch.Components;

namespace Birch.Compose
{
    /// <summary>
    /// Lays out a <see cref="IElement"/> to its associated <see cref="IPrimitive"/>
    /// </summary>
    public interface ILayoutProvider
    {
        IPrimitive PerformLayout(LayoutContext layoutContext,IElement element);
    }
}