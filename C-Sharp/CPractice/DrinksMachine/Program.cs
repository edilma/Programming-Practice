using System;

namespace DrinksMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            DrinksMachine myMachine = new DrinksMachine();
            myMachine.Make = "KitchenAid";
            myMachine.Model = "DM1000";
            myMachine.Location = "Kitchen";
        }
    }
}
