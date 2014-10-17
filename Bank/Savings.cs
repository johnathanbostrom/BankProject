using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bank
{
    [Serializable]
    internal class Savings : IAccount
    {
        public Guid AccountID { get; private set; }

        public double Balance { get; set; }

        public List<ITransaction> TransactionHistory { get; set; }

        public Savings(Guid id, double balance)
        {
            AccountID = id;
            Balance = balance;
            TransactionHistory = new List<ITransaction>();
        }
        
        public Savings()
        {
            AccountID = Guid.NewGuid();
            Balance = 0;
            TransactionHistory = new List<ITransaction>();
        }

        public void AddTransactionHistory(ITransaction transaction)
        {
            TransactionHistory.Add(transaction);
        }


    }
}
