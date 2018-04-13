using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
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
    public partial class FormDashboard : Form
    {
        List<Department> departmentList = new List<Department>();
        BindingSource departmentBnd = new BindingSource();


        public FormDashboard()
        {
            InitializeComponent();
            departmentBnd.DataSource = departmentList;
            lsDepartment.DataSource = departmentBnd;

            departmentList.Add(new Department("1", "Admissions Department Davis Campus", "7899 McLaughlin Rd, Brampton, ON L6Y 5H9"));
            departmentList.Add(new Department("2", "IT Department Davis Campus", "7899 McLaughlin Rd, Brampton, ON L6Y 5H9"));
            departmentList.Add(new Department("3", "Printing Center Davis Campus", "7899 McLaughlin Rd, Brampton, ON L6Y 5H9"));
            departmentList.Add(new Department("4", "Student Center Trafalgar Campus", "1430 Trafalgar Rd, Oakville, ON L6H 2L1"));
            departmentList.Add(new Department("5", "Accounting Center Trafalgar Campus", "1430 Trafalgar Rd, Oakville, ON L6H 2L1"));
            departmentList.Add(new Department("6", "Tutor Center Trafalgar Campus", "1430 Trafalgar Rd, Oakville, ON L6H 2L1"));
            departmentBnd.ResetBindings(false);


        }

        private void tabClick_Click(object sender, EventArgs e)
        {
            indicator.Top = ((Control)sender).Top;
            indicator.Height = ((Control)sender).Height;
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            userInfoTab.IconZoom = 50.0;
            locationsTab.IconZoom = 50.0;
            employeesTab.IconZoom = 50.0;
            salaryTab.IconZoom = 50.0;
            btnEditPersonalInformation.IconZoom = 60.0;
            btnEditJobInformation.IconZoom = 60.0;
            btnAddDepartment.IconZoom = 50.0;
            btnDeleteDepartment.IconZoom = 50.0;

            gmap.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            gmap.SetPositionByKeywords("1430 Trafalgar Rd, Oakville, ON L6H 2L1");
            gmap.DragButton = MouseButtons.Left;
            gmap.ShowCenter = false;
            lbMapPos.Text = "lat: " + gmap.Position.Lat + " lng: " + gmap.Position.Lng;

            GMapOverlay markers = new GMapOverlay("markers");
            markers.Markers.Add( new GMarkerGoogle(
                gmap.Position,
                GMarkerGoogleType.blue_small));
            gmap.Overlays.Add(markers);

        }

        private void userInfoTab_Click(object sender, EventArgs e)
        {
            disablePanels();
            plUserInfo.Dock = DockStyle.Fill;
            plUserInfo.Visible = true;
            indicatorChange(sender, e);
        }

        private void locationsTab_Click(object sender, EventArgs e)
        {
            disablePanels();
            plLocations.Dock = DockStyle.Fill;
            plLocations.Visible = true;
            indicatorChange(sender, e);
        }

        private void employeesTab_Click(object sender, EventArgs e)
        {
            disablePanels();
            plEmployees.Dock = DockStyle.Fill;
            plEmployees.Visible = true;
            indicatorChange(sender, e);
        }

        private void salaryTab_Click(object sender, EventArgs e)
        {
            disablePanels();
            plSalary.Dock = DockStyle.Fill;
            plSalary.Visible = true;
            indicatorChange(sender, e);
        }

        private void indicatorChange(object sender, EventArgs e)
        {
            indicator.Top = ((Control)sender).Top;
            indicator.Height = ((Control)sender).Height;
        }

        private void disablePanels()
        {
            plUserInfo.Dock = DockStyle.None;
            plUserInfo.Visible = false;
            plLocations.Dock = DockStyle.None;
            plLocations.Visible = false;
            plEmployees.Dock = DockStyle.None;
            plEmployees.Visible = false;
            plSalary.Dock = DockStyle.None;
            plSalary.Visible = false;
        }

        private void txtSearchLocation_Enter(object sender, EventArgs e)
        {
            if (txtSearchLocation.Text == "Search Location")
            {
                txtSearchLocation.Text = "";
            }
        }

        private void txtSearchLocation_OnValueChanged(object sender, EventArgs e)
        {
            if (txtSearchLocation.Text != string.Empty)
            {
                gmap.SetPositionByKeywords(txtSearchLocation.Text);
            }
        }

        private void txtSearchLocation_Leave(object sender, EventArgs e)
        {
            if (txtSearchLocation.Text == string.Empty)
            {
                txtSearchLocation.Text = "Search Location";
            }
        }

        private void lsDepartment_MouseClick(object sender, MouseEventArgs e)
        {
            if (lsDepartment.SelectedItem != null)
            {
                txtSearchLocation.Text = ((Department)lsDepartment.SelectedItem).Address;
            }
        }

        private void txtSearchDepartment_OnValueChanged(object sender, EventArgs e)
        {

            string q = txtSearchDepartment.Text;
            if (q != string.Empty)
            {
                int index = lsDepartment.FindString(q);
                if (index != -1)
                    lsDepartment.SetSelected(index, true);
            }
            txtSearchDepartment.Focus();

        }

        private void txtSearchDepartment_Leave(object sender, EventArgs e)
        {
            if (txtSearchDepartment.Text == string.Empty)
            {
                txtSearchDepartment.Text = "Search Department";
            }
        }

        private void txtSearchDepartment_Enter(object sender, EventArgs e)
        {
            if (txtSearchDepartment.Text == "Search Department")
            {
                txtSearchDepartment.Text = "";
            }
        }

        private void btnChangeView_Click(object sender, EventArgs e)
        {
            if (gmap.MapProvider.Equals(GMap.NET.MapProviders.GoogleMapProvider.Instance))
            {
                gmap.MapProvider = GMap.NET.MapProviders.GoogleHybridMapProvider.Instance;
            }
            else
            {
                gmap.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            }
            
        }

        private void gmap_MouseDown(object sender, MouseEventArgs e)
        {
            lbMapPos.Text = "lat: " + gmap.Position.Lat + " lng: " + gmap.Position.Lng;
        }

        private void gmap_OnPositionChanged(GMap.NET.PointLatLng point)
        {
            lbMapPos.Text = "lat: " + gmap.Position.Lat + " lng: " + gmap.Position.Lng;
        }

        private void bbtnAddDepartment_Click(object sender, EventArgs e)
        {
            AddDepartment addDepartment = new AddDepartment();
            addDepartment.ShowDialog();
            if (addDepartment.DialogResult.Equals(DialogResult.OK))
            {
                MessageBox.Show("Add Successful!");
                departmentList.Add(new Department("4",addDepartment.DepartmentName, addDepartment.DepartmentAddress));
                departmentBnd.ResetBindings(false);
            }
        }
    }
}
