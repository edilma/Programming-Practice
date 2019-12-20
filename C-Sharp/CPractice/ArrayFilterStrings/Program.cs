using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ArrayFilterStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //In this problem you are given 2 arrays of identical size. 
            //You need to zip the two arrays together maintaing their order.

            int[] array_one =new int[] { 1, 5, 2 };
            int[] array_two = new int[] { 3, 6, 4 };

            int[] newArray = new int[6];
            int j = 0;

            for (int i = 0; i < array_one.Length; i++)
            {
                newArray[j] = array_one[i];
                //Console.WriteLine(newArray[j]);
                j++;
                newArray[j] = array_two[i];
                //Console.WriteLine(newArray[j]);
                j++;
            }
            foreach (int item in newArray)
            {
                Console.Write(item);
    
            };
            

            
            
            Console.ReadLine();
        }
       
  

    }

    
}
