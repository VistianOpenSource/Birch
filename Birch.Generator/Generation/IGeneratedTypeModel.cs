namespace Birch.Generator.Generation
{
    /// <summary>
    /// Each 'type' of code generator implements this interface.
    /// </summary>
    public interface IGeneratedTypeModel
    {
        /// <summary>
        /// Get the name of the template to be used for the actual code layout
        /// </summary>
        public string Template { get;  }
    }
}