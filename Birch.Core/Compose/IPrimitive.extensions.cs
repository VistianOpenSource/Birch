using System;
using System.Collections.Generic;
using System.Text;
using Birch.Components;

namespace Birch.Compose
{
    public static partial class IPrimitiveExtensions
    {
        /// <summary>
        /// Given a <see cref="IPrimitive"/> return a unique string identifying the target
        /// that this is.
        /// </summary>
        /// <param name="primitive"></param>
        /// <returns></returns>
        /// <remarks>
        /// This is typically a composite of the type of the <see cref="IPrimitive"/> AND what it was
        /// generated from e.g. a certain type of container.</remarks>
        public static string TargetKey(this IPrimitive primitive)
        {
            return primitive.GetType().FullName;
        }
    }
}
