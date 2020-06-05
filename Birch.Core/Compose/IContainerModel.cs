using System;

namespace Birch.Compose
{
    /// <summary>
    /// Storage of a stateful containers model and mutation id
    /// </summary>
    public interface IContainerModel:IDisposable
    {
        /// <summary>
        /// Whether the stateful container is still 'alive' i.e. not been garbage collections
        /// </summary>
        public bool IsAlive { get; }

        /// <summary>
        /// Update the model and mutation id stored against the stateful container
        /// </summary>
        /// <param name="model"></param>
        /// <param name="mutationId"></param>
        void SetModel(object model,int mutationId);

        /// <summary>
        /// Get the last mutation id seen
        /// </summary>
        int LastMutationId { get; }
    }
}