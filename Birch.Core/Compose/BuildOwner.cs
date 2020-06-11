using System;
using System.Threading;
using Birch.Components;
using Birch.Diagnostics;
using CloneExtensions;
using Microsoft.Extensions.Logging;

namespace Birch.Compose
{
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// Responsible for processing and forwarding of state changes for stateful containers.
    /// The mutation id is incremented whenever a stateful model is updated and before an event
    /// is created for the mutation. This allows for consumers to then check if the mutation Id they
    /// have is the same as the current one, in effect allowing the code to check that what could be
    /// presented is in-fact a true representation of the current state or not.
    /// </remarks>
    public class BuildOwner:IDisposable
    {
        /// <summary>
        /// The cloning mode to be used
        /// </summary>
        private readonly CloneMode _cloneMode;


        /// <summary>
        /// Whether cloning issues should just be swallowed.
        /// </summary>
        private readonly bool _swallowCloneErrors;

        /// <summary>
        /// The container for all of the stateful container models
        /// </summary>
        public  ModelBag ModelBag { get; }

        /// <summary>
        /// Event raised when a model changes
        /// </summary>
        public EventHandler<ModelChangedEventArgs> Changed { get; set; }

        /// <summary>
        /// The counter used to identify model changes with a mutation id.
        /// </summary>
        private int _mutationId = StartMutationId;

        public const int StartMutationId = 0;

        public const int NeverUsedMutationId = -1;

        /// <summary>
        /// Create an instance of the build owner
        /// </summary>
        /// <param name="cloneMode">They way in which models of stateful containers are stored.</param>
        /// <param name="swallowCloneErrors">Whether we should ignore cloning of model errors</param>
        /// <remarks>Currently clone mode is only used for indication as to whether to clone at all or not.
        /// </remarks>
        public BuildOwner(CloneMode cloneMode=CloneMode.Deep,bool swallowCloneErrors=true)
        {
            _cloneMode = cloneMode;
            _swallowCloneErrors = swallowCloneErrors;
            ModelBag = new ModelBag();
        }

        /// <summary>
        /// /// 
        /// </summary>
        /// <typeparam name="TModel"></typeparam>
        /// <param name="component"></param>
        /// <param name="model"></param>
        public void SetModel<TModel>(IStatefulContainer<TModel> component, TModel model)
        {
            // increment the mutation id first, very important
            var mutationId = Interlocked.Increment(ref _mutationId);

            // attempt to clone
            var finalModel = ObjectUtils.Clone(model, _cloneMode, _swallowCloneErrors);

            // and raise an event 
            OnChanged(new ModelChange(component,finalModel,mutationId));
        }

        /// <summary>
        /// Determine whether a specified mutation id matches the current mutation id.
        /// </summary>
        /// <param name="mutationId"></param>
        /// <returns></returns>
        public bool IsLatestMutation(int mutationId)
        {
            var currentMutationId = Interlocked.CompareExchange(ref _mutationId, 0, NeverUsedMutationId);

            return currentMutationId == mutationId;
        }

        public int MutationId => _mutationId;

        /// <summary>
        /// Get the current model for a specified stateful container.
        /// </summary>
        /// <typeparam name="TModel"></typeparam>
        /// <param name="component"></param>
        /// <returns></returns>
        public TModel GetModel<TModel>(IStatefulContainer<TModel> component)
        {
            return ModelBag.Get(component);
        }

        /// <summary>
        /// Raise a <see cref="ModelChangedEventArgs"/> event.
        /// </summary>
        /// <param name="modelChange"></param>
        protected virtual void OnChanged(ModelChange modelChange)
        {
            Changed?.Invoke(this,new ModelChangedEventArgs(modelChange));
        }

        /// <summary>
        /// Dispose of the Model bag.
        /// </summary>
        public void Dispose()
        {
            ModelBag?.Dispose();
        }
    }
}