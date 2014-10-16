using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bank
{
    public class AccountManager
    {
        private IAccount _account;
        private BankManager _bankManager;
        public List<ITransaction> Transactions;
        public double Balance { get; set; }

        public AccountManager(IAccount account, BankManager bankManager)
        {
            _account = account;
            Transactions = _account.TransactionHistory;
            Balance = _account.Balance;
            _bankManager = bankManager;
        }

        //deposit specified amount and then return the new balance.
        public double Deposit(double d)
        {
            _account.Balance += d;
            return _account.Balance;
        }

        //withdraw the specified amount and return the new balance.
        public double Withdraw(double d)
        {
            if(_account.Balance < d)
                throw new UserInputException("You may not withdraw a greater amount than the balance of this account.");
            _account.Balance -= d;
            return _account.Balance;
        }

        public double Transfer(double amount, Guid accountID)
        {
            if(_account.Balance < amount)
                throw new UserInputException("You may not Transfer a greater amount than the balance of this account.");
            return 0;
        }
    }
}
