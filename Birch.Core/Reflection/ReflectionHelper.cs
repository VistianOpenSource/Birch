using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using Birch.Components;
using Birch.Diagnostics;
using Microsoft.Extensions.Logging;
using Attribute = Birch.Components.Attribute;

namespace Birch.Reflection
{
    /// <summary>
    /// Helper class providing simple access to the properties, calling and registration of events.
    /// </summary>
    /// <typeparam name="TItem"></typeparam>
    public static class Reflect<TItem>
    {
        public static ReflectionHelper<TItem> ReflectionHelpers { get; } = new ReflectionHelper<TItem>();
    }

    /// <summary>
    /// Root class containing a dictionary of types to their associated attribute.
    /// </summary>
    public abstract class ReflectionHelper
    {
        protected static readonly Dictionary<Type,Attribute> ExpressionCache = new Dictionary<Type, Attribute>();
    }
    /// <summary>
    /// Utility class to set attribute values based using expressions to resolve to attributes.
    /// </summary>
    /// <typeparam name="TView">The view we have reflected over</typeparam>
    public class ReflectionHelper<TView>:ReflectionHelper
    {
        private static readonly AttributeReflectionHelper<TView> AttributeReflectionHelper = AttributeReflectionHelper<TView>.Instance;

        /// <summary>
        /// Store the appropriate attributes details for a call with two parameter values
        /// </summary>
        /// <param name="attributes">The attributes which is to contain the appropriate value</param>
        /// <param name="methodCallExpression">The expression which defines the method to be invoked.</param>
        /// <param name="value1"></param>
        /// <param name="value2"></param>
        public void Call<TParam1,TParam2>(Attributes attributes, Expression<Action<TView, TParam1,TParam2>> methodCallExpression, TParam1 value1,TParam2 value2)
        {
            Attribute<object[]> attribute;

            static Type Key(Expression<Action<TView, TParam1,TParam2>> func)
            {
                return func.GetType();
            }

            // attempt to cache the operations to speed up subsequent properties lookup
            if (!ExpressionCache.TryGetValue(Key(methodCallExpression), out var baseAttribute))
            {
                var val = ParseExpression(methodCallExpression.Body);

                // should be a single value here...
                if (IsMethod(val))
                {
                    var methodName = ((MethodMemberDetails)val[0]).MethodInfo.Name;

                    var paramTypes = 
                    attribute = (Attribute<object[]>)AttributeReflectionHelper.GetAttributeForMethod(methodName,typeof(TParam1),typeof(TParam2));

                    ExpressionCache[Key(methodCallExpression)] = attribute;
                }
                else
                {
                    throw new InvalidOperationException($"Unsupported method {typeof(TParam1)},{typeof(TParam2)} {typeof(TView).FullName}.{methodCallExpression.Body}");
                }
            }
            else
            {
                attribute = (Attribute<object[]>) baseAttribute;
            }

            attributes.SetAttribute(attribute,new object[]{value1,value2});
        }

        /// <summary>
        /// Store the appropriate attributes details for a call with two parameter values
        /// </summary>
        /// <param name="attributes">The attributes which is to contain the appropriate value</param>
        /// <param name="methodCallExpression">The expression which defines the method to be invoked.</param>
        /// <param name="value1"></param>
        /// <param name="value2"></param>
        /// <param name="value3"></param>
        public void Call<TParam1,TParam2,TParam3>(Attributes attributes, Expression<Action<TView, TParam1,TParam2,TParam3>> methodCallExpression, TParam1 value1,TParam2 value2,TParam3 value3)
        {
            Attribute<object[]> attribute;

            static Type Key(Expression<Action<TView, TParam1,TParam2,TParam3>> func)
            {
                return func.GetType();
            }

            // attempt to cache the operations to speed up subsequent properties lookup
            if (!ExpressionCache.TryGetValue(Key(methodCallExpression), out var baseAttribute))
            {
                var val = ParseExpression(methodCallExpression.Body);

                // should be a single value here...
                if (IsMethod(val))
                {
                    var methodName = ((MethodMemberDetails)val[0]).MethodInfo.Name;

                    attribute = (Attribute<object[]>)AttributeReflectionHelper.GetAttributeForMethod(methodName,typeof(TParam1),typeof(TParam2),typeof(TParam3));

                    ExpressionCache[Key(methodCallExpression)] = attribute;
                }
                else
                {
                    throw new InvalidOperationException($"Unsupported method {typeof(TParam1)},{typeof(TParam2)} {typeof(TView).FullName}.{methodCallExpression.Body}");
                }
            }
            else
            {
                attribute = (Attribute<object[]>) baseAttribute;
            }

            attributes.SetAttribute(attribute,new object[]{value1,value2,value3});
        }

        /// <summary>
        /// Store the appropriate attributes details for a call with two parameter values
        /// </summary>
        /// <param name="attributes">The attributes which is to contain the appropriate value</param>
        /// <param name="methodCallExpression">The expression which defines the method to be invoked.</param>
        /// <param name="value1"></param>
        /// <param name="value2"></param>
        /// <param name="value3"></param>
        /// <param name="value4"></param>
        public void Call<TParam1,TParam2,TParam3,TParam4>(Attributes attributes, Expression<Action<TView, TParam1,TParam2,TParam3,TParam4>> methodCallExpression, TParam1 value1,TParam2 value2,TParam3 value3,TParam4 value4)
        {
            Attribute<object[]> attribute;

            static Type Key(Expression<Action<TView, TParam1,TParam2,TParam3,TParam4>> func)
            {
                return func.GetType();
            }

            // attempt to cache the operations to speed up subsequent properties lookup
            if (!ExpressionCache.TryGetValue(Key(methodCallExpression), out var baseAttribute))
            {
                var val = ParseExpression(methodCallExpression.Body);

                if (IsMethod(val))
                {
                    var methodName = ((MethodMemberDetails)val[0]).MethodInfo.Name;

                    attribute = (Attribute<object[]>)AttributeReflectionHelper.GetAttributeForMethod(methodName,typeof(TParam1),typeof(TParam2),typeof(TParam3),typeof(TParam4));

                    ExpressionCache[Key(methodCallExpression)] = attribute;
                }
                else
                {
                    throw new InvalidOperationException($"Unsupported method {typeof(TParam1)},{typeof(TParam2)} {typeof(TView).FullName}.{methodCallExpression.Body}");
                }
            }
            else
            {
                attribute = (Attribute<object[]>) baseAttribute;
            }

            attributes.SetAttribute(attribute,new object[]{value1,value2,value3,value4});
        }

        /// <summary>
        /// Store the appropriate attributes details for a call with two parameter values
        /// </summary>
        /// <param name="attributes">The attributes which is to contain the appropriate value</param>
        /// <param name="methodCallExpression">The expression which defines the method to be invoked.</param>
        /// <param name="value1"></param>
        /// <param name="value2"></param>
        /// <param name="value3"></param>
        /// <param name="value4"></param>
        /// <param name="value5"></param>
        public void Call<TParam1,TParam2,TParam3,TParam4,TParam5>(Attributes attributes, Expression<Action<TView, TParam1,TParam2,TParam3,TParam4,TParam5>> methodCallExpression, TParam1 value1,TParam2 value2,TParam3 value3,TParam4 value4,TParam5 value5)
        {
            Attribute<object[]> attribute;

            static Type Key(Expression<Action<TView, TParam1,TParam2,TParam3,TParam4,TParam5>> func)
            {
                return func.GetType();
            }

            // attempt to cache the operations to speed up subsequent properties lookup
            if (!ExpressionCache.TryGetValue(Key(methodCallExpression), out var baseAttribute))
            {
                var val =  ParseExpression(methodCallExpression.Body);

                // should be a single value here...
                if (IsMethod(val))
                {
                    var methodName = ((MethodMemberDetails)val[0]).MethodInfo.Name;

                    attribute = (Attribute<object[]>)AttributeReflectionHelper.GetAttributeForMethod(methodName,typeof(TParam1),typeof(TParam2),typeof(TParam3),typeof(TParam4),typeof(TParam5));

                    ExpressionCache[Key(methodCallExpression)] = attribute;
                }
                else
                {
                    throw new InvalidOperationException($"Unsupported method {typeof(TParam1)},{typeof(TParam2)} {typeof(TView).FullName}.{methodCallExpression.Body}");
                }
            }
            else
            {
                attribute = (Attribute<object[]>) baseAttribute;
            }

            attributes.SetAttribute(attribute,new object[]{value1,value2,value3,value4,value5});
        }

        /// <summary>
        /// Attempt to parse an expression into a list of <see cref="MemberDetails"/> instances.
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        private static List<MemberDetails> ParseExpression(Expression expression)
        {
            try
            {
                var val = ExpressionChainExtractor.Default.Decode(expression).ToList();

                return val;
            }
            catch (Exception exception)
            {
                Logging.Instance.LogError(exception,
                    $"Unable to parse expression:{typeof(TView).FullName}.{expression}");

                throw new InvalidOperationException($"Unable to parse expression:{typeof(TView).FullName}.{expression}",exception);
            }
        }

        /// <summary>
        /// Does a list of <see cref="MemberDetails"/> represent a method call ?
        /// </summary>
        /// <param name="members"></param>
        /// <returns></returns>
        private static bool IsMethod(IReadOnlyList<MemberDetails> members) => members.Count == 1 && members[0].GetType() == typeof(MethodMemberDetails);

        /// <summary>
        /// Store the appropriate attributes details for a call with a single parameter value
        /// </summary>
        /// <typeparam name="TParam"></typeparam>
        /// <param name="attributes">The attributes which is to contain the appropriate value</param>
        /// <param name="methodCallExpression">The expression which defines the method to be invoked.</param>
        /// <param name="value"></param>
        public void Call<TParam>(Attributes attributes, Expression<Action<TView, TParam>> methodCallExpression, TParam value)
        {
            Attribute<object[]> attribute;

            static Type Key(Expression<Action<TView, TParam>> func)
            {
                return func.GetType();
            }

            // attempt to cache the operations to speed up subsequent properties lookup
            if (!ExpressionCache.TryGetValue(Key(methodCallExpression), out var baseAttribute))
            {
                var val = ParseExpression(methodCallExpression.Body);

                // should be a single value here...
                if (IsMethod(val))
                {
                    var methodName = ((MethodMemberDetails)val[0]).MethodInfo.Name;

                    attribute = (Attribute<object[]>)AttributeReflectionHelper.GetAttributeForMethod(methodName,typeof(TParam));

                    ExpressionCache[Key(methodCallExpression)] = attribute;
                }
                else
                {
                    throw new InvalidOperationException($"Unsupported method {typeof(TParam)} {typeof(TView).FullName}.{methodCallExpression.Body}");
                }
            }
            else
            {
                attribute = (Attribute<object[]>) baseAttribute;
            }

            attributes.SetAttribute(attribute,new object[]{value});
        }

        /// <summary>
        /// Store the appropriate attributes details for a call with a single parameter value
        /// </summary>
        /// <param name="attributes">The attributes which is to contain the appropriate value</param>
        /// <param name="methodCallExpression">The expression which defines the method to be invoked.</param>
        public void Call(Attributes attributes, Expression<Action<TView>> methodCallExpression)
        {
            Attribute<object[]> attribute;

            static Type Key(Expression<Action<TView>> func)
            {
                return func.GetType();
            }

            // attempt to cache the operations to speed up subsequent properties lookup
            if (!ExpressionCache.TryGetValue(Key(methodCallExpression), out var baseAttribute))
            {
                var val = ParseExpression(methodCallExpression.Body);

                // should be a single value here...
                if (IsMethod(val))
                {
                    var methodName = ((MethodMemberDetails)val[0]).MethodInfo.Name;

                    attribute = (Attribute<object[]>)AttributeReflectionHelper.GetAttributeForMethod(methodName);

                    ExpressionCache[Key(methodCallExpression)] = attribute;
                }
                else
                {
                    throw new InvalidOperationException($"Unsupported method {typeof(TView).FullName}.{methodCallExpression.Body}");
                }
            }
            else
            {
                attribute = (Attribute<object[]>) baseAttribute;
            }

            attributes.SetAttribute(attribute,new object[]{});
        }


        /// <summary>
        /// Store the appropriate attribute details for the assignment of a properties value. 
        /// </summary>
        /// <typeparam name="TProp"></typeparam>
        /// <param name="attributes"></param>
        /// <param name="propertySetExpression"></param>
        /// <param name="value"></param>
        public void Set<TProp>(Attributes attributes,Expression<Func<TView, TProp>> propertySetExpression, TProp value)
        {
            Attribute<TProp> attribute;

            static Type Key(Expression<Func<TView, TProp>> func)
            {
                return func.GetType();
            }

            // attempt to cache the operations to speed up subsequent properties lookup
            if (!ExpressionCache.TryGetValue(Key(propertySetExpression), out var baseAttribute))
            {
                var val = ParseExpression(propertySetExpression.Body);

                // should be a single value here...
                if (val.Count == 1 && val[0].GetType() == typeof(PropertyMemberDetails))
                {
                    var propertyName = ((PropertyMemberDetails)val[0]).PropertyInfo.Name;

                    attribute = (Attribute<TProp>)AttributeReflectionHelper.GetAttributeForProperty(propertyName);

                    ExpressionCache[Key(propertySetExpression)] = attribute;
                }
                else
                {
                    throw new InvalidOperationException($"Unsupported property {typeof(TProp)} {typeof(TView).FullName}.{propertySetExpression.Body}");
                }
            }
            else
            {
                attribute = (Attribute<TProp>) baseAttribute;
            }

            attributes.SetAttribute(attribute,value);
        }

        /// <summary>
        /// Store the appropriate attributes details for a specified event with the action to be invoked.
        /// </summary>
        /// <typeparam name="TArgs"></typeparam>
        /// <param name="attributes"></param>
        /// <param name="eventNameExpression"></param>
        /// <param name="action"></param>
        public void Event<TArgs>(Attributes attributes, Expression<Func<TView, string>> eventNameExpression, Action<TArgs> action)
        {
            static Type Key(Expression<Func<TView, string>> func)
            {
                return func.GetType();
            }

            var key = Key(eventNameExpression);

            if (!ExpressionCache.TryGetValue(key, out var baseAttribute))
            {
                var eventName = (string)((eventNameExpression.Body as ConstantExpression).Value);

                var rawAttribute = AttributeReflectionHelper.GetAttributeForEvent(eventName);
                var attribute = (EventAttribute<Action<TArgs>>) rawAttribute;
                
                ExpressionCache[key] = attribute;
                baseAttribute = attribute;
            }

            attributes.SetAttribute((EventAttribute<Action<TArgs>>)baseAttribute,action);
        }

        /// <summary>
        /// Store the appropriate attributes details for a specified event with the action to be invoked.
        /// </summary>
        /// <param name="attributes"></param>
        /// <param name="eventNameExpression"></param>
        /// <param name="action"></param>
        public void Event(Attributes attributes, Expression<Func<TView, string>> eventNameExpression, Action action)
        {
            static Type Key(Expression<Func<TView, string>> func)
            {
                return func.GetType();
            }

            var key = Key(eventNameExpression);

            if (!ExpressionCache.TryGetValue(key, out var baseAttribute))
            {
                var eventName = (string)((eventNameExpression.Body as ConstantExpression).Value);

                var attribute = (EventAttribute<Action>)AttributeReflectionHelper.GetAttributeForEvent(eventName);;
                ExpressionCache[key] = attribute;
                baseAttribute = attribute;
            }

            attributes.SetAttribute((EventAttribute<Action>)baseAttribute,action);
        }
    }
}