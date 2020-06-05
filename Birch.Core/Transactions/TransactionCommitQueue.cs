using System.Collections.Generic;
using Birch.Transactions;

namespace Birch.Core.Transactions
{
    /// <summary>
    /// A queue of a sequence of transactions that need to be committed
    /// </summary>

    public class TransactionCommitQueue
    {
        /// <summary>
        /// The queue of transactions
        /// </summary>
        private readonly Stack<TransactionsList> _transactions = new Stack<TransactionsList>();

        /// <summary>
        /// Get whether currently committing transactions or not.
        /// </summary>
        /// <remarks>
        /// Can be used to determine how transactions started during a commit phase
        /// should be handled.
        /// </remarks>
        public bool IsActive { get; private set; } 

        /// <summary>
        /// Commit all existing transactions in the list.
        /// </summary>
        public void Commit()
        {
            // if already committing then don't start again
            if (IsActive)
            {
                return;
            }

            IsActive = true;
            try
            {
                // keep taking from first element in list until no more

                while (_transactions.TryPop(out var transaction))
                {
                    transaction.Apply();
                }
            }
            finally
            {
                IsActive = false;
            }
        }

        /// <summary>
        /// Add another transaction to the list of transactions.
        /// </summary>
        /// <param name="transactionsList"></param>
        public void Add(TransactionsList transactionsList)
        {
            _transactions.Push(transactionsList);
        }
    }
}