using System;
using System.Collections.Generic;
using System.Text;

namespace TeacherApp.Models
{
    public class Group
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


		private IEnumerable<Student> students;
		public IEnumerable<Student> Students
		{
			get { return students; }
			set { students = value; }
		}

		public Group()
		{

		}

		public Group(int Id, string Name, IEnumerable<Student> Students)
		{
			this.Id = Id;
			this.Name = Name;
			this.Students = Students;
		}
	}
}
