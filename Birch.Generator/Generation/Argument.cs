namespace Birch.Generator.Generation
{
    /// <summary>
    /// Represents a single argument for a method signature.
    /// </summary>
    public class Argument
    {
        /// <summary>
        /// The full type name of the argument
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// The name of the argument
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// If non empty, the default value to be used.
        /// </summary>
        public string DefaultValue { get; set; }

        /// <summary>
        /// whether nullable or not
        /// </summary>
        public bool Nullable { get; set; }


        public Argument(string type, string name, string defaultValue=default,bool nullable=false)
        {
            Type = type;
            Name = name;
            DefaultValue = defaultValue;
            Nullable = nullable;
        }
    }
}