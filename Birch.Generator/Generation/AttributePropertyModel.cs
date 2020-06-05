namespace Birch.Generator.Generation
{
    /// <summary>
    /// Represents a property that can be assigned to.
    /// </summary>
    public class AttributePropertyModel
    {
        /// <summary>
        /// The name of the property
        /// </summary>
        public string Name { get;  }

        /// <summary>
        /// The actual full name of the type of the property
        /// </summary>
        public string FullTypeName { get;  }

        /// <summary>
        /// The short type name of this property
        /// </summary>
        public string ShortTypeName { get; set; }

        /// <summary>
        /// The type of class at which this property is defined
        /// </summary>
        public string DefiningType { get;  }

        /// <summary>
        /// The template to use
        /// </summary>
        public string Template { get;  }


        /// <summary>
        /// Any notes that need to be published
        /// </summary>
        public string Notes { get; }


        /// <summary>
        /// If non null, implies the property is obsolete
        /// </summary>
        public string Obsolete { get; }

        public AttributePropertyModel(string name, string shortTypeName,string fullTypeName, string definingType,string template,string notes,string obsolete)
        {
            Name = name;
            ShortTypeName = shortTypeName;
            FullTypeName = fullTypeName;
            DefiningType = definingType;
            Template = template;
            Notes = notes;
            Obsolete = obsolete;
        }
    }
}