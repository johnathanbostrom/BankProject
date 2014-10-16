using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bank
{
    public interface IAccount
    {
        Guid AccountID { get; }
        double Balance { get; set; }
        List<ITransaction> TransactionHistory { get; set; }
        void AddTransactionHistory(ITransaction transaction);
    }
}
