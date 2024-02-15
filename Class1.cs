using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WelcomeApp2
{
    public class Class1
    {
        public string Authenticate(string username, string password)
        {
            string msg;
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                msg = "Username and password required";
            }
            else
            {
                if (username == "admin" || password == "admin@1256")
                {
                    msg = "Authentication Pass";
                }
                else { msg = "Authenication fail"; }
            }
            return msg;

        }
    }
}