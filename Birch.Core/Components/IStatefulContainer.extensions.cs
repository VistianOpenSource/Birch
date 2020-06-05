using System;
using System.Collections.Generic;
using System.Text;

namespace Birch.Components
{
    public static class IStatefulContainerExtensions
    {
        /// <summary>
        /// Update the state of a <see cref="IStatefulContainer{TModel}"/> to a new value.
        /// </summary>
        /// <typeparam name="TModel"></typeparam>
        /// <param name="component"></param>
        /// <param name="model"></param>
        public static void SetModel<TModel>(this IStatefulContainer<TModel> component, TModel model) 
        {
            // Get the build owner of the component and update the value
            component.Context.Owner.SetModel(component, model);
        }
    }
}
