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
            UpdateBalanceLabel();
        }


        private void UX_depositButton_Click(object sender, EventArgs e)
        {
            double amount;
            if (!double.TryParse(UX_DepositText.Text, out amount))
            {
                MessageBox.Show("Please enter a valid amount to deposit");
                return;
            }
            Manager.Deposit(amount);
            UpdateBalanceLabel();
            
        }

        private void ux_withrawButton_Click(object sender, EventArgs e)
        {
            double amount;
            if (!double.TryParse(UX_WithdrawText.Text, out amount))
            {
                MessageBox.Show("Please enter a valid amount to withdraw");
                return;
            }

            try
            {
                Manager.Withdraw(amount);
                UpdateBalanceLabel();
            }
            catch (UserInputException uie)
            {
                MessageBox.Show(uie.Message);
            }   
        }

        private void UX_transferButton_Click(object sender, EventArgs e)
        {
            try
            {
                Manager.ShowTransferForm();
                UpdateBalanceLabel();
            }
            catch (UserInputException uie)
            {
                MessageBox.Show(uie.Message);
            }
        }

        public void UpdateBalanceLabel()
        {
            UX_BalanceLabel.Text = "Balance: " + Manager.Balance;
        }
    }
}
