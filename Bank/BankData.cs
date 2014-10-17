using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Bank
{
    [Serializable]
    class BankData
    {
        private Dictionary<string, User> _userDictionary;
        private Dictionary<Guid, IAccount> _accounts;

        public List<Guid> AccountIDs
        {
            get { return _accounts.Keys.ToList(); }
        } 

        public BankData()
        {
            _userDictionary = new Dictionary<string, User>();
            _accounts= new Dictionary<Guid, IAccount>();
        }

        public BankData(Dictionary<string, User> users, Dictionary<Guid, IAccount> accounts)
        {
            _userDictionary = users;
            _accounts = accounts;
        }

        public void AddAccount(string userId, IAccount account)
        {
            _accounts.Add(account.AccountID, account);
            _userDictionary[userId].Accounts.Add(account);
        }

        public void RemoveAccount(string userID, IAccount account)
        {
            _accounts.Remove(account.AccountID);
            _userDictionary[userID].Accounts.Remove(account);
        }

        public IAccount GetAccount(Guid id)
        {
            return _accounts[id];
        }

        public User GetUserAccountByPassword(string userId, string password)
        {
            if (!_userDictionary.ContainsKey(userId))
                throw new UserInputException("That user could not be found.");
            if (!_userDictionary[userId].CheckPassword(password))
                throw new UserInputException("Password Incorrect.");
            return _userDictionary[userId];
        }

        public void showXML()
        {
            _userDictionary.Values.ToList();
            XElement xml = new XElement("items", _userDictionary.Select(x => new XElement("item", new XAttribute("id", x.Key), new XAttribute("value", x.Value))));
            MessageBox.Show(xml.ToString());
        }
    }
}
