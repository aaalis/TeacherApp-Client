using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

		private List<Student> lessonStudents;
		public List<Student> LessonStudents
		{
			get { return lessonStudents; }
			set 
			{
				SetProperty(ref lessonStudents, value);
			}
		}

		private ObservableCollection<object> selectedStudents;
		public ObservableCollection<object> SelectedStudents
		{
			get { return selectedStudents; }
			set 
			{ 
				SetProperty(ref selectedStudents, value);
			}
		}

		public Command ItemSelectCommand { get; }

		public Command GradesCommand { get; }

		public Command<Student> LongPressCommand { get; }

		public LessonViewModel()
		{
			LocalLesson = CurrentLesson.Instance();

			if (LocalLesson.Group != null)
			{
                LessonStudents = LocalLesson.Group.Students.ToList();
            }
			
			SelectedStudents = new ObservableCollection<object>();

            GradesCommand = new Command(OnGradesClick);
			ItemSelectCommand = new Command(OnItemSelect);
			LongPressCommand = new Command<Student>(OnLongPress);
		}

		~LessonViewModel()
		{

		}

		private async void OnGradesClick(object obj)
		{
			await Shell.Current.GoToAsync(nameof(StudentsPage));
		}

		private void OnItemSelect(object obj)
		{
			var test2 = obj;
		}

		private async void OnLongPress(Student student)
		{
			ChosenStudent.Instance().Update(student);
			
			await Shell.Current.GoToAsync(nameof(GradesPage));
		}
	}
}
