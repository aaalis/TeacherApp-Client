using System;
using System.Collections.Generic;
using System.Text;

namespace TeacherApp.Models
{
    public class AuthUser
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

		private static AuthUser instance;

		private AuthUser()
		{

		}

		public static AuthUser Instance()
		{
			if (instance == null)
			{
				instance = new AuthUser();
			}
			return instance;
		}
	}
}
