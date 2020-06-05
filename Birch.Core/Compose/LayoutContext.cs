namespace Birch.Compose
{
    /// <summary>
    /// The context under which the layout phase is undertaken.
    /// </summary>
    /// <remarks>
    /// Typically a clone of the 'current' see <see cref="ModelBag"/> is made and then passed into the layout context.
    /// The layout context is the truth with regard to the state that should be rendered as part of the layout process.</remarks>
    public partial class LayoutContext
    {
        /// <summary>
        /// Get the model bag associated with this layout context.
        /// </summary>
        public ModelBag ModelBag { get; }

        /// <summary>
        /// Get the layout resolver.
        /// </summary>
        public LayoutResolver LayoutResolver { get; }

        public LayoutContext(ModelBag modelBag,LayoutResolver layoutResolver) => (ModelBag,LayoutResolver) = (modelBag,layoutResolver);

        public static LayoutContext Create(ModelBag modelBag, LayoutResolver layoutResolver)
        {
            var clonedModelBag = modelBag;

            return new LayoutContext(clonedModelBag,layoutResolver);
        }
    }

}