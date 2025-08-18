using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("ford", "Mustang", "Red");
            Bike bike1 = new Bike("giant", "mtb", "yellow");
            Console.WriteLine(car1.Name +" "+ car1.Model+" "+ car1.Color);
            Console.WriteLine(bike1.Name + " " + bike1.Model + " " + bike1.Color);
            Console.ReadKey();

        }
    }

   


}


