using System;

namespace Mod3_Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = 9;
            int second = 0;
            Console.WriteLine("Enter your first number");
            first = System.Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your second number");
            second = System.Int32.Parse(Console.ReadLine());

            int result = Divide(first, second);
            Console.WriteLine($"The result of divide {first} in {second} is {result}");
        }
        //Method Divide accepts 2 int arguments and return an int result
        static int Divide (int first, int second)
        {
            int result = 0;
            try
            {
                result = first / second;
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("Cannot Divide by zero, please provide a non-zero value for your second value");
            }

            return result;
        }
    }
}
