using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Car
    {
        public string name = " ";

        public void seats(int seat_number = 1)
        {
            switch (seat_number)
            {
                case 1:
                    Console.WriteLine("No Seating ");
                    Console.ReadKey();
                    break;
                case 2:
                    Console.WriteLine("Seating for one passenger");
                    Console.ReadKey();
                    break;
                case 3:
                    Console.WriteLine("Seating for two passengers");
                    Console.ReadKey();
                    break;
                case 4:
                    Console.WriteLine("Seating for three passengers");
                    Console.ReadKey();
                    break;
                case 5:
                    Console.WriteLine("Seating for Four passengers");
                    Console.ReadKey();
                    break;
                case 6:
                    Console.WriteLine("Seating for Five passengers");
                    Console.ReadKey();
                    break;

            }



        }




    }
}