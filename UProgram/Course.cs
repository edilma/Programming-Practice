using System;
using System.Collections.Generic;
using System.Text;

namespace UProgram
{
   
    class Course
    {
        protected string _courseName;
        protected int _credits;
        public enum CourseRequirement
        {
            Required, 
            Elective
        }

        public CourseRequirement courseRequirement { get; private set; }
       
        
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
        public Course (string courseName, int credits, CourseRequirement courseRequirement)
        {
            _courseName = courseName;
            _credits = credits;
            this.courseRequirement = courseRequirement;

        }
        public Course() { }
    }
}
