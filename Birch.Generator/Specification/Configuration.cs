using System.Collections.Generic;
using Newtonsoft.Json;

namespace Birch.Generator.Specification
{
    /// <summary>
    /// The configuration component of a code generation specification.
    /// </summary>
    public class Configuration
    {
        /// <summary>
        /// The name of the namespace into which the generated code is to be placed.
        /// </summary>
        [JsonProperty("namespace")]
        public string Namespace { get; set; }

        /// <summary>
        /// The template used for the rendering of generated code
        /// </summary>
        [JsonProperty("rootTemplate")]
        public string RootTemplate { get; set; }

        /// <summary>
        /// Used in the absence of any output type being specified for a type.
        /// </summary>
        [JsonProperty("defaultOutputType")]
        public string DefaultOutputType { get; set; }

        /// <summary>
        /// The list of output types supported
        /// </summary>
        [JsonProperty("outputTypes")]
        public List<CodeOutputType> OutputTypes { get; set; }

        /// <summary>
        /// The list of templates
        /// </summary>
        [JsonProperty("templates")]
        public List<Template> Templates { get; set; }

        public Configuration(string ns, string rootTemplate,List<Template> templates,string defaultOutputType,List<CodeOutputType> outputTypes)
        {
            Namespace = ns;
            RootTemplate = rootTemplate;
            Templates = templates;
            DefaultOutputType = defaultOutputType;
            OutputTypes = outputTypes;
        }
    }
}