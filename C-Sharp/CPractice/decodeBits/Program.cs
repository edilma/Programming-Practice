using System;

namespace decodeBits
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "Hello World!";
            DoubleChar(word);


        Console.WriteLine("word");
        }
        public static void DoubleChar(string word)
        {
            string newWord = "";
            foreach (Char letter in word)
            {
                newWord = newWord + letter+letter ;
            }
            Console.WriteLine(newWord);            
        }

    }
}
