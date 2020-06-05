using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Birch.Reflection
{
    public static class TypeExtensions
    {
        /// <summary>
        /// Return the types name with any generics expanded.
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static string FriendlyName(this Type type)
        {
            if (type.IsGenericParameter)
            {
                return type.Name;
            }

            if (!type.IsGenericType)
            {
                return type.Name;
            }

            var builder = new StringBuilder();

            var name = type.Name;
            var index = name.IndexOf("`", StringComparison.Ordinal);

            builder.Append($"{name.Substring(0, index)}");
            builder.Append('<');
            builder.Append(string.Join(",",type.GetGenericArguments().Select(FriendlyName)));
            builder.Append('>');
            return builder.ToString();
        }

    }
}
