using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Bank
{
    class BankManager
    {
        private Dictionary<string, User> userDictionary;

        public BankManager()
        {
            //load all user data
        }

        public UserAccountManager GetUser(string userId, string password)
        {
            if (!userDictionary.ContainsKey(userId))
                throw new KeyNotFoundException("That user could not be found.");
            if(!userDictionary[userId].CheckPassword(password))
                throw new Exception("Password Incorrect.");
            return new UserAccountManager(userDictionary[userId]);
        }


    }
}
