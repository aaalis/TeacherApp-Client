using System;
using System.Collections.Generic;
using System.Text;

namespace TeacherApp.Models
{
    public class LongPressStudent : Student
    {
        private static LongPressStudent instance;

        private LongPressStudent()
        {

        }

        public static LongPressStudent Instance()
        {
            if (instance == null)
            {
                instance = new LongPressStudent();
            }
            return instance;
        }
    }
}
