using System;
using System.Collections.Generic;
using System.Text;

namespace TeacherApp.Models
{
    public class Lesson
    {
		private int id;
		public int Id
		{
			get { return id; }
			set { id = value; }
		}

		private DateTime datetime;
		public DateTime Datetime
		{
			get { return datetime; }
			set { datetime = value; }
		}

		private string discipline;
		public string Discipline
        {
			get { return discipline; }
			set { discipline = value; }
		}

		private Group group;
		public Group Group
		{
			get { return group; }
			set { group = value; }
		}

		private string classroom;
		public string Classroom
		{
			get { return classroom; }
			set { classroom = value; }
		}

		public Lesson()
		{

		}

		public Lesson(int Id, DateTime Datetime, string Discipline, Group Group, string Classroom)
		{
			this.Id = Id;
			this.Datetime = Datetime;
			this.Discipline = Discipline;
			this.Group = Group;
			this.Classroom = Classroom;
		}
	}
}
