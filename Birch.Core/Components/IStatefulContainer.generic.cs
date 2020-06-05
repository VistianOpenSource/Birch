using System;
using System.Collections.Generic;
using System.Text;

namespace Birch.Components
{
    /// <summary>
    /// Specification of a stateful container.
    /// </summary>
    /// <typeparam name="TModel"></typeparam>
    public interface IStatefulContainer<out TModel>:IStatefulContainer
    {
        /// <summary>
        /// Get the initial state to be used for layout.
        /// </summary>
        /// <returns></returns>
        TModel InitState();
    }
}
