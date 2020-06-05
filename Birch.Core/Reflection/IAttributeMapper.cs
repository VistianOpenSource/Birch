using Birch.Shadows;

namespace Birch.Reflection
{
    public interface IAttributeMapper
    {
        void Set(IShadow shadow, object value);
        void Update(IShadow shadow, object oldValue, object newValue);
        void Clear(IShadow shadow, object value);
    }
}