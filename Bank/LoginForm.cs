using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Bank
{
    public partial class LoginForm : Form
    {
        public BankManager Manager;

        public LoginForm()
        {
            InitializeComponent();
            Manager = new BankManager();
            Manager.LoadUserData();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void UX_Button_Click(object sender, EventArgs e)
        {
            try
            {
                UserAccountManager uam = Manager.GetUser(UX_UserNameTextBox.Text, UX_PasswordBox.Text);
                new UserViewForm(uam).Show();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }


    }
}
