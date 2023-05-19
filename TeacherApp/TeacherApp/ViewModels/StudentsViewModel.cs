using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TeacherApp.Models;

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
				groupName = value;
				SetProperty(ref groupName, value);
			}
		}

		private List<Student> students;
		public List<Student> Students
		{
			get { return students; }
			set 
			{ 
				students = value;
				SetProperty(ref students, value);
			}
		}

		public StudentsViewModel()
		{
			var Group = CurrentLesson.Instance().Group;
			GroupName = Group.Name;
			Students = Group.Students.ToList();
		}

	}
}
