using Birch.Components;
using Birch.Compose;

namespace Birch.Metrics.Layout
{
    /// <summary>
    /// a sequence of transactions have been committed during layout.
    /// </summary>
    public class TransactionsCommittedEvent : LayoutEvent
    {
        /// <summary>
        /// Get the duration in milliseconds the commit tool
        /// </summary>
        public long DurationMilliseconds { get; }

        /// <summary>
        /// Get the elements that changed.
        /// </summary>
        public ElementShadowTransition ElementShadowChange { get; }

        public TransactionsCommittedEvent(long durationMilliseconds, ElementShadowTransition elementShadowChange)
        {
            DurationMilliseconds = durationMilliseconds;
            ElementShadowChange = elementShadowChange;
        }

        public override string ToString()
        {
            return
                $"{When} Transactions Committed Duration:{DurationMilliseconds} Transaction Count:{ElementShadowChange.TransactionsList.Count}";
        }
    }
}