using System;
using System.Collections.Generic;
using System.Text;

namespace TeacherApp.Models
{
    public class Discipline
    {
		private int id;
		public int Id
		{
			get { return id; }
			set { id = value; }
		}

		private string name;
		public string Name
        {
			get { return name; }
			set { name = value; }
		}

		public Discipline()
		{

		}

		public Discipline(int Id, string Name)
		{
			this.Id = Id;
			this.Name = Name;
		}
	}
}
