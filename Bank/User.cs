using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bank
{
    public class User
    {
        public Guid Id { get; private set; }
        public string UserName { get; private set; }
        public List<IAccount> Accounts;
        private string _password;

        public User(Guid id, string name, List<IAccount> accounts, string password)
        {
            Id = id;
            UserName = name;
            Accounts = accounts;
            _password = password;
        }

        public bool CheckPassword(string pass)
        {
            return pass == _password;
        }

        public bool ChangePassword(string oldPass, string newPass)
        {
            if (!CheckPassword(oldPass))
                return false;
            _password = newPass;
            return true;
        }
    }
}
