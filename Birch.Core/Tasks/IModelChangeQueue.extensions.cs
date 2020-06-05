using System;
using System.Collections.Generic;
using System.Text;
using Birch.Components;
using Birch.Compose;

namespace Birch.Tasks
{
    public static class IModelChangeQueueExtensions
    {
        public static void Enqueue<TStateContainer, TModel>(this IModelChangeQueue queue, TStateContainer container, TModel model,int mutationId)
            where TStateContainer : class, IStatefulContainer<TModel>
        {
            queue.Enqueue(new ModelChange(container,model,mutationId));
        }
    }
}
