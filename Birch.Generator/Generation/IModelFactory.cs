using Birch.Generator.Specification;
using ICSharpCode.Decompiler.TypeSystem;

namespace Birch.Generator.Generation
{
    /// <summary>
    /// Specification for the creation of a <see cref="IGeneratedTypeModel"/> from a specified type.
    /// </summary>
    public interface IModelFactory
    {
        IGeneratedTypeModel Create(TypeToProcess type, ITypeDefinition definition);
    }
}