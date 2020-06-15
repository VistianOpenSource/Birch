using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Birch.Generator.Properties;
using Newtonsoft.Json;

namespace Birch.Generator.Specification
{
    public class ResourceTemplateLoader
    {
        
        public static List<Template> ReadFor(string templateStyles)
        {
            // we first load the definition file, which is a json array of ResourceTemplates

            var json = (string)System.Text.Encoding.Default.GetString((byte[])Resources.ResourceManager.GetObject($"Templates.{templateStyles}"));

            if (string.IsNullOrEmpty(json))
            {
                throw new ArgumentException($"No templates defined for {templateStyles}",nameof(templateStyles));
            }
            var resourceTemplates = JsonConvert.DeserializeObject<List<ResourceTemplate>>(json);

            var templates = resourceTemplates.Select(rt =>
            {
                var templateContent = (string)System.Text.Encoding.Default.GetString((byte[])Resources.ResourceManager.GetObject(rt.ResourceName));


                var template = new Template(rt.TemplateName, rt.Type, TemplateLocation.Inline)
                    {Content = templateContent};

                return template;
            });

            return templates.ToList();
        }
    }
}
