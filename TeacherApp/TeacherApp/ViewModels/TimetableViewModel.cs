using System;
using System.Collections.Generic;
using System.Text;
using TeacherApp.Models;
using TeacherApp.Services;
using TeacherApp.Views;
using Xamarin.Forms;

namespace TeacherApp.ViewModels
{
    public class TimetableViewModel : BaseViewModel
    {
		private string date;
		public string Date
		{
			get { return date; }
			set 
			{
                SetProperty(ref date, value);
			}
		}

		private List<Lesson> lessons;
		public List<Lesson> Lessons
		{
			get { return lessons; }
			set 
			{
				SetProperty(ref lessons, value); 
			}
		}

		private Lesson selectedLesson;
		public Lesson SelectedLesson
		{
			get { return selectedLesson; }
			set 
			{ 
				SetProperty(ref selectedLesson, value);
			}
		}


		public Command SelectLessonCommand { get; }

		public TimetableViewModel()
		{
			Date = DateTime.Now.ToShortDateString();
			Lessons = MockDataStore.Lessons;
			SelectLessonCommand = new Command(OnSelectLesson);
		}

		private void OnSelectLesson()
		{
			CurrentLesson.Instance().Update(SelectedLesson);

			Shell.Current.GoToAsync($"//{nameof(LessonPage)}");
		}
	}
}
