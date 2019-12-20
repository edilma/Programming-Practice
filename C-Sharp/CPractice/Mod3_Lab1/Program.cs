using System;

namespace Mod3_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = Sum(20, 40);
            Console.WriteLine($"The sum of 20 and 40 is: {result}");

            int result3 = Sum(10, 50, 80);
            Console.WriteLine($"The sum of 10,50 and 80 is: {result3}");

            double dblResult = Sum(20.5, 30.6);
            Console.WriteLine($"Calling Sum() that takes doubles result in :{dblResult}");
        }
        static int Sum(int first, int second )
        {
            int sum = first + second;
            return sum;
            
        }
        static int Sum(int first, int second, int third)
        {
            int sum = first + second + third;
            return sum;

        }
        static double Sum( double first, double second)
        {
            double sum = first + second;
            return sum;
        }


    }
}
