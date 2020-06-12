using System;
using System.CommandLine;
using System.CommandLine.Invocation;
using System.IO;
using System.Threading.Tasks;
using Birch.Generator.Generation;
using Birch.Generator.Properties;
using Birch.Generator.Specification;
using ICSharpCode.Decompiler.CSharp.Syntax;
using ICSharpCode.Decompiler.TypeSystem;
using System.Linq.Expressions;
using System.Linq;
using System.Linq.Dynamic.Core;

namespace Birch.Generator
{
    internal class Program
    {
        /// <summary>
        /// Create either specification or code files based upon user specified parameters.
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public static async Task<int> Main(string[] args)
            {
                //Setup the command line options
                // 
                var rootCommand = new RootCommand("Creates MVU code for an assembly.");

                // two root commands, code and specification 
                var codeCommand = new Command("code",$"Generate code from a specification file and an assembly");
                var specificationCommand = new Command("specification",$"Generate a sample specification file from an assembly");

                rootCommand.Add(codeCommand);
                rootCommand.Add(specificationCommand);

                var assemblyOption = new Option(aliases: new string[] {"--assembly","--a"}, "The source assembly")
                {
                    Required = true, Argument = new Argument<FileInfo>("assembly").ExistingOnly()
                };
    
                var outputOption = new Option(new string[] {"--output","--o"}, "The optional output file")
                {
                    Required = false, Argument = new Argument<string>("output")
                };
    
                var specificationOption = new Option(new string[] {"--specification","--s"}, "The specification file path")
                {
                    Required = false, Argument = new Argument<FileInfo>("specification").ExistingOnly()
                };

                var typeFilterOption = new Option(new string[] {"--typeFilter", "--t"}, "The optional type filter e.g. 'typeDefinition.FullName.Contains(\".Widget\")' to only include types that have .Widget in its full type name.")
                {
                    Required = false, Argument = new Argument<string>("typeFilter")
                };

                var methodFilterOption = new Option(new string[] {"--methodFilter", "--m"},
                    "The optional method filter e.g. 'method.Name.StartsWith(\"On\")'")
                {
                    Required = false, Argument = new Argument<string>("methodFilter")
                };

                var templatesStyleOption = new Option(new string[] {"--templates", "--tem"},
                    "The default platform templates to be included in the specification file: Android,iOS or XamarinForms.")
                {
                    Required = false, Argument = new Argument<string>("templates")
                };

                var templateExportOption = new Option(new string[] {"--templateExport"},
                    "The way in which templates are exported, either 'Embed' or 'File'. NOT currently used, defaults to Embed.")
                {
                    Required = false,
                    Argument = new Argument<TemplateExportStyle>("templateExportStyle")
                };

                codeCommand.Add(assemblyOption);
                codeCommand.Add(outputOption);
                codeCommand.Add(specificationOption);


                specificationCommand.Add(assemblyOption);
                specificationCommand.Add(outputOption);
                specificationCommand.Add(typeFilterOption);
                specificationCommand.Add(methodFilterOption);
                specificationCommand.Add(templatesStyleOption);
                specificationCommand.Add(templateExportOption);

                codeCommand.Handler = CommandHandler.Create((FileInfo assembly,string output,FileInfo specification) =>
                {
                    GenerateCode(specification,assembly,output);
                }); 

                specificationCommand.Handler = CommandHandler.Create((FileInfo assembly,string output,string typeFilter,string methodFilter,string templates,TemplateExportStyle templateExportStyle) =>
                {
                    GenerateSpecification(assembly,output,typeFilter,methodFilter,templates,templateExportStyle);
                }); 

                return await rootCommand.InvokeAsync(args);
            }

        /// <summary>
        /// User has requested the generation of a specification file for an assembly.
        /// </summary>
        /// <param name="assembly"></param>
        /// <param name="outputPath"></param>
        /// <param name="typeFilter"></param>
        /// <param name="methodFilter"></param>
        /// <param name="templatesStyle"></param>
        /// <param name="templateExportStyle"></param>
        public static void GenerateSpecification(FileInfo assembly, string outputPath = default,
            string typeFilter = default, string methodFilter = default, string templatesStyle = default,
            TemplateExportStyle templateExportStyle=TemplateExportStyle.Embed)
        {
            var typeStore = new TypeStore();

            typeStore.Load(Path.Join(assembly.DirectoryName,assembly.Name));

            var g = new global::Birch.Generator.Specification.Generator(Path.Join(Directory.GetCurrentDirectory(),"\\Templates"));

            Func<ITypeDefinition, bool> typeFilterFunc;

            // lets see if we can convert the type filter into something that can be used at runtime...

            if (!string.IsNullOrEmpty(typeFilter))
            {
                try
                {
                    var parameter = System.Linq.Expressions.Expression.Parameter(typeof(ITypeDefinition), "typeDefinition");

                    var expression = DynamicExpressionParser.ParseLambda(new[] {parameter}, null, typeFilter);

                    var compiled = expression.Compile();

                    typeFilterFunc = (typeDefinition) => (bool) compiled.DynamicInvoke(typeDefinition);

                }
                catch (Exception exception)
                {
                    throw new ArgumentException($"Unable to parse type filter:'{typeFilter}'",exception);
                }
            }
            else
            {
                // just pull in everything
                typeFilterFunc = (s) => true;
            }

            Func<IMethod, bool> methodFilterFunc;

            if (!string.IsNullOrEmpty(methodFilter))
            {
                try
                {
                    var parameter = System.Linq.Expressions.Expression.Parameter(typeof(IMethod), "method");

                    var expression = DynamicExpressionParser.ParseLambda(new[] {parameter}, null, methodFilter);

                    var compiled = expression.Compile();

                    methodFilterFunc = (typeDefinition) => (bool) compiled.DynamicInvoke(typeDefinition);

                }
                catch (Exception exception)
                {
                    throw new ArgumentException($"Unable to method filter:'{methodFilter}'",exception);
                }
            }
            else
            {
                // just pull in everything
                methodFilterFunc = (s) => true;
            }


            var r = g.Generate(typeStore, typeFilterFunc,methodFilterFunc,templatesStyle);
            var f = new JsonFormatter();
            var output = f.Format(r);

            if (outputPath != null)
            {
                File.WriteAllText(outputPath,output);
                Console.WriteLine(Resources.SpecificationFileWritten, outputPath);
            }
            else
            {
                Console.WriteLine(output);
            }
        }

        /// <summary>
        /// User has requested the generation of code given an assembly and specification file.
        /// </summary>
        /// <param name="specification"></param>
        /// <param name="assembly"></param>
        /// <param name="outputPath"></param>
        public static void GenerateCode(FileInfo specification, FileInfo assembly, string outputPath = default)
        {
            if (specification == null)
            {
                throw new ArgumentException(Resources.NoSpecificationFileProvided, nameof(specification));
            }

            // register the appropriate style class for its related type key. Each type in the specification needs to have a 'style' specified
            // for it to be able to generate the appropriate type of code for it.


            TypeGeneratorStore.Instance.Register(global::Birch.Generator.Styles.Extension.Style.Type, () => new global::Birch.Generator.Styles.Extension.Style());
            TypeGeneratorStore.Instance.Register(global::Birch.Generator.Styles.Class.Style.Type, () => new global::Birch.Generator.Styles.Class.Style());

            var job = JobReader.FromFile(Path.Join(specification.DirectoryName,specification.Name));

            var outputTypeStore = OutputTypesStore.Create(job.Configuration.OutputTypes);

            var typeStore = new TypeStore();
            typeStore.Load(Path.Join(assembly.DirectoryName,assembly.Name));

            var modelBuilder = new ModelBuilder(typeStore, outputTypeStore);
            var models = modelBuilder.Create(job);

            var codeBuilder = new CodeBuilder(job);
            var output = codeBuilder.Create(models);

            if (outputPath != null)
            {
                File.WriteAllText(outputPath,output);
                Console.WriteLine(Resources.CodeWrittenTo, outputPath);
            }
            else
            {
                Console.WriteLine(output);
            }
        }
    }
}

