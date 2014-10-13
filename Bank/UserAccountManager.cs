using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bank
{
    public class UserAccountManager
    {
        private User _userAccount;

        public readonly List<IAccount> Accounts; 

        public UserAccountManager(User u)
        {
            _userAccount = u;
            Accounts = u.Accounts;
        }

        public void AddAccount(IAccount account)
        {
            Accounts.Add(account);  
        }
    }
}
