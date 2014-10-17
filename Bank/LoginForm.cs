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

        public LoginForm(BankManager manager)
        {
            InitializeComponent();
            Manager = manager;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UX_PasswordBox.PasswordChar = '*';
        }

        private void UX_Button_Click(object sender, EventArgs e)
        {
            try
            {
                Manager.OpenUserView(UX_UserNameTextBox.Text, UX_PasswordBox.Text);
            }
            catch (UserInputException exception)
            {
                MessageBox.Show(exception.Message);
            }
        }


    }
}
