using System;
using System.Collections.Generic;
using System.Text;

namespace TeacherApp.Models
{
    public class CurrentLesson : Lesson
    {
        private static CurrentLesson instance;
        
        private CurrentLesson()
        {

        }

        public static CurrentLesson Instance()
        {
            if (instance == null)
            {
                instance = new CurrentLesson();
            }
            return instance;
        }
    }
}
