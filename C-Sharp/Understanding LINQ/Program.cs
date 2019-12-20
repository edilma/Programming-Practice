using System;
using System.Collections.Generic;
using System.Linq;

namespace Understanding_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> myCars = new List<Car>()
            {
            new Car() { VIN="A1", Make ="BMW",Model="550i",StickerPrice =55000, Year =2008},
            new Car() { VIN = "B2", Make = "Toyota", Model = "4Runner", StickerPrice = 35000, Year = 2009 },
            new Car() { VIN = "C3", Make = "BMW", Model = "745i", StickerPrice = 75000, Year = 2011 },
            new Car() { VIN = "D4", Make = "Ford", Model = "Escape", StickerPrice = 25000, Year = 2010 },
            new Car() { VIN = "E5", Make = "BMW", Model = "55i", StickerPrice = 57000, Year = 2011 }
            };
            // LINQ query
            /*var bmws = from car in myCars
                       where car.Make == "BMW"
                       && car.Year == 2011

                       select car;
                       

            var orderedCars = from car in myCars
                              orderby car.Year descending
                              select car;

    */
            // LINQ Method
            // var bmws = myCars.Where(p => p.Make == "BMW" && p.Year == 2011); // Linq method to do the query

            //var orderedCars = myCars.OrderByDescending(p => p.Year);

            //var firstBMW = myCars.OrderByDescending(p=>p.Year).First(p => p.Make=="BMW");
            //Console.WriteLine(firstBMW.VIN);

            /*
            foreach (var car in orderedCars)
            {
                Console.WriteLine("{0} {1}", car.Model, car.Year);
            }*/
            //Console.WriteLine(myCars.TrueForAll(p=> p.Year>2007)); 

            //myCars.ForEach(p => p.StickerPrice -= 3000);
            //myCars.ForEach(p => Console.WriteLine("{0} {1:C} {2}", p.Year,p.StickerPrice, p.Model));

            //Console.WriteLine(myCars.Exists(p=>p.Model=="745i"));
            //Console.WriteLine("{0:C}", myCars.Sum(p=> p.StickerPrice));

            Console.WriteLine(myCars.GetType());


            // end of program. ask for an enter so the program doesn't close automatically.
            //Console.Write("Program has ended successfully. Press enter to finish.");
            Console.ReadLine();

        }
    }

    class Car
    {
        public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public int StickerPrice { get; set; }
    }

}