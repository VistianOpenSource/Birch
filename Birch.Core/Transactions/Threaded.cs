using System.Threading;
using Birch.Core.Transactions;

namespace Birch.Transactions
{
    /// <summary>
    /// Transactions executed with each thread having its own queue.
    /// </summary>
    public class Threaded:ITransactionModel
    {
        /// <summary>
        /// Each thread has its own instance.
        /// </summary>
        private static readonly ThreadLocal<ModelInstance> Model = new ThreadLocal<ModelInstance>(() => new ModelInstance());

        /// <summary>
        /// We have a lock per model instance.
        /// </summary>
        public ReaderWriterLockSlim Lock => Model.Value.Lock;

        public int TransactionDepth
        {
            get => Model.Value.TransactionDepth;
            set => Model.Value.TransactionDepth = value;
        }

        public Transaction Instance
        {
            get => Model.Value.Instance;
            set => Model.Value.Instance = value;
        }
        public TransactionCommitQueue CommitQueue => Model.Value.CommitQueue;

        public void SaveInstance()
        {
            Model.Value.SaveInstance();
        }

        public void RestoreInstance()
        {
            Model.Value.RestoreInstance();
        }
    }
}