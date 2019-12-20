using OOPEXamples;
using System;

class Program
{
    static void Main(string[] args)
    {
        var comp = new Desktop("Generic Computer",Desktop.CaseType.Tower);
       //comp.name = "Generic Computer";

        //var comp = new Laptop("Generic Laptop", 1024,768);
        Console.WriteLine("Computer Type - "+ comp.GetType());

        var isComputer = comp is Computer;
        Console.WriteLine("Is computer - " + isComputer);
        Console.WriteLine("Computer name - " + comp.name);
       // Console.WriteLine("Computer case - " + comp.caseType);

        //comp.TurnOn();
        //Console.WriteLine( "Is the computer on: - " + comp.isOn);
        //comp.TurnOff();
        //Console.WriteLine("Is the computer on: - " + comp.isOn);
        comp.TogglePower();
        Console.WriteLine("Is the computer on: - " + comp.isOn);

        var sleepingComp = comp as ISleep;

        if (sleepingComp !=null)
        {
            sleepingComp.ToggleSleep();
            Console.WriteLine("Is the computer sleeping: - " + sleepingComp.isSleeping);

            comp.TogglePower();
            Console.WriteLine("Is the computer on: - " + comp.isOn);
        }

        


        Console.Read();

    }
}

