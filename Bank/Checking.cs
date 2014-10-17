using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Bank
{
    [Serializable]
    class Checking : IAccount
    {
        public Guid AccountID { get; private set; }

        public double Balance { get; set; }

        public List<ITransaction> TransactionHistory { get; set; }

        public Checking(Guid id, double balance)
        {
            AccountID = id;
            Balance = balance;
            TransactionHistory = new List<ITransaction>();
        }

        public Checking()
        {
            AccountID = Guid.NewGuid();
            Balance = 0;
            TransactionHistory = new List<ITransaction>();
        }
        public void AddTransactionHistory(ITransaction transaction)
        {
            TransactionHistory.Add(transaction);
        }

        public override string ToString()
        {
            return "ID: " + AccountID + " Balance: " + Balance;
        }
    }
}
