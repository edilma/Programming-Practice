using System;
using UProgram;

class Program
{
    static void Main(string[] args)
    {
        Master myDegree = new Master("MBA", 12);
        Bachelor myBachelor = new Bachelor("Computer Science", 20);
        Course CS50 = new Course("CS50","Introduction to Programming",3, Course.CourseType.Required);
        Course COP2360 = new Course("COP2360", "Introduction to C#", 6, Course.CourseType.Required);
        Course CS2700 = new Course("CS2700", "Introduction to SQL", 4, Course.CourseType.Required);
        Course CS2840 = new Course("CS2840", "Introduction to Server Side Programming", 5, Course.CourseType.Required);
        Course CS1030 = new Course("CS1030", "Oracle", 2, Course.CourseType.Required);

        Student Lily = new Student("Lily", myBachelor);
        
        

        Student Edilma = new Student("Edilma", myBachelor);
        Student Damian = new Student("Damian", myBachelor) ;
        Student Sparkles = new Student("Sparkles", myBachelor);
        Lily.ClassesTaken.Add(CS50);
        Edilma.ClassesTaken.Add(CS50);
        Damian.ClassesTaken.Add(CS50);
        Sparkles.ClassesTaken.Add(CS50);

        Console.WriteLine($"Lily is taken {Lily.ClassesTaken.Count} classes");




        CS50.Roaster.Add(Lily);
        CS50.Roaster.Add(Edilma);
        CS50.Roaster.Add(Damian);
        CS50.Roaster.Add(Sparkles);
        

        var list = CS50.getRoaster();
        foreach (Student student in list)
        {
            Console.WriteLine(student.Name);
        }

        
        //Console.WriteLine($"Degree Type = {myDegree.GetType()}");
        //Console.WriteLine($"Course Name = {myCourse.CourseName}");
        //Console.WriteLine($"Course Type? = {myCourse.courseType}");
        Console.WriteLine($"Is Student Enrolled? = {Lily.enrolled}");

        var isDegree = myDegree is Degree;
        //Console.WriteLine($"Is Degree - {isDegree}");
        //Console.WriteLine($"Degree Name = {myDegree.Name}");
        //Console.WriteLine($"Did you complete your degree? {myDegree.isComplete}");

        myDegree.allowGraduation();
        //Console.WriteLine("The student complete his credits");
        myDegree.allowGraduation();
        //Console.WriteLine($"Can you graduate? {myDegree.isComplete}");

        Console.Read();
    }
 }


