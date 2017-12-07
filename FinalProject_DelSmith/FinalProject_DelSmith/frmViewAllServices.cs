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
    public partial class frmViewAllServices : Form
    {
        private ServicesDataSetTableAdapters.ServicesTableAdapter servicesAdapter = new 
            ServicesDataSetTableAdapters.ServicesTableAdapter();

        private ServicesDataSetTableAdapters.VehiclesTableAdapter vehiclesAdapter = new
            ServicesDataSetTableAdapters.VehiclesTableAdapter();

        private User currentUser;

        private List<ServiceRecord> serviceRecords = new List<ServiceRecord>();
        private List<Vehicle> vehicles;

        public frmViewAllServices(User currentUser, List<Vehicle> vehicles)
        {
            InitializeComponent();
            this.currentUser = currentUser;
            this.vehicles = vehicles;
        }

        private void frmViewAllServices_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'servicesDataSet.Services' table. You can move, or remove it, as needed.
            this.servicesTableAdapter.Fill(this.servicesDataSet.Services);

            //get records from database and store them in the serviceRecords list
            DataTable records = servicesAdapter.GetData();
            foreach (DataRow r in records.Rows)
            {
                int serviceId = int.Parse(r[0].ToString());
                String description = r[1].ToString();
                int vehicleId = int.Parse(r[2].ToString());
                DateTime serviceDate = DateTime.Parse(r[3].ToString());
                int serviceMiles = int.Parse(r[4].ToString());
                DateTime nextServiceDate = DateTime.Parse(r[5].ToString());
                int nextServiceMiles = int.Parse(r[6].ToString());
                String enteredBy = r[7].ToString();
                String notes = r[8].ToString();

                ServiceRecord aServiceRecord = new ServiceRecord(serviceId, description, vehicleId, serviceDate,
                    serviceMiles, nextServiceDate, nextServiceMiles, enteredBy, notes);
                serviceRecords.Add(aServiceRecord);
            }


            List<int> vehicleIds = new List<int>();

            foreach (ServiceRecord sr in serviceRecords)
            {
                if (!vehicleIds.Contains(sr.VehicleID))
                {
                    vehicleIds.Add(sr.VehicleID);
                }
            }

            foreach (int id in vehicleIds)
            {
                DateTime now = DateTime.Now;
                DateTime mostRecentDate = DateTime.MinValue;
                ServiceRecord mostRecentRecord = null;

                foreach (ServiceRecord sr in serviceRecords)
                {
                    if (sr.VehicleID == id)
                    {
                        if (sr.ServiceDate > mostRecentDate)
                        {
                            mostRecentDate = sr.ServiceDate;
                            mostRecentRecord = sr;
                        }
                    }
                }

                if (mostRecentRecord != null)
                {
                    if (mostRecentRecord.NextServiceDate < now)
                    {
                        MessageBox.Show("Vehicle #" + id + " is overdue for a(n) " + mostRecentRecord.Description + ". The last service was done  " + mostRecentRecord.ServiceDate);
                    }
                }
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
