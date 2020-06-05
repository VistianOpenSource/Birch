using System.Collections.Generic;
using System.Threading;
using Birch.Core.Transactions;

namespace Birch.Transactions
{
    /// <summary>
    /// Core elements for operational transactions
    /// </summary>
    internal sealed class ModelInstance:ITransactionModel
    {
        public ReaderWriterLockSlim Lock { get; } = new ReaderWriterLockSlim();

        public int TransactionDepth { get; set; }

        public Transaction Instance { get; set; }

        public TransactionCommitQueue CommitQueue { get; } = new TransactionCommitQueue();

        /// <summary>
        /// The stack of previously saved instances.
        /// </summary>
        private readonly Stack<Transaction> _savedInstances = new Stack<Transaction>();

        public void SaveInstance()
        {
            // add the current instance to the stack
            _savedInstances.Push(Instance);
        }

        public void RestoreInstance()
        {
            // and remove it from the stack
            Instance = _savedInstances.Pop();
        }
    }
}