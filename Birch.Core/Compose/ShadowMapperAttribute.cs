using System;
using System.Diagnostics;
using System.Net.Mime;
using Birch.Diagnostics;
using Microsoft.Extensions.Logging;

namespace Birch.Compose
{
    /// <summary>
    /// Attribute used to decorate classes that provide <see cref="IShadowMapper"/> implementations.
    /// </summary>
    /// <remarks>
    /// Debug builds will validate that the specified type does implement <see cref="IShadowMapper"/></remarks>
    public class ShadowMapperAttribute : Attribute
    {
        public Type Handler { get; }

        public ShadowMapperAttribute(Type handler)
        {
            ValidateIShadowMapper(handler);
            Handler = handler;
        }

        /// <summary>
        /// Verify that the type does implement <see cref="IShadowMapper"/>
        /// </summary>
        /// <param name="type"></param>
        [Conditional("DEBUG")]
        private static void ValidateIShadowMapper(Type type)
        {
            if (!typeof(IShadowMapper).IsAssignableFrom(type))
            {
                Logging.Instance.LogError("Type {typeName} has been used in an {attribute} but doesn't implement required interfaces",type.FullName);
                throw new ArgumentException($"Type {type.FullName} doesn't implement {nameof(IShadowMapper)}");
            }
        }
    }
}