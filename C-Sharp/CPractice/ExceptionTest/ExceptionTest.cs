using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionTest
{
    class ExceptionTest
    {
        public static double SafeDivision(double x, double y)
        {
            if (y == 0)
                throw new System.DivideByZeroException();
            return x / y;
        }
        
    }
}
