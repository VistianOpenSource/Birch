using System;
using Birch.Generator.Generation;
using Birch.Generator.Styles.Extension;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Birch.Generator.Specification
{
    public class OutputTypeConverter:JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            serializer.Serialize(writer, value);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);

            var theType = jsonObject[Style.GenerationTypeKey];

            if (theType == null)
            {
                throw new InvalidOperationException($"Missing {Style.GenerationTypeKey} implementation in specification {jsonObject}");
            }

            var outputType = TypeGeneratorStore.Instance.Create(theType.Value<string>());

            serializer.Populate(jsonObject.CreateReader(),outputType);

            return outputType;
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(IGenerationStyle);
        }
    }
}