using Birch.Components;

namespace Birch.Compose
{
    /// <summary>
    /// A <see cref="IComposite"/> that also does its layout.
    /// </summary>
    public interface IInlineComposite:IComposite
    {
        [Preserve()]
        IPrimitive PerformLayout(LayoutContext layoutContext);
    }
}