using Birch.Core.Transactions;

namespace Birch.Transactions
{
    public static class TransactionModel
    {
        /// <summary>
        /// Specifies the default <see cref="ITransactionModel"/> to be used.
        /// </summary>
        /// <remarks>
        /// The way in which transactions are handled can be changed by setting this value PRIOR to any transactions being created.
        /// </remarks>
        public static ITransactionModel Current = new Threaded();
    }
}