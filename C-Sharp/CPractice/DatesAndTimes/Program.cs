using System;

namespace DatesAndTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime myValue = DateTime.Now;
            //Console.WriteLine(myValue.ToString()); // Shows date (m,y,d) and time
            //Console.WriteLine(myValue.ToShortDateString());// Shows only date
            //Console.WriteLine(myValue.ToShortTimeString()); // shows only time
            //Console.WriteLine(myValue.ToLongDateString());
            //Console.WriteLine(myValue.ToLongTimeString());
            //Console.WriteLine(myValue.AddDays(3).ToLongDateString()); // To add time use the AddTime or AddDate methods
            //Console.WriteLine(myValue.AddHours(-3).ToLongTimeString()); // to substract time I use negative numbers
            //Console.WriteLine(myValue.Month); //to ge the number of the month
            //DateTime myBirthday = new DateTime(1971, 04, 03);

            //Console.WriteLine(myBirthday.ToLongDateString());

            DateTime myBirthday = DateTime.Parse("04/03/1971"); //takes a string and converts it into a date
            TimeSpan myAge = DateTime.Now.Subtract(myBirthday);
            Console.WriteLine(myAge.TotalDays);


            Console.ReadLine();
        }
    }
}
