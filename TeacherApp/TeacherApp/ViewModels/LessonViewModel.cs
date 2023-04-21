using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TeacherApp.Models;
using TeacherApp.Services;

namespace TeacherApp.ViewModels
{
    public class LessonViewModel : BaseViewModel
    {
        public Lesson LocalLesson { get; set; }

        private string lessonDiscripline;
		public string LessonDiscripline
        {
			get { return lessonDiscripline; }
			set 
			{ 
				lessonDiscripline = value;
				SetProperty(ref lessonDiscripline, value); 
			}
		}

		private string lessonGroupName;
		public string LessonGroupName
		{
			get { return lessonGroupName; }
			set 
			{ 
				lessonGroupName = value;
				SetProperty(ref lessonGroupName, value); 
			}
		}

		private string lessonDatetime;
		public string LessonDatetime
		{
			get { return lessonDatetime; }
			set 
			{ 
				lessonDatetime = value;
				SetProperty(ref lessonDatetime, value); 
			}
		}

		private List<Student> lessonStudents;
		public List<Student> LessonStudents
		{
			get { return lessonStudents; }
			set 
			{
				lessonStudents = value;
				SetProperty(ref lessonStudents, value);
			}
		}


		public LessonViewModel()
		{
			LocalLesson = MockDataStore.Lessons[0];
			LessonDiscripline = LocalLesson.Discipline;
			LessonGroupName = LocalLesson.Group.Name;
			LessonDatetime = LocalLesson.Datetime.ToString();
			LessonStudents = LocalLesson.Group.Students.ToList();
		}
	}
}
