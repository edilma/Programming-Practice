using System;
using System.Collections.Generic;
using System.Text;

namespace UProgram
{
   
    class Course
    {
        protected string _courseID;
        protected string _courseName;
        protected int _credits;
        public enum CourseType
        {
            Required, 
            Elective
        }
        
        public List<Student> Roaster = new List<Student>();
        public int CourseSize 
        {
            get
            {
                return Roaster.Count;
            }
        }


        public CourseType courseType { get; private set; }
       
        
        public string CourseName 
        {
            get 
            { 
                return _courseName; 
            }
            set 
            {
                _courseName = value; 
            } 
        }

        public string CourseID
        {
            get 
            {
                return _courseID;
            }
            private set 
            {
                _courseID = value;
            }
        }


        public int Credits
        {
            get
            {
                return _credits;
            }
            set
            {
                _credits = value;
            }
        }
        public List<Student> getRoaster() 
        {
            return Roaster;
        }

        



        public Course (string courseID, string courseName, int credits, CourseType courseType)
        {
            _courseID = courseID;
            _courseName = courseName;
            _credits = credits;
            this.courseType = courseType;

        }
        public Course() { }
    }
}
