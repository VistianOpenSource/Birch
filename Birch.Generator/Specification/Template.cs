using Birch.Generator.Generation;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Birch.Generator.Specification
{
    public class Template
    {
        /// <summary>
        /// Get the name of the template
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Get the type of template
        /// </summary>
        [JsonProperty("type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public TemplateType Type { get; set; }

        /// <summary>
        /// Get the source of the template, currently either in line or a standalone file.
        /// </summary>
        [JsonProperty("source")]
        [JsonConverter(typeof(StringEnumConverter))]
        public TemplateLocation Source { get; set; }

        /// <summary>
        /// When a standalone file, the path to the file
        /// </summary>
        [JsonProperty("path")]
        public string Path { get; set; }

        /// <summary>
        /// When inline, the actual content of the template
        /// </summary>
        [JsonProperty("content")]
        public string Content { get; set; }

        public Template(string name, TemplateType type, TemplateLocation source)
        {
            Name = name;
            Type = type;
            Source = source;
        }
    }
}