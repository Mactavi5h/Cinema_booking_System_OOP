using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema_booking_System_OOP
{
    internal class Login
    {
        //Apply Encapsulation for user name and password
        private string username;
        private string password;

        public string Username
        {
            get { return username; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    username = value;
                }
                else
                {
                    throw new ArgumentException("Username cannot be empty.");
                }
            }
        }
        public string Password
        {
            get { return password; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    password = value;
                }
                else
                {
                    throw new ArgumentException("Password cannot be empty.");
                }
            }
        }
       
    }
}
