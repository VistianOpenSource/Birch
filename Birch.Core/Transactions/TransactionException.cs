using System;

namespace Birch.Transactions
{
    public class TransactionException : Exception
    {
        public TransactionException(string message):base(message)
        {
        }
    }
}