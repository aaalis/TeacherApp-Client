using System;
using System.Collections.Generic;
using System.Text;
using TeacherApp.Models;
using TeacherApp.Services;

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

		public TimetableViewModel()
		{
			Date = DateTime.Now.ToShortDateString();
			Lessons = MockDataStore.Lessons;
		}
	}
}
