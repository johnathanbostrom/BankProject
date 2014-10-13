using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Bank
{
    public class BankManager
    {
        private Dictionary<string, User> userDictionary;

        public BankManager()
        {
            userDictionary = new Dictionary<string, User>();
        }

        public void LoadUserData()
        {
            //load user data
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
