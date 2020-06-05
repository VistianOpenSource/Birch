using System.Collections.Generic;

namespace Birch.Generator.Generation
{
    /// <summary>
    /// Represents a method that can be invoked.
    /// </summary>
    public class AttributeMethodModel
    {
        /// <summary>
        /// Get the name of the method
        /// </summary>
        public string MethodName { get;  }

        /// <summary>
        /// Get the name of the type in which the method is defined
        /// </summary>
        public string DefiningType { get;  }

        /// <summary>
        /// Get the arguments passed into this method.
        /// </summary>
        public List<Argument> Arguments { get;  }

        /// <summary>
        /// Get the template name to use
        /// </summary>
        public string Template { get;  }


        /// <summary>
        /// Non null is the Obsolete warning
        /// </summary>
        public string Obsolete { get; }

        public AttributeMethodModel(string methodName, string definingType, List<Argument> arguments,string template,string obsolete)
        {
            MethodName = methodName;
            DefiningType = definingType;
            Arguments = arguments;
            Template = template;
            Obsolete = obsolete;
        }
    }
}