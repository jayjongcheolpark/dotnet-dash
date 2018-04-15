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
        static DBConnect _dbConnect;
        public static DBConnect DbConnection
        {
            get => _dbConnect;
            set => _dbConnect = value;
        }
        public LoginForm()
        {   
            InitializeComponent();
            _dbConnect = new DBConnect("alekhin_ex4", "alekhin_user", "KNn0Zj6mo28W");
            try
            {
                _dbConnect.OpenConnection();
            }catch(Exception ex)
            {
                MessageBox.Show("Data connection problem: "+ex.Message);
                this.Close();
            }

            this.Focus();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            try
            {
                User user = _dbConnect.verifyUser(txtUserName.Text.Trim(), txtPassword.Text.Trim());
                if (user != null) {
                    this.Hide();
                    FormDashboard.DbConnection = _dbConnect;
                    FormDashboard.User = user;
                    FormDashboard formDashboard = new FormDashboard();
                    formDashboard.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Wrong username or password");

                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

            }  
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
