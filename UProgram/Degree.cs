using System;
using System.Collections.Generic;
using System.Text;

namespace UProgram
{
    abstract class Degree
    {
        protected string _name = "Unknown";
        protected int _credits;
        //public List<Courses>
        public bool isComplete { get; private set; }
        public string Name 
        { 
            get
            { 
                return _name; 
            }
            private set 
            {
                _name = value;
            } 
        }
        public int Credits {
            get {
                return _credits; 
            }
            private set
            {
                _credits = value;
            }
                 }
        public Degree(string name, int credits)
        {
            Name = name;
            Credits = credits;
        }
        protected void missingCredits() 
        {
            isComplete = false;
        }
        protected void completeCredits()
        {
            isComplete = true;
        }
        public void allowGraduation()
        {
            if (isComplete)
            {
                completeCredits();
            }
            else 
            {
                missingCredits();
            }

        }

    }
}
