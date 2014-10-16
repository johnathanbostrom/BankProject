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
    public partial class TransferForm : Form
    {
        private List<Guid> _accounts;
        public Guid AccountSelected;
        public double Amount;

        public TransferForm(List<Guid> accounts)
        {
            InitializeComponent();
            _accounts = accounts;
            UX_AccountList.DataSource = _accounts;
        }

        private void UX_OKButton_Click(object sender, EventArgs e)
        {
            if (UX_AccountList.SelectedItem == null)
                throw new UserInputException("Plese select an Account to transfer funds to.");
            if(!double.TryParse(UX_DepositInput.Text, out Amount))
                throw new UserInputException("Please enter an amount to transfer.");
            AccountSelected = (Guid)UX_AccountList.SelectedItem;
            DialogResult = DialogResult.OK;
        }

        private void UX_CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }


    }
}
