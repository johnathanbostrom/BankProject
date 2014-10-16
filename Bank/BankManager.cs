using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Bank
{
    public class BankManager
    {
        private Dictionary<string, User> _userDictionary;
        private Dictionary<Guid, IAccount> _accounts;
        private BankData _data;

        public BankManager()
        {
            _userDictionary = new Dictionary<string, User>();
            _accounts = new Dictionary<Guid, IAccount>();
            _data = new BankData();
        }

        public void LoadUserData()
        {    
            //loadAccountData

            try
            {
                using (Stream stream = File.Open("data.bin", FileMode.Open))
                {
                    BinaryFormatter bin = new BinaryFormatter();

                    _data = (BankData)bin.Deserialize(stream);
                }
            }
            catch (IOException)
            {
                MessageBox.Show("There was an error loading the user data.");
            }
            
        }

        public void OpenUserView(string userId, string password)
        { 
            User u = _data.GetUser(userId, password);
            UserAccountManager uam = new UserAccountManager(u, this);
            new UserViewForm(uam).Show();
        }

        public void AddAccount(IAccount account)
        {
            _accounts.Add(account.AccountID, account);
        }

        public IAccount getAccount(Guid id)
        {
            IAccount account = _accounts[id];
            if (account == null)
                throw new UserInputException("There is no such Account");
            return account;
        }

        public List<Guid> getAccountIDs()
        {
            return _accounts.Keys.ToList();
        }

        public void Save()
        {
            Task.Factory.StartNew(SaveBinary);
        }

        private void SaveAsXml()
        {
            var writer = new System.Xml.Serialization.XmlSerializer(typeof(List<User>));
            System.IO.StreamWriter file = new System.IO.StreamWriter(@"c:\temp\SerializationOverview.xml");
            writer.Serialize(file,_userDictionary.ToList());
            file.Close();/*
            XElement xml = new XElement(
                    "items",
                    userDictionary.Select(x => new XElement("item", new XAttribute("id", x.Key), new XAttribute("value", x.Value)))
                 );
            MessageBox.Show(xml.ToString());*/
        }

        private void SaveBinary()
        {
            try
            {
                using (Stream stream = File.Open("data.bin", FileMode.Create))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, _data);
                }
            }
            catch (IOException)
            {
                MessageBox.Show("well crap, that didn't work.");
            }
        }

    }
}
