using System;
using System.Collections.Generic;
using System.Text;

namespace TeacherApp.Models
{
    public class AuthUser : User
    {
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
