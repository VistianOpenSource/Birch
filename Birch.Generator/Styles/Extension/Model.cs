using System.Collections.Generic;
using Birch.Generator.Generation;

namespace Birch.Generator.Styles.Extension
{
    /// <summary>
    /// Model used for extension method style type generation.
    /// </summary>
    public class Model:IGeneratedTypeModel
    {
        /// <summary>
        /// The name of the extension method
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The type of the underlying control
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Get the name of the template to be used for the actual code layout
        /// </summary>
        public string Template { get; set; }

        /// <summary>
        /// The list of arguments for the method, which also need to be applied
        /// through the standard attribute assignment mechanism
        /// </summary>
        public List<Argument> Arguments { get; set; }
        
        /// <summary>
        /// The list of attributes to create
        /// </summary>
        public List<AttributePropertyModel> Attributes { get; set; }

        /// <summary>
        /// The list of event attributes to create
        /// </summary>
        public List<AttributeEventModel> Events { get; set; }

        /// <summary>
        /// The list of method call attributes to create
        /// </summary>
        public List<AttributeMethodModel> Methods { get; set; }


        public Model(string name,string type, string template,List<Argument> arguments=default, List<AttributePropertyModel> attributes=default, List<AttributeEventModel> events=default, List<AttributeMethodModel> methods=default)
        {
            Name = name;
            Type = type;
            Template = template;
            Arguments = arguments??new List<Argument>();
            Attributes = attributes??new List<AttributePropertyModel>();
            Events = events??new List<AttributeEventModel>();
            Methods = methods??new List<AttributeMethodModel>();
        }

        public static string DefaultTemplate = @"
    public static class Control
    {
        public static AndroidControl<{{Type}}> {{Name}}({{#each Arguments}}{{Type}} {{argumentCase Name}} {{#if DefaultValue}}={{DefaultValue}}{{/if}} {{#unless @last}},{{/unless}}{{/each}})
        {
            var control = View<{{Type}}>();

{{#each Arguments}}
            control.Attributes.Set({{Name}},{{argumentCase name}});
{{/each}}
            return control;
        }
    }
";
    }
}