using System;

namespace WhoLikes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Peter" };
            Likes(names);

            //Console.WriteLine("Hello World!");
        }
        public static void Likes(string[] name)
        {
            int count = name.Length;
            if (count == 0)
            {
                Console.WriteLine("no one likes this");
            }
            else
            {
                if (count == 1)
                {
                    Console.WriteLine($"{name[0]} likes this");
                }
                else
                {
                    string friends = name[0];
                    for (int i = 1; i < (name.Length - 1); i++)
                    {
                        friends = friends + "," + name[i];
                    }
                    friends = friends + " and " + name[count - 1];
                    Console.WriteLine(friends + " like this");
                }

            }
            

        }
    }
    
}
