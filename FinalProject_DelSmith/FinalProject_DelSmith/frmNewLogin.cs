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
    public partial class frmNewLogin : Form
    {
        private ServicesDataSetTableAdapters.UsernamesTableAdapter loginAdapter = new
            ServicesDataSetTableAdapters.UsernamesTableAdapter();

        public frmNewLogin()
        {
            InitializeComponent();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            errProvider.Clear();
            bool validInput = true;
            String username = txtUsername.Text;
            String password = txtPassword.Text;
            String role = "";

            if (cboRole.Text == "")
            {
                errProvider.SetError(cboRole, "Please enter a valid role");
                validInput = false;
            }
            else
            {
                role = cboRole.Text;
            }

            if (!username.Contains("@") || !username.Contains("."))
            {
                validInput = false;
                errProvider.SetError(txtUsername, "Please enter a valid email for the username");
            }

            if (password.Length < 4)
            {
                validInput = false;
                errProvider.SetError(txtPassword, "Please enter a password that is at least 4 characters long");
            }

            if (validInput)
            {
                try
                {
                    loginAdapter.Insert(username, password, role);
                    lblStatus.Text = "New login added";
                }
                catch (Exception)
                {

                    lblStatus.Text = "Error creating new login. Username already exists";
                }
            }
        }
    }
}
