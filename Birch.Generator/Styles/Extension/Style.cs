using Birch.Generator.Specification;
using Newtonsoft.Json;

namespace Birch.Generator.Styles.Extension
{
    /// <summary>
    /// Specific specification for types whose generated code is mainly through extension methods.
    /// </summary>
    public class Style:IGenerationStyle
    {
        public const string Type = "Extension";
        /// <summary>
        /// Json key for the type of generation to occur. 
        /// </summary>
        public const string GenerationTypeKey = "generationType";

        /// <summary>
        /// The arguments for the extension method
        /// </summary>
        /// <remarks>
        /// There will be an assumption that arguments map directly
        /// to Attributes.
        /// </remarks>
        [JsonProperty("methodArguments")]
        public string[] MethodArguments { get; set; } = new string[0];

        /// <summary>
        /// Get the name of the extension method
        /// </summary>
        [JsonProperty("methodName")]
        public string MethodName { get; set; }

        /// <summary>
        /// Get the name of the template to be used.
        /// </summary>
        [JsonProperty("template")]
        public string TemplateName { get; set; }

        /// <summary>
        /// Get the type of the code to be generated
        /// </summary>
        [JsonProperty(GenerationTypeKey)]
        public string GenerationType => Type;
    }
}