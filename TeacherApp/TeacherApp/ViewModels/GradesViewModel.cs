using System;
using System.Collections.Generic;
using System.Text;
using TeacherApp.Models;

namespace TeacherApp.ViewModels
{
    public class GradesViewModel : BaseViewModel
    {
        private Student student;
        public Student Student
        {
            get { return student; }
            set 
            { 
                student = value;
                SetProperty(ref student, value);
            }
        }

        private Lesson lesson;
        public Lesson Lesson
        {
            get { return lesson; }
            set 
            { 
                lesson = value;
                SetProperty(ref lesson, value);
            }
        }

        private int myVar;
        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }


        public GradesViewModel()
        {
            Lesson = CurrentLesson.Instance();
            Student = LongPressStudent.Instance();
        }
    }
}
