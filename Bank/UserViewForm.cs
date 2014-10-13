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
        }
    }
}
