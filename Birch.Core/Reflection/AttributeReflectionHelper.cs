using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Birch.Components;
using Birch.Diagnostics;
using Attribute = System.Attribute;

namespace Birch.Reflection
{
    public class AttributeReflectionHelper
    {
        /// <summary>
        /// Resolve the associated attribute given an expression which should reference to the attribute.
        /// </summary>
        /// <typeparam name="TControl"></typeparam>
        /// <typeparam name="TType"></typeparam>
        /// <param name="expression"></param>
        /// <param name="equalityComparer"></param>
        /// <returns></returns>
        public static Attribute<TType> ResolveFor<TControl, TType>(Expression<Func<TControl, TType>> expression,IEqualityComparer<TType> equalityComparer=default)
        {
            var propertyExpression = ExpressionChainExtractor.Default.Decode(expression.Body).ToArray();

            var attribute = Components.Attribute.Register(AttributeReflectionHelper<TControl>.FullName((propertyExpression[0] as PropertyMemberDetails).PropertyInfo),equalityComparer:equalityComparer);

            return attribute;
        }

        /// <summary>
        /// Is logging enabled ?
        /// </summary>
        public static readonly bool IsLoggingEnabled = LoggingRules.For(Categories.Reflection).Any;


        /// <summary>
        /// Get or set whether to perform reflection on demand or to reflect all of the properties, methods and events when required.
        /// </summary>
        public static bool ReflectOnDemand { get; set; } = false;
    }
}
