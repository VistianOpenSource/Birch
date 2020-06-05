using System;
using Birch.Compose;

namespace Birch.Hosts
{
    /// <summary>
    /// An exception during layout has been seen.
    /// </summary>
    internal class LayoutException : Exception
    {
        /// <summary>
        /// The current state
        /// </summary>
        public MutationElementShadowPair CurrentState { get; }

        /// <summary>
        /// The mutation id for which the layout failed.
        /// </summary>
        public int MutationId { get; }

        /// <summary>
        /// The associated <see cref="LayoutContext"/>
        /// </summary>
        public LayoutContext Context;

        public LayoutException(LayoutContext context, MutationElementShadowPair currentState, int mutationId, Exception exception):base(exception.Message,exception)
        {
            CurrentState = currentState;
            MutationId = mutationId;
            Context = context;
        }
    }
}