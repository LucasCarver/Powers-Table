using System;

namespace PowersTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Powers Table\n");
            do
            {
                DrawPowersTable();
            } while (!ExitLoop());

        }

        // draws powers 1-3
        public static void DrawPowersTable()
        {
            int userNum;
            userNum = EnterInt("Please enter a positive integer: ");
            Console.WriteLine("{0,10} {1,10} {2,10}", "Number", "Squared", "Cubed");
            Console.WriteLine("================================");

            for (int i = 1; i <= userNum; i++)
            {
                long powerOne = Powers(i,1);
                long powerTwo = Powers(i, 2);
                long powerThree = Powers(i, 3);
                Console.WriteLine("{0,10} {1,10} {2,10}", $"{powerOne}", $"{powerTwo}", $"{powerThree}");
            }
        }

        // prompts the user to enter a number
        public static int EnterInt(string prompt)
        {
            int temp;
            bool stopLoop = false;
            string tempString = "";
            do
            {
                Console.Write(prompt);
                tempString = Console.ReadLine();
                stopLoop = int.TryParse(tempString,out temp);
                if(temp <= 0)
                {
                    stopLoop = false;
                }
                if (!stopLoop)
                {
                    Console.WriteLine("Invalid entry.\n");
                }
            } while (!stopLoop);
            return temp;
        }

        // prompts and gets input
        public static string EnterResponse(string prompt)
        {
            Console.Write(prompt);
            string input = Console.ReadLine();
            return input;
        }

        // flexible powers
        // long to expand functional output range
        public static long Powers(int baseNum, int power)
        {
            if (power == 0)
            {
                return 1;
            }
            else
            {
                long temp = 1;
                for (int i = 0; i < power; i++)
                {
                    temp *= baseNum;
                }
                return temp;
            }
        }


        // exit condition
        public static bool ExitLoop()
        {
            bool stopLoop = false;
            string tempString;
            do
            {
                tempString = EnterResponse("Would you like to try again?").ToLower();
                if (tempString == "y" || tempString == "n")
                {
                    stopLoop = true;
                }
                else
                {
                    Console.WriteLine("Invalid entry.\n");
                    stopLoop = false;
                }
            } while (!stopLoop);
            if (tempString == "n")
                return true;
            else
                return false;
        }
    }
}