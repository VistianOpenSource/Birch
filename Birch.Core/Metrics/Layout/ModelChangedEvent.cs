using Birch.Compose;

namespace Birch.Metrics.Layout
{
    /// <summary>
    /// A model has changed event
    /// </summary>
    public class ModelChangedEvent : LayoutEvent
    {
        /// <summary>
        /// Get the details about the model that has changed
        /// </summary>
        public ModelChange Change { get; }

        public ModelChangedEvent(ModelChange change)
        {
            Change = change;
        }

        public override string ToString()
        {
            return $"{When} ModelChanged MutationId:{Change.MutationId} Type:{Change.Model.GetType()} Container Type : {Change.Container.GetType()}";
        }
    }
}