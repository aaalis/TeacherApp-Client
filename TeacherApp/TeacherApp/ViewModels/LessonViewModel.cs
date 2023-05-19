using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TeacherApp.Models;
using TeacherApp.Services;
using TeacherApp.Views;
using Xamarin.Forms;

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

		private string lessonClassroom;
		public string LessonClassroom
		{
			get { return lessonClassroom; }
			set 
			{
                lessonClassroom = value;
				SetProperty(ref lessonClassroom, value);
			}
		}

		public Command GradesCommand { get; }

		public LessonViewModel()
		{
            LocalLesson = MockDataStore.Lessons[0];

            //temp
            var currentLesson = CurrentLesson.Instance();
			currentLesson.Group = LocalLesson.Group;
			currentLesson.Discipline = LocalLesson.Discipline;
			currentLesson.Datetime = LocalLesson.Datetime;
			currentLesson.Classroom = LocalLesson.Classroom;
			currentLesson.Id = LocalLesson.Id;

			LessonDiscripline = LocalLesson.Discipline;
			LessonGroupName = LocalLesson.Group.Name;
			LessonDatetime = LocalLesson.Datetime.ToString();
			LessonStudents = LocalLesson.Group.Students.ToList();
			LessonClassroom = LocalLesson.Classroom;

            GradesCommand = new Command(OnGradesClick);
		}

		private async void OnGradesClick(object obj)
		{
			await Shell.Current.GoToAsync(nameof(StudentsPage));
		}
	}
}
