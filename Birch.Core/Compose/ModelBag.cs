using System;
using System.Collections.Concurrent;
using Birch.Components;

namespace Birch.Compose
{
    /// <summary>
    /// Stores the current state of stateful components in a layout
    /// </summary>
    public sealed class ModelBag:IDisposable
    {
        public const int MutationUnspecified = -1;

        /// <summary>
        /// A dictionary of the current state for each stateful container
        /// </summary>
        private readonly ConcurrentDictionary<int,IContainerModel> _modelMap;

        /// <summary>
        /// Create an instance with a new dictionary of state
        /// </summary>
        public ModelBag():this(new ConcurrentDictionary<int, IContainerModel>())
        {
        }

        /// <summary>
        /// Create an instance with a new copy of the state
        /// </summary>
        /// <param name="modelBag"></param>
        public ModelBag(ModelBag modelBag)
        {
            _modelMap = new ConcurrentDictionary<int, IContainerModel>(modelBag._modelMap);
        }

        /// <summary>
        /// Create an instance with a specified seed dictionary of state.
        /// </summary>
        /// <param name="source"></param>
        private ModelBag(ConcurrentDictionary<int, IContainerModel> source)
        {
            _modelMap = new ConcurrentDictionary<int, IContainerModel>(source);
        }

        /// <summary>
        /// Register a stateful container.
        /// </summary>
        /// <typeparam name="TStateContainer"></typeparam>
        /// <typeparam name="TModel"></typeparam>
        /// <param name="stateContainer"></param>
        /// <param name="context"></param>
        public void Register<TStateContainer, TModel>(TStateContainer stateContainer,BuildContext context) where TStateContainer : IStatefulContainer
        {
            var id = context.Id;

            var cm = new ContainerModel<TModel>(new WeakReference(stateContainer));

            _modelMap[id] = cm;
        }

        /// <summary>
        /// Update the model of a stateful container.
        /// </summary>
        /// <typeparam name="TStateContainer"></typeparam>
        /// <param name="stateContainer"></param>
        /// <param name="model"></param>
        /// <param name="mutationId"></param>
        public void SetModel<TStateContainer>(TStateContainer stateContainer, object model,int mutationId) where TStateContainer : class, IStatefulContainer 
        {
            if (_modelMap.TryGetValue(stateContainer.Context.Id, out var containerModel))
            {
                containerModel.SetModel(model,mutationId);
            }
            else
            {
                throw new InvalidOperationException($"StateContainer doesn't exist, yet model set {stateContainer.Context.Id}");                
            }
        }

        /// <summary>
        /// Get the current model for a specified stateful container
        /// </summary>
        /// <typeparam name="TModel"></typeparam>
        /// <param name="stateContainer"></param>
        /// <returns></returns>
        public TModel Get<TModel>(IStatefulContainer<TModel> stateContainer) 
        {
            if (TryGet(stateContainer, out var model))
            {
                return model;
            }

            throw new InvalidOperationException($"StateContainer doesn't exist, yet model requested {stateContainer.Context.Id}");
        }

        /// <summary>
        /// Get the current mutation id for a stateful container
        /// </summary>
        /// <param name="stateContainer"></param>
        /// <returns></returns>
        public int GetMutationId(IStatefulContainer stateContainer)
        {
            return _modelMap.TryGetValue(stateContainer.Context.Id, out var containerModel) ? containerModel.LastMutationId : MutationUnspecified;
        }

        /// <summary>
        /// Try and get the model for a specified stateful container.
        /// </summary>
        /// <typeparam name="TModel"></typeparam>
        /// <param name="stateContainer"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool TryGet<TModel>(IStatefulContainer<TModel> stateContainer,out TModel model)
        {
            if (_modelMap.TryGetValue(stateContainer.Context.Id, out var containerModel))
            {
                // verify that the model is still alive, i.e. the weak reference still references something
                if (containerModel.IsAlive)
                {
                    var cm = ((ContainerModel<TModel>) containerModel);

                    if (!cm.HasModel)
                    {
                        // if no model exists, get the initial state from the stateful container

                        model = stateContainer.InitState();
                        cm.SetModel(model,0);
                    }
                    else
                    {
                        model = cm.Model.Value;
                    }
                    
                    return true;
                }

                throw new InvalidOperationException($"StateContainer not alive, yet model requested {stateContainer.Context.Id}");
            }

            model = default;
            return false;
        }

        /// <summary>
        /// When we are disposed, dispose of each item
        /// </summary>
        public void Dispose()
        {
            foreach (var item in _modelMap.Values)
            {
                item.Dispose();
            }

            _modelMap.Clear();
        }
    }
}