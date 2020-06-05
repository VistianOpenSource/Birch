using System.Collections.Generic;
using ICSharpCode.Decompiler;
using ICSharpCode.Decompiler.CSharp;
using ICSharpCode.Decompiler.TypeSystem;

namespace Birch.Generator.Generation
{
    /// <summary>
    /// Contains all of the types available for code generation.
    /// </summary>
    public class TypeStore
    {
        /// <summary>
        /// ALl of the <see cref="ITypeDefinition"/> indexed by their full type name.
        /// </summary>
        private readonly Dictionary<string,ITypeDefinition> _definitions = new Dictionary<string, ITypeDefinition>();

        /// <summary>
        /// For a specified path to an assembly, read all of the defined types.
        /// </summary>
        /// <param name="path"></param>
        public void Load(string path)
        {
            var settings = new DecompilerSettings {ThrowOnAssemblyResolveErrors = false};

            var types2 = new CSharpDecompiler(path,settings);

            var definitions = types2.TypeSystem.MainModule.TypeDefinitions;

            foreach (var definition in definitions)
            {
                _definitions[definition.FullName] = definition;
            }
        }

        /// <summary>
        /// Try and read the <see cref="ITypeDefinition"/> for a specified, full type name.
        /// </summary>
        /// <param name="fullName"></param>
        /// <param name="typeDefinition"></param>
        /// <returns></returns>
        public bool TryGetValue(string fullName, out ITypeDefinition typeDefinition)
        {
            return _definitions.TryGetValue(fullName, out typeDefinition);
        }

        /// <summary>
        /// Enumerate all of the types held.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<ITypeDefinition> GetTypes()
        {
            return _definitions.Values;
        }
    }
}
