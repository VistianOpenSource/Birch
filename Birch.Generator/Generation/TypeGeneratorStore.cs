using System;
using System.Collections.Generic;
using Birch.Generator.Specification;

namespace Birch.Generator.Generation
{
    /// <summary>
    /// For each <see cref="TypeToProcess"/> instance, the type of generation needs to be specified.
    /// This store holds all of the defined <see cref="IGenerationStyle"/> factories.
    /// </summary>
    public class TypeGeneratorStore
    {
        private readonly Dictionary<string,Func<IGenerationStyle>> _factories = new Dictionary<string, Func<IGenerationStyle>>();

        public static TypeGeneratorStore Instance { get; } = new TypeGeneratorStore();

        /// <summary>
        /// For a specified key register a <see cref="Func{TResult}"/> which creates the associated <see cref="IGenerationStyle"/>
        /// </summary>
        /// <param name="key"></param>
        /// <param name="generationStyleFactory"></param>
        public void Register(string key, Func<IGenerationStyle> generationStyleFactory)
        {
            _factories[key] = generationStyleFactory;
        }

        /// <summary>
        /// For a specified key, create the relevant <see cref="IGenerationStyle"/> instance.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public IGenerationStyle Create(string key)
        {
            if (!_factories.TryGetValue(key, out var factory))
            {
                throw new ArgumentException($"No Matching {nameof(IGenerationStyle)} factory for key:{key}",nameof(key));
            }

            return factory();
        }
    }
}
