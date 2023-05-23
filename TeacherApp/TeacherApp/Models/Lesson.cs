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
			set 
			{ 
				datetime = new DateTime(value.Year, value.Month, value.Day, value.Hour, value.Minute, 0, value.Kind);
			}
		}

		private Discipline lessonDiscipline;
		public Discipline LessonDiscipline
        {
			get { return lessonDiscipline; }
			set { lessonDiscipline = value; }
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

		public Lesson(int Id, DateTime Datetime, Discipline LessonDiscipline, Group Group, string Classroom)
		{
			this.Id = Id;
			this.Datetime = Datetime;
			this.LessonDiscipline = LessonDiscipline;
			this.Group = Group;
			this.Classroom = Classroom;
		}

		public void Update(Lesson Lesson)
		{
			this.Id = Lesson.Id;
			this.Datetime = Lesson.Datetime;
			this.LessonDiscipline = Lesson.LessonDiscipline;
			this.Group = Lesson.Group;
			this.Classroom = Lesson.Classroom;
		}
	}
}
