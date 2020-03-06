using System;
using System.Collections.Generic;
using System.Text;

namespace UProgram
{
    class Student
    {

        public string Name { get; set; }
        protected Bachelor _major;
        public bool enrolled { get; private set; }
        public List<Course> ClassesTaken = new List<Course>();

        public Bachelor Major
        {
            get
            {
                return _major;
            }
            private set
            {
                _major = value;
            }
        }

        public List<Course> ClassTaken()
        {
            return ClassesTaken;
        }

        public Student() { }
        public Student(string name, Bachelor major )
        {
            Name = name;
            Major = major;
        }


        protected void activeStudent()
        {
            if (ClassesTaken.Count>=1)
            {
                enrolled = true;
            }
            else
            {
                enrolled = false;
            }
            
        }



    }
}
