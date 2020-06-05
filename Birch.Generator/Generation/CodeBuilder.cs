using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using Birch.Generator.Properties;
using Birch.Generator.Specification;
using HandlebarsDotNet;

namespace Birch.Generator.Generation
{
    /// <summary>
    /// Convert a collection of <see cref="IGeneratedTypeModel"/> create the actual code.
    /// </summary>
    public class CodeBuilder
    {
        private readonly Job _job;

        private readonly Dictionary<string,Func<object,string>> _formatters = new Dictionary<string, Func<object, string>>();
        private static readonly Regex Expression = new Regex("[^a-zA-Z0-9]+",RegexOptions.Compiled);   // our regex expression for removing invalid chars from text so can be used in a class name

        public CodeBuilder(Job job)
        {
            _job = job;
            RegisterHelpers();
            LoadTemplates(job.Configuration.Templates);
        }

        /// <summary>
        /// Register the standard helpers which the templates use.
        /// </summary>
        private static void RegisterHelpers()
        {
            // Given a string ensures the first character of it is lower case.
            Handlebars.RegisterHelper("argumentCase",(output, context, arguments) =>
            {
                var str = arguments[0] as string??string.Empty;
                output.Write(str.Length >= 1 ? char.ToLower(str[0])+str[1..]:str);
            });

            // Given a number increment it by one
            Handlebars.RegisterHelper("inc",(output, context, arguments) =>
            {
                var val = (int)arguments[0];
                output.Write(val+1);
            });

            // lookup a template name and return that
            Handlebars.RegisterHelper("lookup", (output, context, arguments) =>
            {
                output.Write(arguments[0]);
            });

            // simple extension to take a string and convert into one which could be used in a class name
            Handlebars.RegisterHelper("nameTidy", (output, context, arguments) =>
            {
                var str = arguments[0] as string ?? string.Empty;

                var classifiedName = Expression.Replace(str, "_");
                output.Write(classifiedName);
            });

            // simple extension to take a string and convert it to a single line
            Handlebars.RegisterHelper("singleLine", (output, context, arguments) =>
            {
                var str = arguments[0] as string ?? string.Empty;

                var singleLine = str.Replace(Environment.NewLine," ");
                output.Write(singleLine);
            });

        }

        /// <summary>
        /// Load all of the templates, compile them and store for later use.
        /// </summary>
        /// <param name="templates"></param>
        private void LoadTemplates(IEnumerable<Template> templates)
        {
            foreach (var template in templates)
            {
                var content = template.Source switch
                {
                    TemplateLocation.File => File.ReadAllText(template.Path),
                    TemplateLocation.Inline => template.Content,
                    TemplateLocation.Resource => System.Text.Encoding.UTF8.GetString((byte[])Resources.ResourceManager.GetObject(template.Path)),
                    _ => throw new NotImplementedException()
                };

                if (template.Type == TemplateType.Basic)
                {
                    var compiledTemplate = Handlebars.Compile(content);
                    _formatters[template.Name] = compiledTemplate;
                }
                else
                {
                    Handlebars.RegisterTemplate(template.Name,content);

                    var compiledTemplate = Handlebars.Compile(content);
                    _formatters[template.Name] = compiledTemplate;
                }

                //if (template.Source == TemplateLocation.Inline)
                //{
                //    // now then, lets look to write then out as files
                //    File.WriteAllText(template.Name+".hbs",template.Content);
                //}
            }


        }

        /// <summary>
        /// Create the actual code from a collection of <see cref="IGeneratedTypeModel"/> instances.
        /// </summary>
        /// <param name="models"></param>
        /// <returns></returns>
        public string Create(IList<IGeneratedTypeModel> models)
        {
            var output = _formatters[_job.Configuration.RootTemplate](new Model(_job.Configuration.Namespace, models));

            return output;
        }
    }
}
