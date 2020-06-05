using System;
using System.Collections.Generic;
using Birch.Generator.Specification;
using ICSharpCode.Decompiler.TypeSystem;

namespace Birch.Generator.Generation
{
    /// <summary>
    /// Generate the models to be used for code generation.
    /// </summary>
    public class ModelBuilder
    {
        private readonly TypeStore _typeStore;
        private readonly OutputTypesStore _outputTypeStore;


        public ModelBuilder(TypeStore typeStore, OutputTypesStore outputTypeStore)
        {
            _typeStore = typeStore;
            _outputTypeStore = outputTypeStore;
        }

        /// <summary>
        /// Create a List of <see cref="IGeneratedTypeModel"/> for a specified job.
        /// </summary>
        /// <returns></returns>
        public List<IGeneratedTypeModel> Create(Job job)
        {
            var models = new List<IGeneratedTypeModel>();
            // right then, we need to run each of the types within the specification 
            // and then process each one in turn
            foreach (var type in job.Types)
            {
                if (!_typeStore.TryGetValue(type.FullTypeName,out var definition))
                {
                    throw new ArgumentException($"Unable to resolve {type.FullTypeName} in the list of types");
                }

                models.Add(CreateModel(job,type,definition));
            }

            return models;
        }

        /// <summary>
        /// Produce the relevant <see cref="IGeneratedTypeModel"/> for a <see cref="TypeToProcess"/>
        /// </summary>
        /// <param name="job"></param>
        /// <param name="type"></param>
        /// <param name="definition"></param>
        /// <returns></returns>
        private IGeneratedTypeModel CreateModel(Job job,TypeToProcess type, ITypeDefinition definition)
        {
            var outputType = !string.IsNullOrEmpty(type.Render.GenerationType) ? type.Render.GenerationType: job.Configuration.DefaultOutputType;

            var factory = _outputTypeStore.GetFor(outputType);

            return factory.Create(type, definition);
        }
    }
}