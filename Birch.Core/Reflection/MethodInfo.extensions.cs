using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Birch.Reflection
{
    public static class MethodInfoExtensions
    {
        private static readonly char[] InvalidChars = new[] {'<', '>'};

        /// <summary>
        /// Determine if a <see cref="MethodInfo"/> is in-fact an anonymous method.
        /// </summary>
        /// <param name="method"></param>
        /// <returns></returns>
        /// <remarks>
        /// Derived from https://stackoverflow.com/questions/23228075/determine-if-methodinfo-represents-a-lambda-expression
        /// </remarks>
        public static bool IsAnonymous(this MethodInfo method)
        {
            return method.Name.Any(InvalidChars.Contains);
        }
    }
}
