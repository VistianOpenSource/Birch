using System;

namespace Birch.Compose
{
    /// <summary>
    /// Contains the current version of model data for stateful containers.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public sealed class ContainerModel<T> :IContainerModel
    {
        /// <summary>
        /// A weak reference to the actual stateful container
        /// </summary>
        public WeakReference Container { get; }


        /// <summary>
        /// Whether the stateful container is still active
        /// </summary>
        public bool IsAlive => Container.IsAlive;

        /// <summary>
        /// Update the model stored against the container, along with its mutation id
        /// </summary>
        /// <param name="model"></param>
        /// <param name="mutationId"></param>
        public void SetModel(object model,int mutationId)
        {
            SetModel((T)model,mutationId);
        }

        /// <summary>
        /// Get the last mutation id associated with this stateful container.
        /// </summary>
        public int LastMutationId { get; private set; }

        /// <summary>
        /// The actual model data
        /// </summary>
        public Option<T> Model { get; set; }

        /// <summary>
        /// Create an instance where we don't have a value for the model
        /// </summary>
        /// <param name="container"></param>
        public ContainerModel(WeakReference container)
        {
            Container = container;
            Model = Option<T>.None;
        }

        public ContainerModel(WeakReference container, T model)
        {
            Container = container;
            Model = Option<T>.Some(model);
        }

        /// <summary>
        /// Whether there is any model data or not
        /// </summary>
        public bool HasModel => Model.IsSome;

        /// <summary>
        /// Set the model to the specified state and mutation id
        /// </summary>
        /// <param name="initState"></param>
        /// <param name="mutationId"></param>
        public void SetModel(T initState,int mutationId)
        {
            Model = Option<T>.Some(initState);
            LastMutationId = mutationId;
        }

        /// <summary>
        /// Dispose of the model container. 
        /// </summary>
        /// <remarks>
        /// Will dispose of the container as well
        /// </remarks>
        public void Dispose()
        {
            if (IsAlive)
            {
                ((IDisposable)(Container.Target)).Dispose();
                Container.Target = null;
            }
        }
    }
}