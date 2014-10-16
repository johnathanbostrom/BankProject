﻿using System;
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
            Withdrawal transaction = new Withdrawal(DateTime.Now, -d, "");
            _account.AddTransactionHistory(transaction);
            return Balance;
        }

        //need to add transaction history to both accounts!
        public double Transfer()
        {
            //show form and chek if we said OK to the transfer
            TransferForm form = new TransferForm(_bankManager.getAccountIDs());
            DialogResult result = (form.ShowDialog());
            if (result != DialogResult.OK)
                return Balance;
            double amount = form.Amount;
            Guid accountSelected = form.AccountSelected;

            if(Balance < amount)
                throw new UserInputException("You may not Transfer a greater Amount than the balance of this account.");
            IAccount otherAccount = _bankManager.getAccount(accountSelected);
            otherAccount.Balance += amount;
            _account.Balance -= amount;
            _account.AddTransactionHistory(new Transfer(DateTime.Now, -amount, _account.AccountID, accountSelected, ""));
            otherAccount.AddTransactionHistory(new Transfer(DateTime.Now, amount, accountSelected, _account.AccountID, ""));
            return Balance;
        }
    }
}
