using Birch.Components;

namespace Birch.Compose
{
    public sealed class ModelChange
    {
        public IStatefulContainer Container { get; }

        public object Model { get; }

        public int MutationId { get; }

        public ModelChange(IStatefulContainer container, object model,int mutationId)
        {
            Container = container;
            Model = model;
            MutationId = mutationId;
        }
    }
}