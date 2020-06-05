namespace Birch.Components
{
    /// <summary>
    /// Wrapper around a primitive and its attributes.
    /// </summary>
    /// <typeparam name="TPrimitive"></typeparam>
    /// <remarks>
    /// TODO: do we still need this ?
    /// </remarks>
    public class ElementValue<TPrimitive>
    {
        public TPrimitive Primitive { get; }
        public Attributes Attributes { get; }

        public ElementValue(TPrimitive primitive,Attributes attributes)
        {
            Primitive = primitive;
            Attributes = attributes;
        }

        public AttributeValue<T> Value<T>(Attribute<T> attribute)
        {
            return AttributeValue.From(attribute, Attributes);
        }
    }

    public static class ElementValue
    {
        public static ElementValue<TComponent> From<TComponent>(TComponent component, Attributes attributes)
        {
            return new ElementValue<TComponent>(component,attributes);
        }
    }

}