using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TeacherApp.Models;
using TeacherApp.Views;
using Xamarin.Forms;

namespace TeacherApp.ViewModels
{
    public class StudentsViewModel : BaseViewModel
    {
		private string groupName;
		public string GroupName
		{
			get { return groupName; }
			set 
			{ 
				SetProperty(ref groupName, value);
			}
		}

		private List<Student> students;
		public List<Student> Students
		{
			get { return students; }
			set 
			{ 
				SetProperty(ref students, value);
			}
		}

		private Student selectedStudent;
		public Student SelectedStudent
		{
			get { return selectedStudent; }
			set 
			{
				SetProperty(ref selectedStudent, value);
			}
		}

		public Command SelectStudentCommand{ get; set; }

		public StudentsViewModel()
		{
			var Group = CurrentLesson.Instance().Group;
			GroupName = Group.Name;
			Students = Group.Students.ToList();

			SelectStudentCommand = new Command(OnSelected);
		}

		private async void OnSelected()
		{
			ChosenStudent.Instance().Update(SelectedStudent);

			await Shell.Current.GoToAsync(nameof(GradesPage));
		}
	}
}
