using System;
using System.Collections.Generic;
using System.Text;

namespace TeacherApp.Models
{
    public class User
    {
        private string login;
        public string Login
        {
            get { return login; }
            set { login = value; }
        }

        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public User()
        {

        }
    }
}
