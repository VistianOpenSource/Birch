using Birch.Transactions;

namespace Birch.Compose
{
    public class ElementShadowTransition
    {
        /// <summary>
        /// The current state
        /// </summary>
        public ElementShadowPair Current { get; }

        /// <summary>
        /// The next desired state
        /// </summary>
        public ElementShadowPair Next { get; }

        /// <summary>
        /// The transactions to take you from the current state to the next state
        /// </summary>
        public TransactionsList TransactionsList { get; }


        public ElementShadowTransition(ElementShadowPair current, TransactionsList transactionsList, ElementShadowPair next)
        {
            Current = current;
            TransactionsList = transactionsList;
            Next = next;
        }

        public static ElementShadowTransition Empty { get; } = new ElementShadowTransition(null,null,null);
    }
}