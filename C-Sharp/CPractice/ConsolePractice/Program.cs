using System;

namespace ConsolePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int first;
            string sValue;
            ReturnMultiOut(out first, out sValue);
            Console.WriteLine($"{first.ToString()}, {sValue}");

           
        }
        static void ReturnMultiOut(out int i, out string s)
        {
            i = 25;
            s = "using out";
        }
    }
}
