using System;

namespace CreateChessBoard
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 9; i++)
            {
                if (i % 2 != 0)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        if (j % 2 == 0)
                        {
                            Console.Write("X");
                        }
                        else
                        {
                            Console.Write("O");
                        }
                    }
                }
                else
                {
                    for (int j = 0; j < 9; j++)
                    {
                        if (j % 2 != 0)
                        {
                            Console.Write("X");
                        }
                        else
                        {
                            Console.Write("O");
                        }
                    }
                }
                Console.WriteLine();
            }

           

            
            Console.ReadLine();
        }
    }
}
