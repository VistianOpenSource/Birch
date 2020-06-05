using System;
using System.Collections.Generic;
using Birch.Diagnostics;
using Microsoft.Extensions.Logging;

namespace Birch.Components
{
    /// <summary>
    /// Deep attribute <see cref="IEqualityComparer{T}"/> comparer.
    /// </summary>
    public sealed class AttributeDeepEqualityComparer : AttributeEqualityComparer
    {
        public static AttributeDeepEqualityComparer Default = new AttributeDeepEqualityComparer();

        public AttributeDeepEqualityComparer() : base(false)
        {
        }
    }
}