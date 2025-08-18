using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Bike
    {

        public string Name { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }

        public Bike(string name, string model, string color) // constructor method
        {
            Name = name;
            Model = model;
            Color = color;
        }

    }
}
