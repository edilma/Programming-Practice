using System;
using System.Data;
using System.Text;

namespace stringChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            // code challenge #1
            // write a method that takes a start word and end word and returns
            // the substring contained between those words.

            // code challenge #2
            // write another method that takes a start word and end word and replacement string
            // and returns a string containing the substitute text.

            string sample = "At Roux Academy, our mission is to teach and inspire the next generation’s artists...";
            string startWord = "our";
            string endWord = "the ";
            string answer = ReplaceSample(sample, startWord, endWord); // answer code challenge 1 

            string replacement = "the real mission is to take ";
            string answer2 = sample.Replace(answer, replacement);// answer code challenge 2
            string answer2Method = ReplaceBetweenWords( sample,  startWord,  endWord, replacement);


            Console.WriteLine(answer);
            Console.WriteLine(answer2);
            Console.WriteLine(answer2Method);
        }

        // Method to select a substring base in 2 words
        public static string ReplaceSample(string sample, string start, string ends)
            {
            if (sample.Contains(start) & sample.Contains(ends))
            {
                int indexStart = sample.IndexOf(start);
                int indexEnds = sample.IndexOf(ends);
                string selsectedString = sample.Remove(indexEnds).Remove(0, indexStart+1);

                return selsectedString;

            }
            else {

                return "Error , not a valid string ";
                }
           
	        

	        }
        // replace a substring with another one. 
        public static string ReplaceBetweenWords(string sample, string start, string ends, string newSentence)
        {
            string readyToreplaceString = ReplaceSample(sample, start, ends);
            string newWord = sample.Replace(readyToreplaceString, newSentence);
            
            return newWord;
        }
}

        
    }

