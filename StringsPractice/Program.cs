using System;
using System.Text.Encodings;
using System.Data;


namespace StringsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //string s1, s2, s3;
            char c1, c2, c3;
            c1 = 'a';
            c2 = 'p';
            c3 = '-';
            //c5 = "";
            string c5 = new string('=', 240);
            var db = new GroceryDb();


            //string s2 = new String(db.GetFruits());
            char[] caracters = { 'b', 'a', 'n', 'a', 'n', 'a' };

            string s8 = new string(caracters);
            string s9 = new string(caracters, 1, 3);

            string letters = "abc-def-ghi-jkl-mno-pqr-stu-vwx-yz";
            c1 = letters[0];
            c2 = letters[letters.Length - 1];
            c3 = 'm';
            char resultChar;


            if (letters.Contains(c3))
            {
                var index = letters.IndexOf(c3);
                resultChar = letters[index];
                //Console.WriteLine(resultChar);

            }
            else
            {
                //Console.WriteLine("no that letter");
            }

            char m1 = '?';
            if (Char.IsPunctuation(m1))
            {
                //Console.WriteLine($"{m1} is punctuation");
            }
            else
            {
                //Console.WriteLine($"{m1} is NOT punctuation");
            }

            string s1, s2, s3;
            s1 = "hello";
            s2 = @"hello";
            s3 = $"hello";

           // var phrase = "The customer said, \"I want refund\".";
            var phrase = "The customer said: \n \"I want refund\".";

            var tabs = "aaaa\tbbbb\tcccc\tdddd\veeee\tffff\tgggg\thhhh";
            var pin = "aaa\tbbb\tccc\vddd\teee\tfff";
            var uni = "Add any Unicode code point:\v\u2600 \u2614 \u2615 \u273F \r\n\u2600 \u2614 \u2615 \u273F ";

            //Console.WriteLine(uni); // its no showing the unicode
            var pin2 = @"aaa\tbbb\tccc\vddd\teee\tfff";
            //Console.WriteLine(pin);
            //Console.WriteLine(pin2);

            //********** Concatenation of strings **********
            string first = "1. The banana is yellow";
            string second = "2. The pear is ripe";
            string third = "A tomato is not a vegetable";
            string florete = " sss ";

            string combo = String.Concat(first, florete,second);

            //Console.WriteLine(combo);

            double number1 = 0.12;
            int number2 = 15;
            string header = "The total is: ";

            //combo = header + number1 + number2; // concatenate them as strings
            //combo = header + (number1 + number2);
            //combo = String.Format("{2}{1}{0}", first, florete, second);
            combo = $"{number1:P} is percentage but {number2:C} is money";

            Console.WriteLine(combo);





        }




        //Console.WriteLine(index);

    }
    }
    public class GroceryDb
    {
        public char[] GetFruits()
        {
            // for example, a legacy service in your enterprise
            // that returns char arrays
            char[] fruits = { 'b', 'a', 'n', 'a', 'n', 'a', ',', 'f', 'i', 'g' };

            return fruits;
        }
    }

