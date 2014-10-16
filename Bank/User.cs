using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Bank
{
    [Serializable]
    public class User
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public List<IAccount> Accounts;
        private string _password;

        public User(Guid id, string name, List<IAccount> accounts, string password)
        {
            Id = id;
            UserName = name;
            Accounts = accounts;
            _password = password;
        }

        //needed for serialization
        internal User(){}

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
