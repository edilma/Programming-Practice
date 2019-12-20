using System;

namespace linq_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            /* Write a program in C# Sharp to find the number of 
             * an array and the square of each number which is more than 20 
            int[] numbers = new int[5];
            numbers[0] = 4;
            numbers[1] = 8;
            numbers[2] = 15;
            numbers[3] = 16;
            numbers[4] = 23;
            //Console.WriteLine(numbers[2]);
            Console.WriteLine(numbers.Length) ;

            */
            //int[] numbers = new int[] { 4, 8, 15, 23, 42 };
            //string[] names = new string[] { "edilma", "lily", "damian", "sparkles" };
            /*
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
            */
            /*
            foreach (string name in names)
            {

                Console.WriteLine(name);

            }*/

            //string zig = "YOu can get what you want out of life if you" +
            //    "help enough other people get what they want";
            //char[] charArray = zig.ToCharArray();
            //Array.Reverse(charArray);

            //foreach (char revChar in charArray)
            //{
            //    Console.Write(revChar);
            //}

            //Console.WriteLine(zig);

            //Write a program in C# Sharp to find the number of 
            //an array and the square of each number which is more than 20

            int[] myArray = new int[] { 5, 6, 87, 14, 25, 35, 21, 3, 2, 14, 24, 23, 20 };
            foreach (int number in myArray)
            {
                if (number>20)
                {
                    int square = number*number;
                    Console.WriteLine($"Number ={number} , SqrNo={square}");
                }
            }

            Console.ReadLine();
        }
      
    }
}
