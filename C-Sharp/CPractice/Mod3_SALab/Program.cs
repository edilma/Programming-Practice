using System;

namespace Mod3_SALab
{
    class Program
    {
        static void Main(string[] args)
        {

            GetStudentInformation();
        }
        static void GetStudentInformation()
        {
            Console.WriteLine("Enter the student's First Name: ");
            string firstName = Console.ReadLine();
            ValidateName(firstName);
            Console.WriteLine("Enter the student's Last Name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter the student's Birthday: ");
            string birthday = Console.ReadLine();
            ValidateStudentBirthday(birthday);
            PrintStudentDetail(firstName, lastName, birthday);



        }
        static void PrintStudentDetail(string firstName, string lastName, string birthday)
        {
            Console.WriteLine($"{firstName} {lastName} was born in {birthday}");
        }
        static bool ValidateStudentBirthday(string birthday)
        {
            try 
            {
                return true;


            }
            catch (NotImplementedException ex)
            {
                Console.WriteLine("I can't validate the birthday");
            }
            return false;
            
        }
        static void ValidateName(string firstName)
        {
            throw new NotImplementedException();
        }
    }
}
