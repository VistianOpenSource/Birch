namespace Birch.Components
{
    public static class AttributeValue
    {
        public static AttributeValue<T> From<T>(Attribute<T> attribute, Attributes attributes)
        {
            T value = default;

            var hasValue = attributes?.TryGetAttribute(attribute,out value)??false;

            if (hasValue)
            {
                return new AttributeValue<T>(value);
            }
            else
            {
                return AttributeValue<T>.None;
            }
        }
    }

    public class AttributeValue<T>
    {
        public T Item { get; }
        public bool HasValue { get; internal set; }

        public AttributeValue()
        {
            HasValue = false;
        }

        public AttributeValue(T item)
        {
            Item = item;
            HasValue = true;
        }

        public static implicit operator T(AttributeValue<T> value) => value.Item;

        public static AttributeValue<T> None { get; } = new AttributeValue<T>();
    }
}