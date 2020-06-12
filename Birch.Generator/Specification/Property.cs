using Newtonsoft.Json;

namespace Birch.Generator.Specification
{
    /// <summary>
    /// Represents a single property.
    /// </summary>
    public class Property
    {
        /// <summary>
        /// The name of the original property
        /// </summary>
        [JsonProperty("source")]
        public string Source { get; set; }

        /// <summary>
        /// Instead of using the reflected type for this property, use this instead.
        /// </summary>
        [JsonProperty("customType")]
        public string CustomType { get; set; }

        /// <summary>
        /// Get a custom template to use for the render of this property
        /// </summary>
        [JsonProperty("template")]
        public string Template { get; set; }

        /// <summary>
        /// Any additional notes.
        /// </summary>
        [JsonProperty("notes", DefaultValueHandling = DefaultValueHandling.Ignore,NullValueHandling = NullValueHandling.Ignore)]
        public string Notes { get; set; }

        /// <summary>
        /// A custom type comparer
        /// </summary>
        [JsonProperty("customComparer", DefaultValueHandling = DefaultValueHandling.Ignore,NullValueHandling = NullValueHandling.Ignore)]
        public string CustomComparer { get; set; }
    }
}