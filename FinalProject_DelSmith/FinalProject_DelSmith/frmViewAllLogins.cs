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
    public partial class frmViewAllLogins : Form
    {
        public frmViewAllLogins()
        {
            InitializeComponent();
        }

        private void frmViewAllLogins_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'servicesDataSet.Usernames' table. You can move, or remove it, as needed.
            this.usernamesTableAdapter.Fill(this.servicesDataSet.Usernames);
        }
    }
}
