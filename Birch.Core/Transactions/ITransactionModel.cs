using System.Threading;
using Birch.Core.Transactions;

namespace Birch.Transactions
{
    /// <summary>
    /// Transactional service specification.
    /// </summary>
    public interface ITransactionModel
    {
        /// <summary>
        /// Get the locking mechanism used to coordinating transactions
        /// </summary>
        ReaderWriterLockSlim Lock { get; }

        /// <summary>
        /// Get or set the current transaction depth
        /// </summary>
        int TransactionDepth {get; set; }

        /// <summary>
        /// Get the current transaction instance
        /// </summary>
        Transaction Instance { get; set; }

        /// <summary>
        /// Get the queue of transactions pending being committed.
        /// </summary>
        TransactionCommitQueue CommitQueue { get; }

        /// <summary>
        /// Save the current instance
        /// </summary>
        void SaveInstance();

        /// <summary>
        /// Restore any saved instance
        /// </summary>
        void RestoreInstance();
    }
}