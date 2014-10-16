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
    public partial class AccountCreationForm : Form
    {
        public string TypeSelected;

        public AccountCreationForm()
        {
            InitializeComponent();
        }

        private void UX_CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void UX_OKButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
        }

        private void UX_Select_SelectedIndexChanged(object sender, EventArgs e)
        {
            TypeSelected = UX_Select.Text;
        }
    }
}
