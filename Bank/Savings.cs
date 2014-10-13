using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bank
{
    internal class Savings : IAccount
    {
        public Guid AccountID { get; private set; }

        public double Balance { get; private set; }

        public List<ITransaction> TransactionHistory { get; private set; }

        public Savings(Guid id, double balance)
        {
            AccountID = id;
            Balance = balance;
            TransactionHistory = new List<ITransaction>();
        }
        
        public void AddTransactionHistory(ITransaction transaction)
        {
            throw new NotImplementedException();
        }


    }
}
