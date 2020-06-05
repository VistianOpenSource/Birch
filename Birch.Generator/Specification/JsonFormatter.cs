using Newtonsoft.Json;

namespace Birch.Generator.Specification
{
    public class JsonFormatter
    {
        private readonly JsonSerializerSettings _jsonSerializerSettings;

        public JsonFormatter()
        {
            _jsonSerializerSettings = new JsonSerializerSettings(){NullValueHandling = NullValueHandling.Ignore};
        }

        public string Format(Job job)
        {
            var generatedText = JsonConvert.SerializeObject(job,Formatting.Indented, _jsonSerializerSettings);
            return generatedText;
        }
    }
}