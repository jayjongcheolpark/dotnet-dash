using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dash
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (AdminDataController.VerifyAdminAccount(txtUserName.Text, txtPassword.Text))
            {
              FormDashboard formDashboard = new FormDashboard();
              formDashboard.ShowDialog();
              this.Hide();
            }
        }
  }
}
