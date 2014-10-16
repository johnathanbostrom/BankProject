using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bank
{
    public partial class UserViewForm : Form
    {
        public UserAccountManager Manager;

        public UserViewForm(UserAccountManager userAccountManager)
        {
            InitializeComponent();
            Manager = userAccountManager;
            UX_AccountsList.DataSource = Manager.Accounts;
        }

        private void UX_AddAccountButton_Click(object sender, EventArgs e)
        {
            try
            {
                Manager.AddAccount();
            }
            catch (UserInputException uie)
            {
                MessageBox.Show(uie.Message);
            }
        }

        private void UX_RemoveAccountButton_Click(object sender, EventArgs e)
        {
            try
            {
                IAccount account = (IAccount) UX_AccountsList.SelectedItem; //not safe.  Is there a way to constrain the type of items that can be added to a list box?
                Manager.RemoveAccount(account);
            }
            catch (UserInputException uie)
            {
                MessageBox.Show(uie.Message);
            }
        }

        private void UX_AccountsList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (UX_AccountsList.SelectedItem == null)
                return;
            Manager.GetAccount((IAccount)UX_AccountsList.SelectedItem);
        }

        private void UX_AccountsList_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
