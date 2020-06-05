using Newtonsoft.Json;

namespace Birch.Generator.Specification
{
    /// <summary>
    /// Specification of a method for which code is to be generated.
    /// </summary>
    public class Method
    {
        /// <summary>
        /// The name of the original method
        /// </summary>
        [JsonProperty("source")]
        public string Source { get; set; }

        /// <summary>
        /// The template name to use for the render of this method
        /// </summary>
        [JsonProperty("template")]
        public string Template { get; set; }
    }
}