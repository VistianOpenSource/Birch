using System;
using System.Collections.Generic;
using System.Linq;
using Birch.Generator.Generation;
using Birch.Generator.Specification;
using ICSharpCode.Decompiler.TypeSystem;

namespace Birch.Generator.Styles.Extension
{
    /// <summary>
    /// Responsible for the generation of the model for code generation.
    /// </summary>
    public class ModelFactory:IModelFactory
    {
        /// <summary>
        /// The default template names
        /// </summary>
        public static string DefaultTemplate = "extension";
        private const string DefaultMethodTemplate = "methodByReflection";
        private const string DefaultPropertyTemplate = "attributeByReflection";
        private const string DefaultEventTemplate = "eventByReflection";

        /// <summary>
        /// The maximum number of parameters for a method call which we will generate
        /// </summary>
        private const int MethodArgumentCountLimit = 5;


        public IGeneratedTypeModel Create(TypeToProcess type, ITypeDefinition definition)
        {
            var generation = (Style)type.Render;

            // need to create the model 1st
            // we need to build the arguments that have been provided, these should map 1- 1 between attribute properties

            var arguments = CreateArguments(generation.MethodArguments,definition);
            var attributeModels = CreateAttributes(type.Properties, definition);
            var eventModels = CreateEvents(type.Events, definition);
            var methodModels = CreateMethods(type.Methods, definition);

            var model = new Model(definition.Name, definition.FullName, Template(generation.TemplateName,DefaultTemplate), arguments, attributeModels,eventModels,methodModels);

            return model;
        }

        /// <summary>
        /// Create the arguments for the extension method call
        /// </summary>
        /// <param name="parameters"></param>
        /// <param name="typeDefinition"></param>
        /// <returns></returns>
        private static List<Argument> CreateArguments(IEnumerable<string> parameters,IType typeDefinition)
        {
            var arguments = new List<Argument>();
            foreach (var parameter in parameters)
            {
                // need to look up the 'type' of the attribute...
                // and remember the attribute could be something not necessarily at this level, but 'way' down...

                var parameterName = parameter;

                var nullable = parameterName[^1] == '?';

                if (nullable)
                {
                    parameterName = parameterName[..^1];
                }
                // convention - the argument name, is a property of the type, 
                var property = typeDefinition.GetProperties().FirstOrDefault(p => p.Name.Equals(parameterName,StringComparison.OrdinalIgnoreCase));

                if (property == null)
                {
                    var argument = new Argument($"<<Unknown Property in : {typeDefinition.FullName}>>", parameter);
                    arguments.Add(argument);
                }
                else
                {
                    var argument = new Argument(property.ReturnType.FullName, property.Name,nullable:nullable);
                    arguments.Add(argument);                    
                }
            }

            return arguments;
        }

        /// <summary>
        /// Create the associated <see cref="AttributePropertyModel"/> instances for an enumeration of <see cref="Property"/> instances.
        /// </summary>
        /// <param name="properties"></param>
        /// <param name="typeDefinition"></param>
        /// <returns></returns>
        private static List<AttributePropertyModel> CreateAttributes(IEnumerable<Property> properties,IType typeDefinition)
        {
            var attributeModels = new List<AttributePropertyModel>();

            foreach (var property in properties)
            {
                var propertyDefinition = typeDefinition.GetProperties().FirstOrDefault(p => p.Name == property.Source && p.DeclaringType.Equals(typeDefinition));

                if (propertyDefinition == null)
                {
                    throw new NullReferenceException($"Unknown property definition,property: {property.Source}");
                }
                else
                {
                    var shortTypeName = propertyDefinition.ReturnType.ShortName();
                    var fullTypeName = propertyDefinition.ReturnType.FullName();

                    // if specification has overridden the type to be used for the property
                    if (!string.IsNullOrEmpty(property.CustomType))
                    {
                        shortTypeName = property.CustomType;
                        fullTypeName = property.CustomType;
                    }

                    var obsoleteAttribute = propertyDefinition.GetAttribute(KnownAttribute.Obsolete);

                    var obsolete = (obsoleteAttribute != null) ? (string)obsoleteAttribute.FixedArguments[0].Value : string.Empty;
                    
                    var attrModel = new AttributePropertyModel(property.Source,shortTypeName, fullTypeName,propertyDefinition.DeclaringTypeDefinition.FullName,Template(property.Template,DefaultPropertyTemplate),property.Notes,obsolete,property.CustomComparer);

                    attributeModels.Add(attrModel);
                }
            }

            return attributeModels;
        }

        /// <summary>
        /// Create the <see cref="AttributeEventModel"/> instances for a specified enumeration of <see cref="Event"/> instances.
        /// </summary>
        /// <param name="events"></param>
        /// <param name="typeDefinition"></param>
        /// <returns></returns>
        private static List<AttributeEventModel> CreateEvents(IEnumerable<Event> events,IType typeDefinition)
        {
            var eventModels = new List<AttributeEventModel>();

            foreach (var @event in events)
            {
                var eventDefinition = typeDefinition.GetEvents(p => p.Name == @event.Source).FirstOrDefault();

                if (eventDefinition == null)
                {
                    throw new NullReferenceException($"Unknown property definition,property: {@event.Source}");
                }
                else
                {
                    string fullTypeName;
                    string shortTypeName;

                    // if no type parameters, then must (!) be of the form: System.EventHandler
                    if (eventDefinition.ReturnType.TypeParameterCount == 0)
                    {
                        fullTypeName = string.Empty;
                        shortTypeName = string.Empty;
                    }
                    else
                    {
                        // must have a type parameter, so of form (!) System.EventHandler<TArgs>
                        fullTypeName = eventDefinition.ReturnType.TypeArguments[0].FullName();//FullName;
                        shortTypeName = eventDefinition.ReturnType.TypeArguments[0].ShortName();//Name;
                    }

                    var obsoleteAttribute = eventDefinition.GetAttribute(KnownAttribute.Obsolete);

                    var obsolete = (obsoleteAttribute != null) ? (string)obsoleteAttribute.FixedArguments[0].Value : string.Empty;


                    var eventModel =
                        new AttributeEventModel(@event.Source, eventDefinition.DeclaringType.FullName, fullTypeName, shortTypeName,Template(@event.Template,DefaultEventTemplate),obsolete);

                    eventModels.Add(eventModel);
                }
            }

            return eventModels;
        }



        /// <summary>
        /// Create the <see cref="AttributeMethodModel"/> instances for an enumeration of <see cref="Method"/> instances
        /// </summary>
        /// <param name="methods"></param>
        /// <param name="typeDefinition"></param>
        /// <returns></returns>
        private static List<AttributeMethodModel> CreateMethods(IEnumerable<Method> methods,IType typeDefinition)
        {
            var methodModels = new List<AttributeMethodModel>();

            foreach (var method in methods)
            {
                var methodDefinitions = typeDefinition.GetMethods(p => p.Name == method.Source).Where(m => m.Accessibility == Accessibility.Public && m.DeclaringType.Equals(typeDefinition)).ToList();

                // validate that we do in fact have some methods...
                if (methodDefinitions?.Count == 0)
                {
                    throw new NullReferenceException($"Unknown method definition,method: {method.Source}");
                }

                // this allows for more than one method of the same name...
                foreach (var methodDefinition in methodDefinitions)
                {
                    var parameters = methodDefinition.Parameters;

                    if (parameters.Count < MethodArgumentCountLimit)
                    {

                        var arguments = parameters.Select(p => new Argument(GetFullType(p.Type), p.Name)).ToList();
                        // if no type parameters, then must (!) be of the form: System.EventHandler

                        var obsoleteAttribute = methodDefinition.GetAttribute(KnownAttribute.Obsolete);

                        var obsolete = (obsoleteAttribute != null) ? (string)obsoleteAttribute.FixedArguments[0].Value : string.Empty;

                        var model =
                            new AttributeMethodModel(method.Source, methodDefinition.DeclaringType.FullName, arguments,Template(method.Template, DefaultMethodTemplate),obsolete);

                        methodModels.Add(model);
                    }
                }
            }

            return methodModels;
        }

        public static string Template(string template, string defaultTemplate)
        {
            return string.IsNullOrEmpty(template) ? defaultTemplate : template;
        }

        /// <summary>
        /// Given an <see cref="IType"/> return a fully qualified string for the type, allowing for generics.
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        private static string GetFullType(IType type)
        {
            if (type.TypeParameterCount == 0)
            {
                return type.FullName;
            }
            else
            {
                // right then, we need to generic a generic form

                return type.FullName + "<" + string.Join(",", type.TypeArguments.Select(GetFullType)) + ">";
            }
        }
    }
}