using Newtonsoft.Json;

namespace Birch.Generator.Specification
{
    /// <summary>
    /// The specification of a single event.
    /// </summary>
    public class Event
    {
        /// <summary>
        /// The name of the original event
        /// </summary>
        [JsonProperty("source")]
        public string Source { get; set; }

        /// <summary>
        /// The name of the template to use
        /// </summary>
        [JsonProperty("template")]
        public string Template { get; set; }
    }
}