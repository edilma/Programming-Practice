using System;
using System.Collections.Generic;
using System.Text;

namespace UProgram
{
    class Teacher
    {
        protected string _teacherName;

        public string TeacherName
        {
            get
            {
                return _teacherName;
            }
            private set
            {
                _teacherName = value;
            }
        }

        public Teacher(string teacherName)
        {
            TeacherName = teacherName;
        }
    }
}
