using System;
using Birch.Components;

namespace Birch.Hosts
{
    /// <summary>
    /// Specification of the error policy to be employed by build hosts.
    /// </summary>
    public interface IBuildErrorPolicy
    {
        /// <summary>
        /// Policy for a layout error
        /// </summary>
        /// <param name="buildHostInstance"></param>
        /// <param name="exception"></param>
        /// <returns></returns>
        IElement LayoutErrorFormat(BuildHostInstance buildHostInstance, Exception exception);

        /// <summary>
        /// Policy for a fatal error, typically from the commit phase during layout.
        /// </summary>
        /// <param name="buildHostInstance"></param>
        /// <param name="exception"></param>
        void FatalError(BuildHostInstance buildHostInstance, Exception exception);
    }
}