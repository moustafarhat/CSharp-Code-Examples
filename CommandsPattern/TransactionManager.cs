using CommandsPattern.interfaces;
using System.Collections.Generic;
using System.Linq;

namespace CommandsPattern
{
    public class TransactionManager
    {
        private readonly List<ITransaction> _transactions = new List<ITransaction>();

        public bool HasPendingTransactions
        {
            get { return _transactions.Any(x => !x.IsCompleted); }
        }

        public void AddTransaction(ITransaction transaction)
        {
            _transactions.Add(transaction);
        }

        public void ProcessPendingTransactions()
        {
            // Apply transactions in the order they were added.
            foreach (var transaction in _transactions.Where(x => !x.IsCompleted))
            {
                transaction.Execute();
            }
        }
    }
}