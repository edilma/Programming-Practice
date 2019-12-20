using System;
using System.Collections.Generic;
using System.Text;

namespace DrinksMachine
{
    class DrinksMachine
    {
        private string location;
        private string make;
        private string model;

        public string Location { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public DrinksMachine(string loc, string make, string model)
        {
            Location = loc;
            Make = make;
            Model = model;
        }
        public DrinksMachine()
        {

        }
        public DrinksMachine(string make, string model)
        {
            Make = make;
            Model = model;
        }




    }
}
