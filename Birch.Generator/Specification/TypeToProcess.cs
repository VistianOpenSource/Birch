using System.Collections.Generic;
using Newtonsoft.Json;

namespace Birch.Generator.Specification
{
    /// <summary>
    /// Specification of a particular type for which code is to be generated.
    /// </summary>
    public class TypeToProcess
    {
        /// <summary>
        /// The full type name to be considered
        /// </summary>
        [JsonProperty("type")]
        public string FullTypeName { get; set; }

        [JsonProperty("output")]
        [JsonConverter(typeof(OutputTypeConverter))]
        public IGenerationStyle Render { get; set; }

        /// <summary>
        /// The properties for this type. These can be both real and derived
        /// </summary>
        [JsonProperty("properties")]
        public List<Property> Properties { get; set; }

        /// <summary>
        /// The methods for this type. These can be both read and derived.
        /// </summary>
        [JsonProperty("methods")]
        public List<Method> Methods { get; set; }

        /// <summary>
        /// The events for this type. These can be both read and derived.
        /// </summary>
        [JsonProperty("events")]
        public List<Event> Events { get; set; }

        public TypeToProcess(string fullTypeName, IGenerationStyle render, List<Property> properties, List<Method> methods, List<Event> events)
        {
            FullTypeName = fullTypeName;
            Render = render;
            Properties = properties;
            Methods = methods;
            Events = events;
        }
    }
}