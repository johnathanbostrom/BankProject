using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bank
{
    [Serializable]
    public class UserAccountManager
    {
        private User _userAccount;
        private BankManager _bankManager;

        public List<IAccount> Accounts
        {
            get { return _userAccount.Accounts; }
        }


        public UserAccountManager(User u, BankManager bankManager)
        {
            _userAccount = u;
            _bankManager = bankManager;
        }

        public void AddAccount()
        {
            AccountCreationForm acf = new AccountCreationForm();
            DialogResult accountCreationResult = acf.ShowDialog();
            if (accountCreationResult != DialogResult.Yes)
                return;
            string accountType = acf.TypeSelected;
            IAccount account = CreateAccount(accountType);
            _bankManager.AddAccount(_userAccount.UserName, account);
        }

        //use reflection to create the proper type of account based on the user's selection
        public IAccount CreateAccount(string accountType)
        {
            Type t = (Type.GetType("Bank." + accountType));
            if (t == null)
                throw new UserInputException("An account of that type could not be created");
            return (IAccount) Activator.CreateInstance(t);
        }

        public void RemoveAccount(IAccount account)
        {
            if (account == null)
                throw new UserInputException("Please select an account to close");
            DialogResult confirm = MessageBox.Show("Are you sure you want to close account number" + account.AccountID + "?", "Confirm", MessageBoxButtons.YesNo);
            if (confirm != DialogResult.Yes)
                return;
            if (account.Balance != 0)
                throw new UserInputException("Cannot close an account with a non zero balance");
            _bankManager.RemoveAccount(_userAccount.UserName, account);
        }

        public void ViewAccount(IAccount account)
        {
            AccountManager am = new AccountManager(account, _bankManager);
            new AccountViewForm(am).Show();
        }
    }
}
