using System.Collections.Generic;
using Birch.Components;
using Birch.Compose;

namespace MVU_Experiment.Duff
{
    /// <summary>
    /// Contains a collection of <see cref="IStatefulContainer"/> instances and a record of their mutation ids.
    /// </summary>
    /// <remarks>
    /// Primary used to record mutation ids to determine when a stateful container has changed state.
    /// </remarks>
    public class MutationMap
    {
        private readonly ModelBag _modelBag;
        private readonly Dictionary<IStatefulContainer, int> _mutationIds = new Dictionary<IStatefulContainer, int>();

        public MutationMap(ModelBag modelBag)
        {
            _modelBag = modelBag;
        }

        public void Update(IElement component)
        {
            var sc = component as IStatefulContainer;

            var currentMutation = _modelBag.GetMutationId(sc);

            if (!_mutationIds.TryGetValue(sc, out var lastMutation))
            {
                lastMutation = ModelBag.MutationUnspecified;
            }

            if (currentMutation != lastMutation)
            {
                _mutationIds[sc] = currentMutation;

            }
        }

        public bool IsUpdated(IElement component)
        {
            if (!component.IsStateful())
            {
                return false;
            }

            var sc = component as IStatefulContainer;

            var currentMutation = _modelBag.GetMutationId(sc);

            if (!_mutationIds.TryGetValue(sc, out var lastMutation))
            {
                lastMutation = ModelBag.MutationUnspecified;
            }

            if (currentMutation != lastMutation)
            {
                _mutationIds[sc] = currentMutation;
                return true;
            }

            return false;
        }
    }
}