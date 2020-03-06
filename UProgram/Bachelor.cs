using System;
using System.Collections.Generic;
using System.Text;

namespace UProgram
{
    class Bachelor : Degree
    {
        public List<Course> Sylabus = new List<Course>();
        public Bachelor(string name, int credits) : base(name, credits) { }

        public Bachelor(string name, int credits, List<Course> sylabus) : base(name, credits) 
        {
            Sylabus = sylabus;
        }


        protected int _totalCredits;


        

        public int GetCreditMajor(List<Course> Sylabus)
        {
            if (Sylabus.Count>0)
            {
                foreach (Course course in Sylabus)
                {
                    _totalCredits = _totalCredits + course.Credits;
                    return _totalCredits;
                }
            }
            else 
            {
                return 0;
            }
            
        }



    
            
        
    }
        

    
}
