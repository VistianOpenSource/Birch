namespace Birch.Components
{
    /// <summary>
    /// Specification for the taking of changes to children and applying them to the UI.
    /// </summary>
    /// <typeparam name="TContext"></typeparam>
    /// <typeparam name="TItem"></typeparam>
    public interface IBackingDataHandler<in TContext,TItem> where TItem : class 
    {
        /// <summary>
        /// Update the children the current <see cref="BasePrimitive"/> and next <see cref="BasePrimitive"/> states
        /// </summary>
        /// <param name="context"></param>
        /// <param name="current"></param>
        /// <param name="next"></param>
        void Update(TContext context,BasePrimitive<TItem> current,BasePrimitive<TItem> next);

        /// <summary>
        /// Remove the children from the UI.
        /// </summary>
        /// <param name="context"></param>
        /// <param name="current"></param>
        void Remove(TContext context, BasePrimitive<TItem> current);
    }
}