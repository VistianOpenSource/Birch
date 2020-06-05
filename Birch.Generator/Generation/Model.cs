using System.Collections.Generic;

namespace Birch.Generator.Generation
{
    /// <summary>
    /// The base model for the generation of code.
    /// </summary>
    public class Model
    {
        /// <summary>
        /// The namespace to be used
        /// </summary>
        public string Namespace { get;  }

        /// <summary>
        /// The list of generated models to be converted into code .
        /// </summary>
        public IList<IGeneratedTypeModel> Body { get;  }

        public Model(string ns, IList<IGeneratedTypeModel> body)
        {
            Namespace = ns;
            Body = body;
        }
    }
}
