using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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
            if(d < 0)
                throw new UserInputException("You cannot deposit a negative amount.");
            _account.Balance += d;
            Bank.Deposit transaction = new Deposit(DateTime.Now,d,"");
            _account.AddTransactionHistory(transaction);
            Save();
            return _account.Balance;
        }

        //withdraw the specified Amount and return the new balance.
        public double Withdraw(double d)
        {
            if(d< 0 || _account.Balance < d)
                throw new UserInputException("You may not withdraw a greater Amount than the balance of this account.");
            _account.Balance -= d;
            Withdrawal transaction = new Withdrawal(DateTime.Now, d, "");
            _account.AddTransactionHistory(transaction);
            Save();
            return Balance;
        }

        public void Transfer(Guid accountSelected, double amount)
        {

            IAccount otherAccount = _bankManager.GetAccount(accountSelected);
            otherAccount.Balance += amount;
            _account.Balance -= amount;
            Bank.Transfer transfer = new Transfer(DateTime.Now, amount,_account.AccountID, accountSelected, "");
            _account.AddTransactionHistory(transfer);
            otherAccount.AddTransactionHistory(transfer);
            Save();
        }

        public void ShowTransferForm()
        {
            TransferForm form = new TransferForm(_bankManager.GetAccountIDs());
            DialogResult result = (form.ShowDialog());
            if (result != DialogResult.OK)
                return;
            double amount = form.Amount;
            Guid accountSelected = form.AccountSelected;
            if (amount < 0)
            {
                MessageBox.Show("You cannot transfer a negative amount.");
                return;
            }

            if (Balance < amount)
            {
                MessageBox.Show("You may not Transfer a greater Amount than the balance of this account.");
                return;
            }
            Transfer(accountSelected, amount);
        }

        private void Save()
        {
            _bankManager.Save();  
        }
    }
}
