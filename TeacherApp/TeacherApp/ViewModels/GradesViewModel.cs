using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TeacherApp.Models;
using TeacherApp.Services;

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
                SetProperty(ref student, value);
            }
        }

        private Lesson lesson;
        public Lesson Lesson
        {
            get { return lesson; }
            set 
            { 
                SetProperty(ref lesson, value);
            }
        }

        private List<TaskAcademicPlan> tasks;
        public List<TaskAcademicPlan> Tasks
        {
            get { return tasks; }
            set 
            { 
                SetProperty(ref tasks, value);
            }
        }


        public GradesViewModel()
        {
            Lesson = CurrentLesson.Instance();
            Student = ChosenStudent.Instance();
            Tasks = MockDataStore.AcademicPlans.ToList()
                                               .Find(x => x.StudentId == Student.Id && x.AcademicPlanDiscipline.Id == Lesson.LessonDiscipline.Id)
                                               .Tasks
                                               .ToList();
        }
    }
}
