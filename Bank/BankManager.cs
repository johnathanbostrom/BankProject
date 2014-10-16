using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bank
{
    public class BankManager
    {
        private Dictionary<string, User> userDictionary;
        private Dictionary<Guid, IAccount> accounts; 

        public BankManager()
        {
            userDictionary = new Dictionary<string, User>();
            accounts = new Dictionary<Guid, IAccount>();
        }

        public void LoadUserData()
        {
            
            //loadAccountData
            Checking c1 = new Checking(Guid.NewGuid(), 155);
            Checking c2 = new Checking(Guid.NewGuid(), 255);
            Checking c3 = new Checking(Guid.NewGuid(), 355);
            accounts.Add(c1.AccountID, c1);
            accounts.Add(c2.AccountID, c2);
            accounts.Add(c3.AccountID, c3);
            List<IAccount> accounts1 = new List<IAccount>();
            accounts1.Add(c1);
            accounts1.Add(c2);
            List<IAccount> accounts2 = new List<IAccount>();
            accounts2.Add(c3);
            //load user data
            User u1 = new User(Guid.NewGuid(),"Bob", accounts1,"abc");
            User u2 = new User(Guid.NewGuid(), "Ben", accounts2, "123");
            userDictionary.Add(u1.UserName, u1);
            userDictionary.Add(u2.UserName, u2);
            
        }

        public void GetUser(string userId, string password)
        {

            if (!userDictionary.ContainsKey(userId))
                throw new UserInputException("That user could not be found.");
            if(!userDictionary[userId].CheckPassword(password))
                throw new UserInputException("Password Incorrect.");
            UserAccountManager uam = new UserAccountManager(userDictionary[userId], this);
            new UserViewForm(uam).Show();
        }

        public void AddAccount(IAccount account)
        {
            accounts.Add(account.AccountID, account);
        }

        public IAccount getAccount(Guid id)
        {
            IAccount account = accounts[id];
            if (account == null)
                throw new UserInputException("There is no such Account");
            return account;
        }

    }
}
