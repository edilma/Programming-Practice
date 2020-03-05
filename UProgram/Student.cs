using System;
using System.Collections.Generic;
using System.Text;

namespace UProgram
{
    class Student
    {
        public string StudentID { get; set; }
        public string Name { get; set; }
        public string Major { get; set; }
        public int creditsTaken { get; set; }

        public Student() { }
        public Student(string name, string major)
        { }
    }
}
