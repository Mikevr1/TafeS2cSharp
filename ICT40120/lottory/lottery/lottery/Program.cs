using System.Security.Cryptography.X509Certificates;

namespace lottery
{
    internal class Program
    {

        private static int Range;
        private static int Total;
        

        private static int[] SelectionNumbersArray = new int[Total];// randomized numbers
        private static int[] PickNumbersArray = new int[Range];//total numbers to select from
        private static int[] UserPickedNumbersArray = new int[Range];// numbers picked by user
        private static int[] SystemPickedNumbersArray = new int[Range];// numbers picked by System

        private static Random ScrambeledEggs = new Random();// random number generator


        static void Main(string[] args)
        {




            BannerTitle();
            Instructions();
            Play();



        }

        public static void BannerTitle()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(@"          _          _   _                         
        __/\__ | |    ___ | |_| |_ ___ _ __ _   _  __/\__
        \    / | |   / _ \| __| __/ _ \ '__| | | | \    /
        /_  _\ | |__| (_) | |_| ||  __/ |  | |_| | /_  _\
          \/   |_____\___/ \__|\__\___|_|   \__, |   \/  
                                            |___/         ");

            Console.ForegroundColor = ConsoleColor.Green;



        }


        public static void Instructions()
        {
            Console.WriteLine(@"
        *********************************************
        *  Choose Numbers When prompted.            *
        *  The Program Will Generate Random Numbers.* 
        *  Any matches that the program finds       *
        *  Will be displayed to you.                *
        *********************************************");


        }

        public static bool IsValueInArray(int[] array, int value)
        {
            foreach (int item in array)
            {
                if (item == value)
                {
                    return true; // Value found in the array
                }
            }
            return false; // Value not found in the array
        }




        public static void Play()
        {



            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Enter TOTAL Numbers To select from");
            while (!int.TryParse(Console.ReadLine(), out Total) || Total <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERROR enter a value");
                Console.ForegroundColor = ConsoleColor.White;
            }

            Console.WriteLine("Enter RANGE of Numbers To Enter");
            while (!int.TryParse(Console.ReadLine(), out Range) || Range <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERROR Enter RANGE of Numbers To Enter");
                Console.ForegroundColor = ConsoleColor.White;
            }
            SelectionNumbersArray = new int[Total];
            PickNumbersArray = new int[Total];
            UserPickedNumbersArray = new int[Range];
            SystemPickedNumbersArray = new int[Range];

            for (int i = 0; i < Total; i++)
            {
                SelectionNumbersArray[i] = i + 1;
                PickNumbersArray[i] = i + 1; 

            }
            Console.Clear();
            Console.WriteLine("Total Numbers ");
            Console.ForegroundColor = ConsoleColor.White;

            foreach (int i in PickNumbersArray)
            {
                Console.Write(" " + i);
                Console.Write("");

            }
            Console.WriteLine();


            ScrambeledEggs.Shuffle(SelectionNumbersArray);//randomize the array numbers


            int Temp;
            for (int i = 0; i < Range; i++)
            {
                Temp =SelectionNumbersArray[i];
                SystemPickedNumbersArray[i]= Temp;// numbers picked by System from randomized array no duplicates
            }


            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Total Numbers Randomized");
            Console.ForegroundColor = ConsoleColor.White;
            
            foreach (int i in SelectionNumbersArray)
            {
                Console.Write(" " + i);
                Console.Write("");

            }
            Console.WriteLine();
            
               
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("");
            Console.WriteLine($"Enter {Range} Numbers bettween 1 and {Total}");

            for (int i = 0; i < Range; i++)
            {


                int userInput;
                while (!int.TryParse(Console.ReadLine(), out userInput) || userInput <= 0
                                || (!IsValueInArray(PickNumbersArray, userInput)))


                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ERROR: Please enter a valid number.");
                    Console.ForegroundColor = ConsoleColor.White;
                }
             

                UserPickedNumbersArray[i] = userInput;// numbers picked by user

                
            }
            foreach (int i in UserPickedNumbersArray)
            {
                Console.Write(" " + i);
                Console.Write("");

            }

            Console.WriteLine();    
            foreach (int i in SystemPickedNumbersArray)
            {
                Console.Write(" " + i);
                Console.Write("");

            }





        }




    }

        

         



}



        
        

















































