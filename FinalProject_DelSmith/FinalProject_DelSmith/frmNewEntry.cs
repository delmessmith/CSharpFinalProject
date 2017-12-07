using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject_DelSmith
{
    public partial class frmNewEntry : Form
    {
        private User currentUser;
        private ServicesDataSetTableAdapters.ServicesTableAdapter servicesAdapter;

        public frmNewEntry(User currentUser, ServicesDataSetTableAdapters.ServicesTableAdapter servicesAdapter)
        {
            InitializeComponent();
            this.currentUser = currentUser;
            this.servicesAdapter = servicesAdapter;
        }

        private void frmNewEntry_Load(object sender, EventArgs e)
        {
            txtEnteredBy.Text = currentUser.Username;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            String description = txtDescription.Text;
            int vehicleId = int.Parse(txtVehicleID.Text);
            DateTime serviceDate = dtpServiceDate.Value;
            int serviceMiles = int.Parse(txtServiceMiles.Text);
            DateTime nextServiceDate = dtpNextServiceDate.Value;
            int nextServiceMiles = int.Parse(txtNextServiceMiles.Text);
            String enteredBy = currentUser.Username;
            String notes = txtNotes.Text;

            try
            {
                servicesAdapter.Insert(description, vehicleId, serviceDate, serviceMiles, nextServiceDate, nextServiceMiles, enteredBy, notes);
                lblStatus.Text = "New entry added";
            }
            catch (Exception)
            {

                lblStatus.Text = "Error creating new entry.";
            }
        }
    }
}
