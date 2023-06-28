using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignInUpWeek99.BL
{
    class MUser
    {
        private string userName;
        private string userPassword;
        private string userRole;
        public MUser(string userName, string userPassword, string userRole)
        {
            this.userName = userName;
            this.userPassword = userPassword;
            this.userRole = userRole;
        }
        public MUser(string userName, string userPassword)
        {
            this.userName = userName;
            this.userPassword = userPassword;
            this.userRole = "NA";
        }
        public string GetUserName()
        {
            return userName;
        }
        public string GetUserPassword()
        {
            return userPassword;
        }
        public string GetUserRoll()
        {
            return userRole;
        }
        public bool IsAdmin()
        {
            if(userRole == "Admin")
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}
