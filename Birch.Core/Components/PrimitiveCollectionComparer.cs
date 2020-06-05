using System;
using System.Collections.Generic;
using System.Text;
using Birch.Collections;

namespace Birch.Components
{
    public sealed class PrimitiveCollectionComparer
    {
        /// <summary>
        /// Get the default <see cref="ICollectionComparer{IPrimitive}"/> used when not specifically specified for certain <see cref="IPrimitive"/> implementations.
        /// </summary>
        public static ICollectionComparer<IPrimitive> Default { get; private set; } = new MyerComparer<IPrimitive>();

        /// <summary>
        /// Specify the default <see cref="ICollectionComparer{IPrimitive}"/> to be used.
        /// </summary>
        /// <param name="collectionComparer"></param>
        public static void SetDefault(ICollectionComparer<IPrimitive> collectionComparer) => Default = collectionComparer;
    }
}
