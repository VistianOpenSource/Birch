using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using Birch.Generator.Generation;
using Birch.Generator.Styles.Extension;
using ICSharpCode.Decompiler.IL;
using ICSharpCode.Decompiler.TypeSystem;

namespace Birch.Generator.Specification
{
    /// <summary>
    /// Generate a standard template specification which can then be serialized for population.
    /// </summary>
    public class Generator
    {
        /// <summary>
        /// Our main template file from which all other templates are invoked 
        /// </summary>
        private const string RootTemplateName = "main";
        /// <summary>
        /// The file extension for the handle bar templates.
        /// </summary>
        private const string TemplateExtension = "hbs";

        private readonly string _rootDir;

        public Generator(string rootDir)
        {
            _rootDir = rootDir;
        }

        public Job Generate(TypeStore typeStore,Func<ITypeDefinition,bool> includeType=default,Func<IMethod,bool> includeMethod=default,string templateStyles=default,TemplateExportStyle embedTemplatesExport=TemplateExportStyle.File)
        {
            //
            const string voidTypeName = "System.Void";
            const string enumerableTypeName = "System.Collections.IEnumerable";
            const string genericListTypeName = "System.Collections.Generic.IList";
            const string equatableTypeName = "System.IEquatable";

            includeType ??= _ => true;
            includeMethod ??= _ => true;

            var typesToProcess = new List<TypeToProcess>();

            // Iterate through the public types
            foreach (var type in typeStore.GetTypes().Where(t => t.Accessibility == Accessibility.Public && // only pull in public items
                                                                 t.Kind == TypeKind.Class &&                // which are classes
                                                                 !t.IsStatic &&                             // and aren't static
                                                                 t.TypeParameters.Count == 0                // and aren't generics
                                                                 && includeType(t)))                        // and matches with custom additional properties
            {
                // now pull in those public properties for which there is a getter AND a setter and it isn't static
                var properties = type.Properties.Where(property => property.Accessibility == Accessibility.Public && property.CanGet && property.CanSet && !property.IsStatic 
                                                                   && property.DeclaringType.Equals(type)).
                    Select(property =>
                        {
                            var propertyType = property.ReturnType;

                            var baseTypes = propertyType.GetAllBaseTypeDefinitions();
                            var isCollection = baseTypes.Any(bt => bt.FullName == genericListTypeName) || propertyType.ReflectionName == enumerableTypeName;
                        
                            var notes = new StringBuilder();

                            if (isCollection)
                            {
                                notes.AppendLine($"Collection.");
                            }

                            // if this is a reference type, lets check to see if we have an IEquatable implementation 
                            if ((property.ReturnType.IsReferenceType??false) && !baseTypes.Any(bt => bt.FullName == equatableTypeName))
                            {
                                notes.Append($"{property.ReturnType.FullName} doesn't have an implementation of IEquatable, use a field or a static to hold its value to reduce updates.");
                            }

                            var prop = new Property() {Source = property.Name};

                            if (notes.Length > 0)
                            {
                                prop.Notes = notes.ToString();
                            }

                            return prop;
                        }
                    ).ToList();

                // get those public void methods which aren't constructors, destructors, aren't static, aren't operations and aren't generic and have less than 5 parameters
                var methods = type.Methods
                    .Where(method =>
                        !method.IsConstructor && !method.IsDestructor && method.HasBody && !method.IsStatic && !method.IsOperator && method.TypeParameters.Count == 0 && 
                        method.Accessibility == Accessibility.Public && method.ReturnType.FullName==voidTypeName && method.DeclaringType.Equals(type) && includeMethod(method)).
                    Select(method => method.Name).
                    Distinct().
                    Select(methodName => new Method() {Source = methodName}).
                    OrderBy(m => m.Source).
                    ToList();

                // and finally, those public events which aren't static.
                var events = type.Events.Where(e => e.Accessibility == Accessibility.Public && !e.IsStatic && e.DeclaringType.Equals(type)).Select(e => new Event() {Source = e.Name}).ToList();

                var typeToProcess = new TypeToProcess(type.FullName,new Style(){MethodName = type.Name}, properties,methods,events);

                typesToProcess.Add(typeToProcess);
            }

            // if template style specified, load up the templates
            var templates = string.IsNullOrEmpty(templateStyles) ? new List<Template> (): ResourceTemplateLoader.ReadFor(templateStyles);

            var generation = new Configuration("Enter your namespace here", RootTemplateName, templates
                    , Style.Type,
                new List<CodeOutputType>()
                {
                    CodeOutputType.Create<Styles.Extension.ModelFactory>(Styles.Extension.Style.Type)
                });

            var generatedRoot = new Job(typesToProcess,generation);

            return generatedRoot;
        }


    }
}