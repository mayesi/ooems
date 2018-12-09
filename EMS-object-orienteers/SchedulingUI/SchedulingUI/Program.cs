using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulingUI
{
    class Program
    {
        public const string newPariant = "1";
        public const string newPatiantWC = "2";
        public const string schMenu = "3";
        public const string billMenu = "4";
        public const string quit = "5";
        static void Main(string[] args)
        {
            //starting menu
            bool run = true;
            Console.Title ="ESM";
            Console.ForegroundColor = ConsoleColor.Green;
            string userInput = "";
            Schedule sch = new Schedule();

            while (run)
            {
                userInput = Menu.mainMenu();
                Console.Clear();
                switch(userInput)
                {
                    case newPariant:
                        //call demographics
                        break;
                    case newPatiantWC:
                        //call demographics
                        break;
                    case schMenu:
                        
                        Schedule.ScheduleMenu();
                        break;
                    case billMenu:
                        Menu.BillingMenu();
                        break;
                    case quit:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.Write("Please select an option between 1-5");
                        break;
                }
            }
        }
    }
}
