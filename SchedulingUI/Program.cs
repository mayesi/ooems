using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulingUI
{
    /// 
    /// \class Program
    ///
    /// \brief The purpose of this class is to control which UI elements are displayed
    /// to the user
    ///
    /// This file contains the class methods used in Program.cs.
    ///
    /// \author A <i>Sean O'Brien</i>
    ///
    class Program
    {
        public const int newPatient = 49;
        public const int newPatientWC = 50;
        public const int schMenu = 51;
        public const int billMenu = 52;
        public const int quit = 53;
        static void Main(string[] args)
        {
            //starting menu
            bool run = true;
            Console.Title ="EMS";
            Console.ForegroundColor = ConsoleColor.Green;
            int userInput = 0;
            Menu mu = new Menu();
            Schedule sch = new Schedule();

            while (run)
            {
                userInput = mu.mainMenu();
                Console.Clear();
                switch(userInput)
                {
                    case newPatient:
                        
                        break;
                    case newPatientWC:                     
                        
                        break;
                    case schMenu:
                        
                        sch.period();
                        break;
                    case billMenu:
                        mu.billingMenu();
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
