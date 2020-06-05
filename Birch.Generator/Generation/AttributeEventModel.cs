namespace Birch.Generator.Generation
{
    public class AttributeEventModel
    {
        /// <summary>
        /// The name of the event
        /// </summary>
        public string EventName { get;  }

        /// <summary>
        /// The type in which the event was declared
        /// </summary>
        public string DefiningType { get;  }

        /// <summary>
        /// The full name of the type for this event. Empty implies none.
        /// </summary>
        public string FullTypeName { get;  }

        /// <summary>
        /// The short name of the type for this event. Empty implies none.
        /// </summary>
        public string ShortTypeName { get; }

        /// <summary>
        /// The template to use.
        /// </summary>
        public string Template { get; }

        /// <summary>
        /// If non null, the obsolete warning
        /// </summary>
        public string Obsolete { get; }

        public AttributeEventModel(string eventName, string definingType, string fullTypeName, string shortTypeName,string template,string obsolete)
        {
            EventName = eventName;
            DefiningType = definingType;
            FullTypeName = fullTypeName;
            ShortTypeName = shortTypeName;
            Template = template;
            Obsolete = obsolete;
        }
    }
}