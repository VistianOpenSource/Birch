using Birch.Components;
using Birch.Shadows;

namespace Birch.Compose
{
    /// <summary>
    /// Specification of how <see cref="IElement"/> instances are used to create, update and ultimately remove a
    /// <see cref="IShadow"/> instance
    /// </summary>
    public interface IShadowMapper
    {
        /// <summary>
        /// Create a <see cref="IShadow"/> instance
        /// </summary>
        /// <param name="context"></param>
        /// <param name="viewElement"></param>
        /// <returns></returns>
        IShadow CreateShadow(IShadowContext context, IPrimitive viewElement);

        /// <summary>
        /// Update a <see cref="IShadow"/> from its current state to its next state.
        /// </summary>
        /// <param name="context"></param>
        /// <param name="shadow"></param>
        /// <param name="current"></param>
        /// <param name="next"></param>
        void UpdateShadow(IShadowContext context, IShadow shadow, IPrimitive current, IPrimitive next);

        /// <summary>
        /// The <see cref="IShadow"/> is being removed , perform any necessary housekeeping.
        /// </summary>
        /// <param name="context"></param>
        /// <param name="shadow"></param>
        /// <param name="current"></param>
        void RemoveShadow(IShadowContext context, IShadow shadow, IPrimitive current);
    }
}