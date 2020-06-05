using System;
using System.Collections.Generic;
using Birch.Generator.Properties;
using Birch.Generator.Specification;

namespace Birch.Generator.Generation
{
    /// <summary>
    /// Store for <see cref="IModelFactory"/> instances indexed by their name.
    /// </summary>
    public class OutputTypesStore
    {
        private readonly Dictionary<string, IModelFactory> _factories;

        private OutputTypesStore(Dictionary<string, IModelFactory> factories)
        {
            _factories = factories;
        }

        /// <summary>
        /// Get the <see cref="IModelFactory"/> for a specified name.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public IModelFactory GetFor(string name)
        {
            if (!_factories.TryGetValue(name, out var factory))
            {
                throw new ArgumentException(string.Format(Resources.NoRegisteredIModelFactoryInstance, name), nameof(factory));
            }
            return factory;
        }

        /// <summary>
        /// Create a <see cref="OutputTypesStore"/> from a specified set of <see cref="CodeOutputType"/>
        /// </summary>
        /// <param name="codeOutputTypes"></param>
        /// <returns></returns>
        public static OutputTypesStore Create(List<CodeOutputType> codeOutputTypes)
        {
            var factories = new Dictionary<string, IModelFactory>();

            foreach (var codeOutputType in codeOutputTypes)
            {
                var modelFactory = (IModelFactory)Activator.CreateInstance(codeOutputType.AssemblyName, codeOutputType.TypeName).Unwrap();
                factories[codeOutputType.Name] = modelFactory;
            }
            return new OutputTypesStore(factories);
        }
    }
}
