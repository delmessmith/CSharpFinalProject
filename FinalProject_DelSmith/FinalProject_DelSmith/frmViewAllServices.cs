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
        public frmViewAllServices()
        {
            InitializeComponent();
        }

        private void frmViewAllServices_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'servicesDataSet.Services' table. You can move, or remove it, as needed.
            this.servicesTableAdapter.Fill(this.servicesDataSet.Services);

        }
    }
}
