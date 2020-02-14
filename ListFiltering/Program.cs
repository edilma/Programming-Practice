using System;
using System.Collections.Generic;
using System.Linq;

namespace ListFiltering
{
    class Program
    {
        static void Main(string[] args)
        {
            /* create a function that takes a list of non-negative 
             * integers and strings and returns a new list with the strings filtered out.*/
            var list = new List<object>() { 1, 2, "a", "b", "aasf", "1", "123", 231 };
            IEnumerable<int> numbers = GetIntegersFromList(list);

            var result2 = GetIntegersFromListVersionTwo(list);

            foreach (var item in numbers)
            {
                Console.WriteLine(item);

            }
            // Version for answer 2 
            foreach (var item in result2)
            {
                Console.WriteLine(item);
            }
        }
        public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)

        {
            List<int> numbers = new List<int>();
            foreach (var item in listOfItems)
            {
                if (item is int)
                {

                    numbers.Add((int)item);
                }
            }
            return numbers;

        }

        public static IEnumerable<int> GetIntegersFromListVersionTwo(List<object> listOfItems)
        {
            return listOfItems.OfType<int>();

        }

    }
}
