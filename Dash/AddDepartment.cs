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
    public partial class AddDepartment : Form
    {
        private string _departmentName;
        private string _departmentAddress;

        public string DepartmentName
        {
            get => _departmentName;
            set => _departmentName = value;
        }
        public string DepartmentAddress
        {
            get => _departmentAddress;
            set => _departmentAddress = value;
        }
        public AddDepartment()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtDepartmentName.Text.Equals(string.Empty) || txtDepartmentAddress.Text.Equals(string.Empty))
            {
                MessageBox.Show("Both fields are required");
            }
            else
            {
                this.DepartmentName = txtDepartmentName.Text;
                this.DepartmentAddress = txtDepartmentAddress.Text;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void txtDepartmentName_Enter(object sender, EventArgs e)
        {
            if(txtDepartmentName.Text == "Department Name")
            {
                txtDepartmentName.Text = "";
            }
        }

        private void txtDepartmentAddress_Enter(object sender, EventArgs e)
        {
            if (txtDepartmentAddress.Text == "Department Address")
            {
                txtDepartmentAddress.Text = "";
            }
        }

        private void txtDepartmentName_Leave(object sender, EventArgs e)
        {
            if (txtDepartmentName.Text.Equals(string.Empty))
            {
                txtDepartmentName.Text = "Department Name";
            }
        }

        private void txtDepartmentAddress_Leave(object sender, EventArgs e)
        {
            if (txtDepartmentAddress.Text.Equals(string.Empty))
            {
                txtDepartmentAddress.Text = "Department Address";
            }
        }
    }
}
