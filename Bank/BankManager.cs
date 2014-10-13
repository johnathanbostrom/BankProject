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
            User u1 = new User(new Guid(),"Bob", new List<IAccount>(),"abc");
            User u2 = new User(new Guid(), "Ben", new List<IAccount>(), "123");
            userDictionary.Add(u1.UserName, u1);
            userDictionary.Add(u2.UserName, u2);
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
