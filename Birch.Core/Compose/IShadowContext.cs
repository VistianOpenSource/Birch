namespace Birch.Compose
{
    /// <summary>
    /// The context under which the shadow mapping phase in undertaken.
    /// </summary>
    public interface IShadowContext
    {
        /// <summary>
        /// Get the <see cref="ShadowMapperFactory"/>
        /// </summary>
        ShadowMapperFactory MapperFactory { get; }
    }
}