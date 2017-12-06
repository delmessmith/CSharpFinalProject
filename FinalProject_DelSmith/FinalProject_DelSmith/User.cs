using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_DelSmith
{
    public class User
    {
        private String mUsername;
        private String mPassword;
        private String mRole;

        public String Username
        {
            get { return mUsername; }
        }

        public String Password
        {
            get { return mPassword; }
            set { mPassword = value; }
        }

        public String Role
        {
            get { return mRole; }
            set { mRole = value; }
        }

        public User(String username, String password, String role)
        {
            mUsername = username;
            mPassword = password;
            mRole = role;
        }
    }
}
