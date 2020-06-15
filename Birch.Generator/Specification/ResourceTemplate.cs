using System;
using System.Collections.Generic;
using System.Text;
using Birch.Generator.Generation;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Birch.Generator.Specification
{
    public class ResourceTemplate
    {
        [JsonProperty("resourceName")]
        public string ResourceName { get; }

        [JsonProperty("TemplateName")]
        public string TemplateName { get; }

        [JsonProperty("type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public TemplateType Type { get; }

        public ResourceTemplate(string resourceName, string templateName, TemplateType type)
        {
            ResourceName = resourceName;
            TemplateName = templateName;
            Type = type;
        }
    }
}
