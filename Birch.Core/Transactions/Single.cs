using System.Threading;
using Birch.Core.Transactions;

namespace Birch.Transactions
{
    /// <summary>
    /// Transactions executed with a single global instance across all threads.
    /// </summary>
    public class Single:ITransactionModel
    {
        private static readonly ModelInstance Model = new ModelInstance();

        public ReaderWriterLockSlim Lock => Model.Lock;

        public int TransactionDepth
        {
            get => Model.TransactionDepth;
            set => Model.TransactionDepth = value;
        }

        public Transaction Instance
        {
            get => Model.Instance;
            set => Model.Instance = value;
        }
        public TransactionCommitQueue CommitQueue => Model.CommitQueue;

        public void SaveInstance()
        {
            Model.SaveInstance();
        }

        public void RestoreInstance()
        {
            Model.RestoreInstance();
        }
    }
}