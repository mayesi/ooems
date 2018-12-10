using System;
using SchedulingUI;
using Demographics;

namespace EMS_object_orienteers
{
    class EMSTesting
    {
        public const string newPatient = "1";
        public const string newPatientwc = "2";
        public const string schMenu = "3";
        public const string billMenu = "4";
        public const string quit = "5";
        static void Main(string[] args)
        {
            //starting menu
            bool run = true;
            Console.Title = "ESM";
            Console.ForegroundColor = ConsoleColor.Green;
            string userInput = "";
            Schedule sch = new Schedule();
            Patient tempPatient = new Patient();

            while (run)
            {
                userInput = Menu.mainMenu();
                Console.Clear();
                switch (userInput)
                {
                    case newPatient:
                        //! Get HCN before other info to prefill if patient already exists
                        Patient.addPatient();
                        Menu.mainMenu();
                        break;

                    case newPatientwc:
                        //! Get HCN before other info to prefill if patient already exists
                        Patient.addPatientWithCaregiver();
                        Menu.mainMenu();
                        break;

                    case schMenu:
                        Schedule.ScheduleMenu("");
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
