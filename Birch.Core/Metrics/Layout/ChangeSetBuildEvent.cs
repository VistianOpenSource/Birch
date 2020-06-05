using Birch.Components;
using Birch.Compose;

namespace Birch.Metrics.Layout
{
    /// <summary>
    /// The <see cref="LayoutEvent"/> when a set of changes have been calculated
    /// </summary>
    public class ChangeSetBuildEvent : LayoutEvent
    {
        /// <summary>
        /// Get the duration in milliseconds the change set build took
        /// </summary>
        public long DurationMilliseconds { get; }

        /// <summary>
        /// Was the operation cancelled.
        /// </summary>
        public bool Cancelled { get; }

        /// <summary>
        /// The associated <see cref="ElementShadowTransition"/> with this change set
        /// </summary>
        public ElementShadowTransition ElementShadowChange { get; }

        public ChangeSetBuildEvent(long durationMilliseconds, bool cancelled, ElementShadowTransition elementShadowChange)
        {
            DurationMilliseconds = durationMilliseconds;
            Cancelled = cancelled;
            ElementShadowChange = elementShadowChange;
        }

        public override string ToString()
        {
            return $"{When} ChangeSet Duration:{DurationMilliseconds} Cancelled:{Cancelled} Transaction Count:{ElementShadowChange?.TransactionsList.Count}";
        }
    }
}