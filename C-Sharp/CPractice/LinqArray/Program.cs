using System;
using System.Collections;
using System.Linq;

namespace NonGenericLINQ
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int[] Scores { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrList = new ArrayList();
            arrList.Add(
                new Student
                {
                    FirstName = "Svetlana",
                    LastName = "Omelchenko",
                    Scores = new int[] { 98, 92, 81, 60 }
                });
            arrList.Add(
                new Student
                {
                    FirstName = "Claire",
                    LastName = "O’Donnell",
                    Scores = new int[] { 75, 84, 91, 39 }
                });
            arrList.Add(
                new Student
                {
                    FirstName = "Sven",
                    LastName = "Mortensen",
                    Scores = new int[] { 88, 94, 65, 91 }
                });
            arrList.Add(
                new Student
                {
                    FirstName = "Cesar",
                    LastName = "Garcia",
                    Scores = new int[] { 97, 89, 85, 82 }
                });

            //write the query
            //var OverNineFive = arrList.Where (p => p.LastName == "Garcia");
             var OverNineFive = from Student student in arrList
                             where student.Scores[0]<=88
                            select student.FirstName;


            var query = from Student student in arrList
                        where student.Scores[0] > 95
                        select student;

            //run the query
            foreach (var item in OverNineFive)
            {
                Console.WriteLine($"The student name is {item}");
            }



            // Keep the console window open in debug mode.  
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
/* Output:   
    Omelchenko: 98  
    Garcia: 97  
*/
