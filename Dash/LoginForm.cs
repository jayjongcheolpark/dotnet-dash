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
        DBConnect dbConnect;
        public LoginForm()
        {   
            InitializeComponent();
            dbConnect = new DBConnect("alekhin_ex4", "alekhin_user", "KNn0Zj6mo28W");
            try
            {
                dbConnect.OpenConnection();
            }catch(Exception ex)
            {
                MessageBox.Show("Data connection problem: "+ex.Message);
                this.Close();
            }

            this.Focus();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            
                this.Hide();
                FormDashboard formDashboard = new FormDashboard();
                formDashboard.ShowDialog();
                
            
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text.Equals("Password"))
            {
                txtPassword.Text = "";
                txtPassword.isPassword = true;
            }
        }

        private void txtUserName_Enter(object sender, EventArgs e)
        {
            if (txtUserName.Text.Equals("Username"))
            {
                txtUserName.Text = "";
            }

        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text.Equals(string.Empty))
            {
                txtPassword.Text = "Password";
                txtPassword.isPassword = false;
            }
        }

        private void txtUserName_Leave(object sender, EventArgs e)
        {
            if (txtUserName.Text.Equals(string.Empty))
            {
                txtUserName.Text = "Username";
            }
        }
    }
}
