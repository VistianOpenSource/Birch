using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ICSharpCode.Decompiler.TypeSystem;

namespace Birch.Generator.Generation
{
    public static class ITypeExtensions
    {
        public static string FullName(this IType type)
        {
            if (type.TypeParameterCount == 0)
            {
                return type.FullName;
            }
            else
            {
                var builder = new StringBuilder();

                var name = type.FullName;

                builder.Append($"{name}");
                builder.Append('<');
                builder.Append(string.Join(",",type.TypeArguments.Select(t => t.FullName())));
                builder.Append('>');
                return builder.ToString();
            }
        }

        public static string ShortName(this IType type)
        {
            if (type.TypeParameterCount == 0)
            {
                return type.Name;
            }
            else
            {
                var builder = new StringBuilder();

                var name = type.Name;

                builder.Append($"{name}");
                builder.Append('<');
                builder.Append(string.Join(",",type.TypeArguments.Select(t => t.ShortName())));
                builder.Append('>');
                return builder.ToString();
            }
        }

    }
}
