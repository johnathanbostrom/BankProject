using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bank
{
    class Checking : IAccount
    {
        public Guid AccountID { get; private set; }

        public double Balance { get; private set; }

        public List<ITransaction> TransactionHistory { get; private set; }

        public void AddTransactionHistory(ITransaction transaction)
        {
            throw new NotImplementedException();
        }
    }
}
