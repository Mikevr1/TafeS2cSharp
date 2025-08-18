using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
// populate array numbers 1 -45 and print out numbers in array
namespace ConsoleApp1
{


    internal class Program
    {

        private static int[] lotto_numbers = new int[46];
        private static int[] selected_lotto_numbers = new int[7];
        static void Main(string[] args)
        {




            reset_lotto_numbers();
            user_select_numbers();




            Console.ReadKey();
        }

        private static void reset_lotto_numbers()
        {


            for (int i = 1; i < 46; i++)
            {
                lotto_numbers[i] = i;
            }

            for (int i = 1; i < 46; i++)
            {
                Console.Write(lotto_numbers[i] + ", ");
            }




        }
        private static void user_select_numbers()
        {

            Console.WriteLine("");
            for (int i = 1; i < 7; i++)
            {
                Console.WriteLine(" enter a number for " + i);
                try
                {
                    selected_lotto_numbers[i] = int.Parse(Console.ReadLine());

                }

                catch (Exception e)
                {
                    //Console.WriteLine(e.ToString());
                    Console.WriteLine("Enter a number only.");
                    i--;
                }



                Console.WriteLine("User selected Lotto numbers");



            }


            for (int j = 1; j < 7; j++)
            {

                Console.Write(selected_lotto_numbers[j] + " ,");
            }

            Console.ReadKey();

        }
    }
}