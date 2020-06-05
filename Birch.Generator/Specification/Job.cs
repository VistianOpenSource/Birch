using System.Collections.Generic;
using Newtonsoft.Json;

namespace Birch.Generator.Specification
{
    /// <summary>
    /// The specification of how the code generation is to be performed.
    /// </summary>
    public class Job
    {
        /// <summary>
        /// The rules and templates around generation
        /// </summary>
        [JsonProperty("configuration")]
        public Configuration Configuration { get; }

        /// <summary>
        /// The list of types we are to generate
        /// </summary>
        [JsonProperty("types")]
        public List<TypeToProcess> Types { get; set; }

        public Job(List<TypeToProcess> types,Configuration configuration)
        {
            Types = types;
            Configuration = configuration;
        }
    }
}