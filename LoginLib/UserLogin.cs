using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginLib
{
    public class UserLogin
    {
        public string Login(string userName, string userPwd)
        {
            string result = "";
            if (userName == "Sam1256" && userPwd == "sam@1256")
            {
                result = "Login Success";
                result = "Dashboard";
            }
            else
            {
                result = "Login Failed";
            }
            return result;

        }
    }
}