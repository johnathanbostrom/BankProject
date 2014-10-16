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
    public partial class AccountViewForm : Form
    {
        public AccountManager Manager;

        public AccountViewForm(AccountManager accountManager)
        {
            Manager = accountManager;
            InitializeComponent();
            UX_transactionList.DataSource = Manager.Transactions;
        }


        private void AccountViewForm_Load(object sender, EventArgs e)
        {
            UpdateBalanceLabel(Manager.Balance);
        }


        private void UX_depositButton_Click(object sender, EventArgs e)
        {
            UpdateBalanceLabel(Manager.Deposit(10));
        }

        private void ux_withrawButton_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateBalanceLabel(Manager.Withdraw(10));
            }
            catch (UserInputException uie)
            {
                MessageBox.Show(uie.Message);
            }   
        }

        public void UpdateBalanceLabel(double d)
        {
            UX_BalanceLabel.Text = "Balance: " + d;
        }

    }
}
