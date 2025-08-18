
/*************************************************
*  Author: michael van Rooyen Tafe ID:20154897
*  Date:19/02/2024
*  Name: test1 program
*  Description:test classes 
*   
* **************************************************/




using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   

    internal class Program
    {

       



        static void Main(string[] args)
        {

            Car Mycar = new Car();
            Car Sharon_car = new Car(); // create object of class 
            Car Patsy_car = new Car();

            Sharon_car.name = "Fiat";
            Patsy_car.name = "Mitsubishi";
            Mycar.name = "Suzuki";

            //Mycar.seats(2);
            

           
            
          

           Console.WriteLine("Mikes Car " + Mycar.name);
            Mycar.seats(2);
            Console.WriteLine("Sharons Car " + Sharon_car.name);
            Sharon_car.seats(4);
          Console.WriteLine("Patsy Car " + Patsy_car.name);
            Patsy_car.seats(5);

           // Console.ReadKey();  
            

        }
    }
}
