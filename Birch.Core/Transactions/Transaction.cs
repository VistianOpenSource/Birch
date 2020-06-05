using System;
using System.Runtime.CompilerServices;
using System.Threading;
using Birch.Core.Transactions;
using Birch.Diagnostics;
using Microsoft.Extensions.Logging;

namespace Birch.Transactions
{
    /// <summary>
    /// Creation odf sequences of operations to be applied at a later date. 
    /// </summary>
    public class Transaction:IDisposable
    {
        /// <summary>
        /// The unique identifier for this transaction 
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// Is this transaction to be executed in isolation and not placed onto a commit queue?
        /// </summary>
        public readonly bool Isolated;

        /// <summary>
        /// The current model under which transactions are executed
        /// </summary>
        /// <remarks>See <see cref="TransactionModel"/> for more details.</remarks>
        public static ITransactionModel Model = TransactionModel.Current;

        /// <summary>
        /// Get the count of the number of transactions
        /// </summary>
        public int Count => TransactionsList.Count;

        /// <summary>
        /// Get the current transactions
        /// </summary>
        public TransactionsList TransactionsList { get; private set; }

        /// <summary>
        /// Get the current transaction
        /// </summary>
        public static Transaction Current => Model.Instance;

        private Transaction(int id)
        {
            _id = id;
            TransactionsList = new TransactionsList();
        }

        private Transaction(int id,TransactionsList transactionsList,bool isolated=false)
        {
            _id = id;
            Isolated = isolated;
            TransactionsList = transactionsList??new TransactionsList();
        }

        /// <summary>
        /// Utility debug function to verify whether a transaction is there or not
        /// </summary>
        public static void VerifyTransaction()
        {
            if (Model.TransactionDepth < 1)
            {
                throw new TransactionException("Transaction expected");
            }
        }

        /// <summary>
        /// Utility function to verify that transactions are currently being committed.
        /// </summary>
        public static void VerifyCommitting()
        {
            if (!Model.CommitQueue.IsActive)
            {
                throw new TransactionException("Commit phase expected");
            }
        }

        /// <summary>
        /// The seed id for transactions.
        /// </summary>
        private static int _idSeed;

        /// <summary>
        /// Should we log from this class?
        /// </summary>
        private static readonly Lazy<bool> IsLoggingEnabled = new Lazy<bool>(() => LoggingRules.For(Categories.Transactions).Any);

        /// <summary>
        /// Create a transaction
        /// </summary>
        /// <param name="transactionsList">The optional transactions to see this transaction with.</param>
        /// <param name="isolated">Whether this is an isolated transaction.</param>
        /// <param name="callerMemberName"></param>
        /// <param name="callerLineNumber"></param>
        /// <returns></returns>
        /// <remarks>
        /// An isolated transaction is one which sits away from any other current transactions. One could say have a transaction
        /// being currently active but the code needs to create a transaction for which every transaction is committed by the time the commit has been executed.
        /// This wouldn't happen unless it were an isolated transaction.
        /// Whenever a transaction is created, the transaction depth is incremented. For non isolated transactions if there is already a transaction in play then any new transactions are appended to it.
        /// </remarks>
        public static Transaction Create(TransactionsList transactionsList = default,bool isolated=false,[CallerMemberName] string callerMemberName=default,[CallerLineNumber] int callerLineNumber=default)
        {
            var id = Interlocked.Increment(ref _idSeed);

            if (IsLoggingEnabled.Value)
            {
                Logging.Instance.LogInformation(
                    "Transaction {id} Created, isolated:{isolated},thread:{threadId},with transactions:{withTransactions},transaction depth:{transactionDepth}",
                    id, isolated, Thread.CurrentThread.ManagedThreadId, (transactionsList != default),
                    Model.TransactionDepth);
            }

            Model.Lock.EnterWriteLock();

            try
            {
                ++Model.TransactionDepth;

                // let us check that if the current instance is isolated then any requests whilst active should be isolated as well
                if (!isolated && Model.TransactionDepth > 1 && Model.Instance.Isolated)
                {
                    isolated = true;
                    Logging.Instance.LogWarning("Transaction {id} created inside an existing isolated transaction.Promoting to isolated as well. Called by {calledMember}, {calledLineNumber}",id,callerMemberName,callerLineNumber);
                }

                var transaction = new Transaction(id,transactionsList,isolated);

                Model.SaveInstance();

                Model.Instance = transaction;

                return transaction;
            }
            finally
            {
                Model.Lock.ExitWriteLock();
            }
        }

        /// <summary>
        /// Have we successfully dealt with the transaction
        /// </summary>
        private bool _completed;

        /// <summary>
        /// Commit any transactions.
        /// </summary>
        /// <remarks>
        /// If this is an isolated transaction the transactions are immediately committed.
        /// If not isolated then if the transaction depth is "1" then the transactions are added to a commit queue. If the commit queue isn't currently being processed then
        /// this transactions are then committed. If the commit queue is active then a prior commit call will result in the transactions ultimately being 'committed'.
        /// </remarks>
        public void Commit()
        {
            if (IsLoggingEnabled.Value)
            {
                Logging.Instance.LogInformation(
                    "Transaction {id} Commit starting,thread:{threadId},no transactions:{noTransactions},transaction depth:{transactionDepth}", _id,
                    Thread.CurrentThread.ManagedThreadId, TransactionsList.Count,Model.TransactionDepth);
            }

            var commit = false;


            Model.Lock.EnterWriteLock();

            try
            {
                --Model.TransactionDepth;

                // if not isolated and there are some transactions then add them to the commit queue
                if (!Isolated && TransactionsList.Count > 0)
                {
                    Model.CommitQueue.Add(TransactionsList);
                }

                // if isolated or depth of transactions is back at ground zero then we need to commit
                if (Isolated || Model.TransactionDepth == 0)
                {
                    commit = true;
                }

                Model.RestoreInstance();
            }
            finally
            {
                Model.Lock.ExitWriteLock();
            }

            // should we commit transactions?
            if (commit)
            {
                try
                {
                    // If this is an isolated transaction, then we apply immediately
                    if (Isolated)
                    {
                        TransactionsList.Apply();
                    }
                    else
                    {
                        // This will return immediately if higher level commit currently in play
                        Model.CommitQueue.Commit();                    
                    }

                }
                catch (Exception exception)
                {
                    Logging.Instance.LogError(exception,"Transaction {id} Commit failure",_id);

                    // mark as complete, so as to not generate a duff error
                    _completed = true;
                    throw;
                }
            }

            // indicate we are done
            _completed = true;

            if (IsLoggingEnabled.Value)
            {
                Logging.Instance.LogInformation(
                    "Transaction {id} Commit complete,thread:{threadId},transaction depth:{transactionDepth}", _id,
                    Thread.CurrentThread.ManagedThreadId, Model.TransactionDepth);
            }
        }

        /// <summary>
        /// Rollback any outstanding transactions.
        /// </summary>
        /// <remarks>
        /// For isolated transactions this results in the state prior to the isolated transaction being restored.
        /// </remarks>
        public void Rollback()
        {
            if (IsLoggingEnabled.Value)
            {
                Logging.Instance.LogInformation(
                    "Transaction {id},Rollback,thread:{threadId},transaction depth:{transactionDepth}", _id,
                    Thread.CurrentThread.ManagedThreadId, Model.TransactionDepth);
            }

            Model.Lock.EnterWriteLock();

            try
            {
                --Model.TransactionDepth;
                Model.RestoreInstance();
            }
            finally
            {
                Model.Lock.ExitWriteLock();
            }
            _completed = true;
        }

        /// <summary>
        /// Dispose of the transaction.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public virtual void Dispose()
        {
            if (IsLoggingEnabled.Value)
            {
                Logging.Instance.LogInformation(
                    "Transaction {id} Disposed,thread:{threadId},transaction depth:{transactionDepth},completed:{completed}",
                    _id, Thread.CurrentThread.ManagedThreadId, Model.TransactionDepth, _completed);
            }

            // if not completed we need to decrement the transaction depth.
            if (!_completed)
            {
                Model.Lock.EnterWriteLock();

                try
                {
                    --Model.TransactionDepth;

                    if (Isolated)
                    {
                        Logging.Instance.LogWarning("Isolated transaction {id} with {count} transaction(s) disposed without commit/rollback.",_id,Model.Instance.Count);
                        Model.RestoreInstance();
                    }
                }
                finally
                {
                    Model.Lock.ExitWriteLock();
                }
            }
        }

        /// <summary>
        /// Add a transaction.
        /// </summary>
        /// <param name="action"></param>
        public void Add(Action action)
        {
            VerifyTransaction();
            TransactionsList.Add(action);
        }
    }
}