using System;
using System.Collections.Generic;

namespace Birch.Transactions
{
    /// <summary>
    /// An ordered list of <see cref="Action"/> comprising a transaction.
    /// </summary>
    public class TransactionsList
    {
        private readonly List<Action> _transactions;

        /// <summary>
        /// Execute all of the <see cref="Action"/> transactions in order.
        /// </summary>
        public void Apply()
        {
            foreach (var transaction in _transactions)
            {
                transaction();
            }
        }

        /// <summary>
        /// Return the number of transactions
        /// </summary>
        public int Count => _transactions.Count;


        /// <summary>
        /// Create a new , empty transactions list with no transactions.
        /// </summary>
        public TransactionsList()
        {
            _transactions = new List<Action>();
        }

        /// <summary>
        /// Create a new transactions list from a specified enumeration of <see cref="Action"/>
        /// </summary>
        /// <param name="transactions"></param>
        public TransactionsList(IEnumerable<Action> transactions)
        {
            _transactions = new List<Action>(transactions);
        }

        /// <summary>
        /// Create a new transactions list from a provided <see cref="TransactionsList"/>
        /// </summary>
        /// <param name="transactionsList"></param>
        public TransactionsList(TransactionsList transactionsList)
        {
            _transactions = transactionsList != null ? new List<Action>(transactionsList._transactions) : new List<Action>();
        }

        /// <summary>
        /// Add an <see cref="Action"/> to the list.
        /// </summary>
        /// <param name="action"></param>
        public void Add(Action action)
        {
            _transactions.Add(action);
        }
    }
}