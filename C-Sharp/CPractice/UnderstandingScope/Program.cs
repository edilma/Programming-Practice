using System;

namespace UnderstandingScope
{
    class Program
    {
        private static string k = "";

        static void Main(string[] args)
        {
            string j = "";
            for (int i = 0; i < 10; i++)
            {
                j= i.ToString();
                k = i.ToString();
                Console.WriteLine(i);

                if (i==9)
            {
                    string l = i.ToString();
            }
               // Console.WriteLine(l);
            }
            Console.WriteLine("Outside of the for : "+  j + k);
            HelperMethod();

            Car mycar = new Car();
            mycar.DoSomething();


            Console.ReadLine();

            

        }
        static void HelperMethod()
        {
            Console.WriteLine("Value of k form the helper method(): " + k);
        }

        class Car
        {
            public void DoSomething()
            {
                Console.WriteLine(helperMethod());
            }
            private string helperMethod()
            {
                return "Hello World";
            }
        }


    }
}
