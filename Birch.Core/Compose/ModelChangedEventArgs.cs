namespace Birch.Compose
{
    /// <summary>
    /// The model has changed for a stateful container.
    /// </summary>
    public class ModelChangedEventArgs
    {
        public ModelChange Change { get; }

        public ModelChangedEventArgs(ModelChange change)
        {
            Change = change;
        }
    }
}