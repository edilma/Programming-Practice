using System;
using System.Data;
using System.Text;
using System.Text.RegularExpressions;

namespace FebruaryPracticeCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string userString = "s-dfs30fdsjf,40";
            //string cleanedWord = Regex.Replace(userString, "[^0-9,-]", "");
            bool isPoint = IsPoint(userString);

            if (isPoint)
            {
                //string numbers = ExtractedDigit(string digits);
                Console.WriteLine("hola");
            }
            else 
            {
                Console.WriteLine("The string has NOT a poing coordinates");
            }



            






            string pattern = @"0 - 9, 0 - 9, ',', 0 - 9, 0 - 9";
            Regex r = new Regex(pattern, RegexOptions.IgnoreCase);
            Match m = r.Match(userString);
            Console.WriteLine(m);



          

            //Console.WriteLine("Hello World!");
        }
        public static bool IsPoint (string word)
        {
            string cleanedWord = Regex.Replace(word, "[^0-9,-]", "");
            //Console.WriteLine(cleanedWord);
            int size = cleanedWord.Length;
            //Console.WriteLine(  size );
            

            if (cleanedWord.Length>3 & cleanedWord.Length<=7)
            {
                string myNumbers = OnlyNumbers(cleanedWord);
                Console.WriteLine(myNumbers);


                return true;
            }
            return false;
            //Console.WriteLine(cleanedWord);

        }

        public static string OnlyNumbers( string cleanedWord)
        {
            int commaIx = cleanedWord.IndexOf(",");
            int sizePoint = cleanedWord.Length;
            if (sizePoint <= 5 & commaIx == 2)
            {
                return cleanedWord;
            }
            else 
            {
                if (commaIx==3 & cleanedWord[0]=='-')
                {
                    return cleanedWord;
                }
                else
                {
                    return "other number";
                }
            
            }
            
        }
        
    }
}
