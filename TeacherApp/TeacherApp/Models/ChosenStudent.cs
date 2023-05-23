using System;
using System.Collections.Generic;
using System.Text;

namespace TeacherApp.Models
{
    public class ChosenStudent : Student
    {
        private static ChosenStudent instance;

        private ChosenStudent()
        {

        }

        public static ChosenStudent Instance()
        {
            if (instance == null)
            {
                instance = new ChosenStudent();
            }
            return instance;
        }
    }
}
