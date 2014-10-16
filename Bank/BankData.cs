using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bank
{
    [Serializable]
    class BankData
    {
        private Dictionary<string, User> _userDictionary;
        private Dictionary<Guid, IAccount> _accounts;

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

        public User GetUser(string userId, string password)
        {
            if (!_userDictionary.ContainsKey(userId))
                throw new UserInputException("That user could not be found.");
            if (!_userDictionary[userId].CheckPassword(password))
                throw new UserInputException("Password Incorrect.");
            return _userDictionary[userId];
        }
    }
}
