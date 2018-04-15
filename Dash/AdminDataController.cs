using Dash.AdminDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dash
{
  class AdminDataController
  {
    static public bool VerifyAdminAccount(string inputUsername, string inputPassword)
    {
      AdminDataSet admindataset = new AdminDataSet();

      AdminTableAdapter adminTableAdapter = new AdminTableAdapter();

      adminTableAdapter.Fill(admindataset.Admin);

      string username = admindataset.Admin[0].Username;
      string password = admindataset.Admin[0].Password;
      if (username.Equals(inputUsername) && password.Equals(inputPassword))
      {
        return true;
      }
      else
      {
        return true;
      }

    }
  }
}
