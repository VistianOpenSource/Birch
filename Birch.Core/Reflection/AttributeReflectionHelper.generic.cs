using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text.RegularExpressions;
using Birch.Collections;
using Birch.Components;
using Birch.Diagnostics;
using Microsoft.Extensions.Logging;
using Attribute = Birch.Components.Attribute;

namespace Birch.Reflection
{
    /// <summary>
    /// Create Attributes along with appropriate mappings for a specified class.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class AttributeReflectionHelper<T>
    {
        // maps a property name to an attribute
        private readonly Dictionary<string, Attribute> _propertyAttributeMap = new Dictionary<string, Attribute>();

        static AttributeReflectionHelper()
        {
            Instance = new AttributeReflectionHelper<T>();
        }

        /// <summary>
        /// Get the static, single instance.
        /// </summary>
        public static AttributeReflectionHelper<T> Instance { get; }

        private AttributeReflectionHelper()
        {
            // if not reflecting on demand, do all of them now...
            if (!AttributeReflectionHelper.ReflectOnDemand)
            {
                ProcessMembers();
            }
            
            if (AttributeReflectionHelper.IsLoggingEnabled.Value)
            {
                Logging.Instance.LogInformation("{When} Reflected attributes for:{type} total:{total}",DateTimeOffset.Now.Ticks,typeof(T).Name,_propertyAttributeMap.Count);
            }
        }

        /// <summary>
        /// Enumerate the properties, fields, events and methods of a type and create the attributes associated with them.
        /// </summary>
        private void ProcessMembers()
        {
            try
            {
                var typeInfo = typeof(T).GetTypeInfo();

                var properties = typeInfo.GetProperties();

                ProcessProperties(properties);

                var fields = typeInfo.GetFields();
                ProcessFields(fields);

                var events = typeInfo.GetEvents();

                ProcessEvents(events);

                var methods = typeof(T).GetMethods(BindingFlags.Public | BindingFlags.Instance);

                ProcessMethods(methods);

            }
            catch (Exception exception)
            {
               Logging.Instance.LogError(exception, "Reflection processing for type:{type} failed", typeof(T).FullName);
               throw;
            }
        }

        /// <summary>
        /// For each field attempt to create an attribute for them.
        /// </summary>
        /// <param name="fields"></param>
        private static void ProcessFields(IEnumerable<FieldInfo> fields)
        {
            foreach (var field in fields)
            {
                if ((field.Attributes & FieldAttributes.Public) != 0 &&
                    (field.Attributes & FieldAttributes.Static) == 0 &&
                    (field.Attributes & FieldAttributes.SpecialName) == 0)
                {
                    Logging.Instance.LogWarning("Field {field} has not been mapped to an attribute, but should be.",
                        field);
                }
            }
        }

        /// <summary>
        /// For each public, non static method, create an attribute.
        /// </summary>
        /// <param name="methods"></param>
        /// <param name="name"></param>
        private void ProcessMethods(IEnumerable<MethodInfo> methods,string name=default)
        {
            if (!string.IsNullOrEmpty(name))
            {
                methods = methods.Where(m => m.Name == name);
            }

            static IAttributeMapper CreateForDeclaringType(MemberInfo method)
            {
                var rootType = typeof(MethodOperation<>);
                var genType = rootType.MakeGenericType(method.DeclaringType);

                return (IAttributeMapper) Activator.CreateInstance(genType, method);
            }

            // now then, for those methods which we could invoke, lets look to try and setup an attribute for them...
            foreach (var method in methods)
            {
                if ((method.Attributes & MethodAttributes.Public) != 0 &&
                    (method.Attributes & MethodAttributes.Static) == 0 &&
                    (method.Attributes & MethodAttributes.SpecialName) == 0
                )
                {
                    var attributeName = FullName(method);

                    // All attributes for a method call are an array of objects
                    var attribute = Attribute.Register(attributeName, false, ArrayComparer<object>.Default);

                    // the attribute type needs to be the declaring type, bugger...

                    var mapper = CreateForDeclaringType(method);

                    AttributeMapperStore.Default.Register(attribute, mapper);

                    _propertyAttributeMap[MethodHelper.Name(method)] = attribute;
                }
            }
        }

        /// <summary>
        /// Get the attribute for a specified method name with type parameters
        /// </summary>
        /// <param name="name"></param>
        /// <param name="paramTypes"></param>
        /// <returns></returns>
        public Attribute GetAttributeForMethod(string name, params Type[] paramTypes)
        {
            var fullName = MethodHelper.Name(name, paramTypes);

            var attribute = _propertyAttributeMap.GetValueOrDefault(fullName);

            if (attribute == null && AttributeReflectionHelper.ReflectOnDemand)
            {
                // need to setup the methods which match this name
                ProcessMethods(typeof(T).GetMethods(BindingFlags.Public | BindingFlags.Instance),name);

                attribute = _propertyAttributeMap.GetValueOrDefault(fullName);
            }

            return attribute;
        }

        /// <summary>
        /// Get the attribute for a specified property name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public Attribute GetAttributeForProperty(string name)
        {
            var fullName = PropertyHelper.Name(name);
            var attribute= _propertyAttributeMap.GetValueOrDefault(fullName);

            if (attribute == null && AttributeReflectionHelper.ReflectOnDemand)
            {
                // need to setup the properties which match this name
                ProcessProperties(typeof(T).GetTypeInfo().GetProperties(), name);
                attribute= _propertyAttributeMap.GetValueOrDefault(fullName);
            }

            return attribute;
        }

        /// <summary>
        /// Get the attribute for a specified event name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public Attribute GetAttributeForEvent(string name)
        {
            var fullName = EventHelper.Name(name);
            var attribute = _propertyAttributeMap.GetValueOrDefault(fullName);

            if (attribute == null && AttributeReflectionHelper.ReflectOnDemand)
            {
                // need to setup the events which match this name
                ProcessEvents(typeof(T).GetTypeInfo().GetEvents(), name);
                attribute = _propertyAttributeMap.GetValueOrDefault(fullName);
            }

            return attribute;
        }


        /// <summary>
        /// Process each property and, where appropriate create a <see cref="IAttributeMapper"/> for it
        /// </summary>
        /// <param name="properties"></param>
        /// <param name="name"></param>
        private void ProcessProperties(IEnumerable<PropertyInfo> properties,string name=default)
        {
            var readWriteProperties = string.IsNullOrEmpty(name) ? properties.Where(p => p.CanWrite && p.CanRead) : properties.Where(p => p.CanWrite && p.CanRead && p.Name == name);
            
            static IAttributeMapper CreateForDerivedType(MemberInfo property)
            {
                var rootType = typeof(PropertyOperation<,>);
                var genType = rootType.MakeGenericType(typeof(object), property.DeclaringType);

                return (IAttributeMapper) Activator.CreateInstance(genType, property);
            }

            foreach (var property in readWriteProperties)
            {
                // we need to register a property for this...

                var attributeName = FullName(property);

                var propertyType = property.PropertyType;

                // now need to register the attribute, with its name
                var attribute = Attribute.Register(attributeName, propertyType);

                var mapper = CreateForDerivedType(property);

                AttributeMapperStore.Default.Register(attribute, mapper);

                _propertyAttributeMap[PropertyHelper.Name(property)] = attribute;
            }
        }

        /// <summary>
        /// Run all of the available events and look to use those...
        /// </summary>
        /// <param name="events"></param>
        /// <param name="name"></param>
        private void ProcessEvents(IEnumerable<EventInfo> events,string name=default)
        {
            if (!string.IsNullOrEmpty(name))
            {
                events = events.Where(e => e.Name == name);
            }
 
            foreach (var @event in events)
            {
                var eventHandlerType = @event.EventHandlerType;

                Type actionType;
                IAttributeMapper mapper;

                var declaringType = @event.DeclaringType;

                Attribute attribute;

                var attributeName = FullName(@event);

                // Two different ways of dealing with events
                // 1. If its a generic type then its going to be a call with a parameter
                // 2. Otherwise its just a straight forward action.
                if (eventHandlerType.IsGenericType)
                {
                    var eventParamType = eventHandlerType.GenericTypeArguments[0];

                    actionType = typeof(Action<>).MakeGenericType(eventParamType);

                    var fullType = typeof(EventOperation<,>).MakeGenericType(eventParamType, declaringType);

                    mapper = (IAttributeMapper) Activator.CreateInstance(fullType, @event);

                    attribute = Attribute.RegisterEvent(attributeName, actionType);
                }

                else
                {
                    actionType = typeof(Action);

                    var fulType = typeof(EventOperation<>).MakeGenericType(declaringType);

                    mapper = (IAttributeMapper) Activator.CreateInstance(fulType, @event);

                    attribute = Attribute.RegisterEvent(attributeName, actionType);
                }
               

                AttributeMapperStore.Default.Register(attribute, mapper);

                _propertyAttributeMap[EventHelper.Name(@event)] = attribute;
            }
        }


        /// <summary>
        /// For a specified member, determine the full name used to enable to associated attribute to be resolved.
        /// </summary>
        /// <param name="member"></param>
        /// <returns></returns>
        public static string FullName(MemberInfo member)
        {
            // use the declaring type to associate the attribute with the type in which it is declared
            // thus meaning we end up reducing the number of attributes we have overall if a 
            // lot of reflection is used
            string name;

            switch (member.MemberType)
            {
                case MemberTypes.Method:
                    name = MethodHelper.Name((MethodInfo) member);
                    break;

                case MemberTypes.Event:
                    name = EventHelper.Name((EventInfo) member);
                    break;

                case MemberTypes.Property:
                    name = PropertyHelper.Name((PropertyInfo) member);
                    break;

                default:
                    Logging.Instance.LogError("Unhandled member type {memberType} for {memberName}", member.MemberType,
                        member.Name);

                    throw new ArgumentException($"Unhandled member type {member.MemberType} for {member.Name}");
            }

            return Attribute.Name(member.DeclaringType, name);
        }

        internal static class MethodHelper
        {
            public static string Name(MethodInfo method)
            {
                var paramTypes = method.GetParameters().Select(p => p.ParameterType);

                return Name(method.Name, paramTypes);
            }

            public static string Name(string name, IEnumerable<Type> paramTypes)
            {
                var fullName = $"M_{name}_{FormattedTypes(paramTypes)}";
                return fullName;
            }

            /// <summary>
            /// Format an enumeration of types to a string separated by _
            /// </summary>
            /// <param name="paramTypes"></param>
            /// <returns></returns>
            private static string FormattedTypes(IEnumerable<Type> paramTypes) =>string.Join('_', paramTypes.Select(pt => pt.Name));

        }

        internal static class PropertyHelper
        {
            /// <summary>
            /// Construct a property name.
            /// </summary>
            /// <param name="property"></param>
            /// <returns></returns>
            public static string Name(PropertyInfo property) => Name(property.Name);

            public static string Name(string propertyName) => $"P_{propertyName}";
        }

        internal static class EventHelper
        {
            public static string Name(EventInfo @event) => Name(@event.Name);

            public static string Name(string eventName) => $"E_{eventName}";
        }

    }
}