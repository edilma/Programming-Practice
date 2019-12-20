using System;
using System.Linq;

namespace PracticeC
{
    class FindSentences
    {
        static void Main()
        {
            string text = @"Historically, the world of data and the world of objects " +
            @"have not been well integrated. Programmers work in C# or Visual Basic " +
            @"and also in SQL or XQuery. On the one side are concepts such as classes, " +
            @"objects, fields, inheritance, and .NET Framework APIs. On the other side " +
            @"are tables, columns, rows, nodes, and separate languages for dealing with " +
            @"them. Data types often require translation between the two worlds; there are " +
            @"different standard functions. Because the object world has no notion of query, a " +
            @"query can only be represented as a string without compile-time type checking or " +
            @"IntelliSense support in the IDE. Transferring data from SQL tables or XML trees to " +
            @"objects in memory is often tedious and error-prone.";

            // Split the text block into an array of sentences.  
            string[] sentences = text.Split(new char[] { '.', '?', '!' });

            // Define the search terms. This list could also be dynamically populated at runtime.  
            string[] wordsToMatch = { "Historically", "data", "integrated" };

            // Find sentences that contain all the terms in the wordsToMatch array.  
            // Note that the number of terms to match is not specified at compile time.  
            var sentenceQuery = from sentence in sentences
                                let w = sentence.Split(new char[] { '.', '?', '!', ' ', ';', ':', ',' },
                                                        StringSplitOptions.RemoveEmptyEntries)
                                where w.Distinct().Intersect(wordsToMatch).Count() == wordsToMatch.Count()
                                select sentence;

            // Execute the query. Note that you can explicitly type  
            // the iteration variable here even though sentenceQuery  
            // was implicitly typed.   
            foreach (string str in sentenceQuery)
            {
                Console.WriteLine(str);
            }

            // Keep the console window open in debug mode.  
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
    /* Output:  
    Historically, the world of data and the world of objects have not been well integrated  
    */
}
