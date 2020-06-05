using Birch.Components;

namespace Birch.Reflection
{
    /// <summary>
    /// Some primitives may use reflection to ease creation and setting of properties.
    /// </summary>
    /// <typeparam name="TView"></typeparam>
    /// <remarks>
    /// Whilst this interface doesn't actually implement anything new, the usage of the type means
    /// we can improve the autocomplete facilities the user will see in their editor, meaning that
    /// only extensions for the particular view type would be shown.
    /// </remarks>
    public interface IReflectedPrimitive<out TView>:IPrimitive
    {
    }
}