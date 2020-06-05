using System.Collections.Concurrent;
using Birch.Components;

namespace Birch.Reflection
{
    public class AttributeMapperStore
    {
        public static AttributeMapperStore Default { get; } = new AttributeMapperStore();

        private readonly ConcurrentDictionary<int,IAttributeMapper> _mappers = new ConcurrentDictionary<int, IAttributeMapper>();

        public void Register(Attribute attribute, IAttributeMapper mapper)
        {
            _mappers[attribute.Id] = mapper;
        }

        public IAttributeMapper GetMapperFor(Attribute attribute)
        {
            return GetMapperFor(attribute.Id);
        }

        public IAttributeMapper GetMapperFor(int attributeId)
        {
            return _mappers.TryGetValue(attributeId, out var mapper) ? mapper : default;
        }

    }
}