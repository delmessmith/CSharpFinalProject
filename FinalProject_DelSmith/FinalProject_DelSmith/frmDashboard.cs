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

        private ServicesDataSetTableAdapters.UsernamesTableAdapter loginAdapter = new 
            ServicesDataSetTableAdapters.UsernamesTableAdapter();

        public List<User> users = new List<User>();
        public User currentUser;

        public frmDashboard()
        {
            InitializeComponent();
        }

        private void mnuViewAll_Click(object sender, EventArgs e)
        {
            frmViewAllServices viewAllServices = new frmViewAllServices();
            viewAllServices.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            errProvider.Clear();
            lblStatus.Text = "";
            bool validInput = true;
            String username = txtUsername.Text;
            String password = txtPassword.Text;

            if (!username.Contains("@") || !username.Contains("."))
            {
                validInput = false;
                errProvider.SetError(txtUsername, "Please enter a valid email for the username");
            }

            if (validInput)
            {
                if (loginAdapter.Search(loginAdapter.GetData(), username, password) > 0)
                {
                    panelLogin.Hide();
                    panelMain.Show();
                    panelMain.Dock = DockStyle.Fill;
                    this.AcceptButton = null;
                    txtPassword.Clear();
                    txtUsername.Clear();

                    foreach(User u in users)
                    {
                        if (u.Username == username)
                        {
                            currentUser = u;
                        }
                    }

                    MessageBox.Show("Hello " + currentUser.Username + "! Welcome back!" + "\n" +
                        currentUser.Username + ":" + currentUser.Password + ":" + currentUser.Role);
                }
                else if (loginAdapter.SearchUsername(loginAdapter.GetData(), username) > 0)
                {
                    lblStatus.Text = "Invalid password";
                }
                else
                {
                    lblStatus.Text = "Invalid credentials";
                }
            }
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            panelLogin.Dock = DockStyle.Fill;
            this.AcceptButton = btnLogin;

            //get users from database and store them in the users list
            DataTable logins = loginAdapter.GetData();
            foreach (DataRow r in logins.Rows)
            {
                User aUser = new User(r[0].ToString(), r[1].ToString(), r[2].ToString());
                users.Add(aUser);
            }
        }

        private void mnuFileExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmDashboard_Activated(object sender, EventArgs e)
        {
            
        }

        private void mnuFileLogout_Click(object sender, EventArgs e)
        {
            panelLogin.Show();
            panelMain.Hide();
            panelLogin.Dock = DockStyle.Fill;
            this.AcceptButton = btnLogin;
            currentUser = null;
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mnuLoginsViewAll_Click(object sender, EventArgs e)
        {
            if (currentUser.Role == "Admin" || currentUser.Role == "Manager")
            {
                frmViewAllLogins viewAllLogins = new frmViewAllLogins();
                viewAllLogins.ShowDialog();
            }
            else
            {
                MessageBox.Show("You do not have the proper permissions to view this. Please log in with an admin or " +
                    "manager account.", "Invalid Account Type", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void mnuLoginsNew_Click(object sender, EventArgs e)
        {
            if (currentUser.Role == "Admin" || currentUser.Role == "Manager")
            {
                frmNewLogin newLogin = new frmNewLogin();
                newLogin.ShowDialog();
            }
            else
            {
                MessageBox.Show("You do not have the proper permissions to view this. Please log in with an Admin or " +
                    "Manager account.", "Invalid Account Type", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
