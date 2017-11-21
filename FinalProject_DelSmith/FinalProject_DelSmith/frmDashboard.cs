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
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void mnuViewAll_Click(object sender, EventArgs e)
        {
            frmViewAllServices viewAllServices = new frmViewAllServices();
            viewAllServices.ShowDialog();
        }
    }
}
