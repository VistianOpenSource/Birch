using Birch.Generator.Generation;
using Newtonsoft.Json;

namespace Birch.Generator.Specification
{
    /// <summary>
    /// Specification of an implementation of <see cref="IModelFactory"/>
    /// </summary>
    public class CodeOutputType
    {
        /// <summary>
        /// Get the name to be associated with the code
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; }

        /// <summary>
        /// The name of the type
        /// </summary>
        [JsonProperty("type")]
        public string TypeName { get; }

        /// <summary>
        /// The assembly in which it is located
        /// </summary>
        [JsonProperty("assembly")]
        public string AssemblyName { get; }

        public CodeOutputType(string name, string assemblyName,string typeName)
        {
            Name = name;
            AssemblyName = assemblyName;
            TypeName = typeName;
        }

        /// <summary>
        /// For a specified type and name, create an associated <see cref="CodeOutputType"/>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="name"></param>
        /// <returns></returns>
        public static CodeOutputType Create<T>(string name)
        {
            return new CodeOutputType(name,typeof(T).Assembly.FullName,typeof(T).FullName);
        }
    }
}