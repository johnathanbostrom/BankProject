using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Bank
{
    public class BankManager
    {
        private BankData _data;

        public BankManager()
        {
            _data = new BankData();
        }

        public void LoadUserData()
        {    
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
            password = EncryptString(password);
            User u = _data.GetUserAccountByPassword(userId, password);
            UserAccountManager uam = new UserAccountManager(u, this);
            new UserViewForm(uam).Show();
        }

        public void AddAccount(string userId, IAccount account)
        {
            _data.AddAccount(userId, account);
            
        }

        public void RemoveAccount(string userID, IAccount account)
        {
            _data.RemoveAccount(userID, account);
        }

        public IAccount GetAccount(Guid id)
        {
            IAccount account = _data.GetAccount(id);
            if (account == null)
                throw new UserInputException("There is no such Account");
            return account;
        }

        public List<Guid> GetAccountIDs()
        {
            return _data.AccountIDs;
        }

        public void Save()
        {
            Task.Factory.StartNew(SaveBinary);
        }

        //XMl serializer does not work with interfaces. Or dictionaries.  Need to do some serious work with linq to get this working in my project.  
        private void SaveAsXml()
        {
            /*
            var writer = new System.Xml.Serialization.XmlSerializer(typeof(List<User>));
            var file = new System.IO.StreamWriter(@"c:\temp\SerializationOverview.xml");
            writer.Serialize(file,_userDictionary.ToList());
            file.Close();
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

        private string EncryptString(string s)
        {
            byte[] endcodedString = new UTF8Encoding().GetBytes(s);
            byte[] hash = ((HashAlgorithm) CryptoConfig.CreateFromName("MD5")).ComputeHash(endcodedString);
            string encrypted = BitConverter.ToString(hash).Replace("-", string.Empty);
            return encrypted;
        }

    }
}
