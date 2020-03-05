using System;
using UProgram;

class Program
{
    static void Main(string[] args)
    {
        Master myDegree = new Master("MBA", 12);
        Bachelor myBachelor = new Bachelor("Computer Science", 30);
        var myCourse = new Course("Introduction to Programming",3);

        
        Console.WriteLine($"Degree Type = {myDegree.GetType()}");
        Console.WriteLine($"Course Name = {myCourse.CourseName}");

        var isDegree = myDegree is Degree;
        Console.WriteLine($"Is Degree - {isDegree}");
        Console.WriteLine($"Degree Name = {myDegree.Name}");
        Console.WriteLine($"Did you complete your degree? {myDegree.isComplete}");

        myDegree.allowGraduation();
        Console.WriteLine("The student complete his credits");
        myDegree.allowGraduation();
        Console.WriteLine($"Can you graduate? {myDegree.isComplete}");

        Console.Read();
    }
 }


