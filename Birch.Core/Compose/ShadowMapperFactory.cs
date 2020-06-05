using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Reflection;
using Birch.Components;
using Birch.Shadows;

namespace Birch.Compose
{
    /// <summary>
    /// Resolves <see cref="IShadowMapper"/> for specified <see cref="IPrimitive"/>.instances.
    /// </summary>
    public class ShadowMapperFactory:IEnumerable<KeyValuePair<Type,IShadowMapper>>
    {
        /// <summary>
        /// Our cache of previously resolved <see cref="IShadowMapper"/> instances.
        /// </summary>
        private readonly ConcurrentDictionary<Type,IShadowMapper> _shadowMapperCache = new ConcurrentDictionary<Type, IShadowMapper>();

        /// <summary>
        /// Add a <see cref="IShadowMapper"/> to our dictionary.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="shadowMapper"></param>
        /// <remarks>
        /// This is primary used for collection initialization</remarks>
        public void Add(Type type,IShadowMapper shadowMapper)
        {
            _shadowMapperCache[type] = shadowMapper;
        }

        /// <summary>
        /// Manually register the <see cref="IShadowMapper"/> for a specified <see cref="IPrimitive"/> type.
        /// </summary>
        /// <typeparam name="TItem"></typeparam>
        /// <param name="mapper"></param>
        public void Add<TItem>(IShadowMapper mapper) where TItem:IPrimitive
        {
            _shadowMapperCache[typeof(TItem)] = mapper;
        }

        /// <summary>
        /// Create an <see cref="IShadow"/> instance for a specified <see cref="IElement"/>
        /// </summary>
        /// <param name="context"></param>
        /// <param name="element"></param>
        /// <param name="update"></param>
        /// <returns></returns>
        /// <remarks>
        /// The creation of the shadow is transactional, the actual Item within the Shadow isn't assigned until the transactions are committed.
        /// The option to not perform an update is primarily for those situations in which a placeholder view/shadow is being created
        /// and it will be bound at a slightly later date.</remarks>
        public IShadow Create(IShadowContext context,IPrimitive element,bool update=true)
        {
            var mapper = GetShadowMapper(element);

            var shadow = mapper.CreateShadow(context, element);

            if (update)
            {
                mapper.UpdateShadow(context, shadow, null, element);
            }

            return shadow;
        }

        /// <summary>
        /// Update an existing <see cref="IShadow"/> from its current state to a new state.
        /// </summary>
        /// <param name="context"></param>
        /// <param name="shadow"></param>
        /// <param name="current"></param>
        /// <param name="next"></param>
        public void Update(IShadowContext context,IShadow shadow, IPrimitive current, IPrimitive next)
        {
            var viewHandler = GetShadowMapper(current ?? next);

            viewHandler.UpdateShadow(context,shadow,current,next);
        }

        /// <summary>
        /// A shadow instance is being removed, perform any logic prior to removal.
        /// </summary>
        /// <param name="context"></param>
        /// <param name="shadow"></param>
        /// <param name="current"></param>
        public void Remove(IShadowContext context, IShadow shadow, IPrimitive current)
        {
            var viewHandler = GetShadowMapper(current);

            viewHandler.RemoveShadow(context,shadow,current);
        }

        /// <summary>
        /// Resolve the <see cref="IShadowMapper"/> for a <see cref="IElement"/>
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        private IShadowMapper GetShadowMapper(IElement element)
        {
            if (element == null )
            {
                throw new ArgumentException($"An {nameof(element)} must be specified",nameof(element));
            }

            // Look to see if we have an existing handler, if so use it
            if (_shadowMapperCache.TryGetValue(element.GetType(), out var handler))
            {
                return handler;
            }

            // we don't have an existing handler...
            var attr = element.GetType().GetCustomAttribute<ShadowMapperAttribute>();

            if (attr == null)
            {
                throw new ArgumentException($"No {nameof(ShadowMapperAttribute)} for {element.GetType()}");
            }

            // Convention dictates that if this is a generic type, then we take the generics from the view component
            // and apply that...
            // e.g. if class is of form Control<TView> then handler must be of form Handler<TView>

            // Generally there are a few different types of handlers:
            // 1. Those that aren't generic
            // 2. For those that are generic, they either match the generic parameters the element has
            // 3. Those that don't have a matching number of generic parameters we attempt to match on name
            // 4. 

            if (attr.Handler.IsGenericType)
            {
                var ti = element.GetType().GetTypeInfo();

                var currentParameters = ti.GenericTypeArguments;

                var targetTypeArgument = attr.Handler.GetTypeInfo().GenericTypeParameters;

                var finalParameters = new Type[targetTypeArgument.Length];

                //TODO: we need to try and do something here but...
                if (currentParameters.Length != targetTypeArgument.Length)
                {
                    throw new NotImplementedException();
                    // hmm, slight issue...
                    for (var i = 0; i < targetTypeArgument.Length; i++)
                    {
                        if (targetTypeArgument[i].Name == "TControl")
                        {
                            finalParameters[i] = element.GetType();
                        }
                        else
                        {
                            for (var j = 0; j < currentParameters.Length; j++)
                            {
                                if (currentParameters[j].Name == targetTypeArgument[i].Name)
                                {
                                    finalParameters[i] = currentParameters[j];
                                    break;
                                }
                            }
                        }
                    }
                }
                else
                {
                    // the parameter count on the element is the same as the handler
                    // 
                    finalParameters = currentParameters;
                }

                // create the full type for the handler
                var actualGenericType = attr.Handler.MakeGenericType(finalParameters);

                // and now create the instance
                handler = (IShadowMapper) Activator.CreateInstance(actualGenericType);
            }

            else
            {
                handler = (IShadowMapper)Activator.CreateInstance(attr.Handler);
            }

            _shadowMapperCache[element.GetType()] = handler;

            return handler;
        }

        /// <summary>
        /// Enumerate the current <see cref="IShadowMapper"/> mappers
        /// </summary>
        /// <returns></returns>
        public IEnumerator<KeyValuePair<Type, IShadowMapper>> GetEnumerator()
        {
            return _shadowMapperCache.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}