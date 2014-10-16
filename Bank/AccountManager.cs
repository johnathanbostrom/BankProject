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
        public double Balance
        {
            get
            {
                return _account.Balance;
            }
        }

        public AccountManager(IAccount account, BankManager bankManager)
        {
            _account = account;
            Transactions = _account.TransactionHistory;
            _bankManager = bankManager;
        }

        //deposit specified Amount and then return the new balance.
        public double Deposit(double d)
        {
            _account.Balance += d;
            Bank.Deposit transaction = new Deposit(DateTime.Now,d,"");
            _account.AddTransactionHistory(transaction);
            return _account.Balance;
        }

        //withdraw the specified Amount and return the new balance.
        public double Withdraw(double d)
        {
            if(_account.Balance < d)
                throw new UserInputException("You may not withdraw a greater Amount than the balance of this account.");
            _account.Balance -= d;
            Withdrawal transaction = new Withdrawal(DateTime.Now, d, "");
            _account.AddTransactionHistory(transaction);
            return _account.Balance;
        }

        public double Transfer(double amount, Guid accountID)
        {
            if(_account.Balance < amount)
                throw new UserInputException("You may not Transfer a greater Amount than the balance of this account.");
            _bankManager.getAccount(accountID).Balance += amount;
            _account.Balance -= amount;
            Bank.Transfer transaction = new Transfer(DateTime.Now, amount, "");
            _account.AddTransactionHistory(transaction);
            return _account.Balance;
        }
    }
}
