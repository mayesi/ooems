using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demographics;

namespace SchedulingUI
{
    class Program
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
            string HCN = "";

            while (run)
            {
                userInput = Menu.mainMenu();
                Console.Clear();
                switch (userInput)
                {
                    case newPatient:

                        //! Get HCN before other info to prefill if patient already exists
                        Console.Clear();
                        Console.WriteLine("Please enter the Health Card number for the patient: ");
                        HCN = Console.ReadLine();

                        while (!tempPatient.Validate("HCN", HCN))
                        {
                            Console.Clear();
                            Console.SetCursorPosition(0, 0);
                            Console.WriteLine("Invalid HCN. Must be 10 digits followed by 2 letters");
                            HCN = Console.ReadLine();
                        }
                        //! Only prompt for info once a valid HCN has been entered
                        tempPatient = DemographicsUI.PromptForInfo(HCN);
                        DemographicsUI.AddPatient(tempPatient);
                        break;
                    case newPatientwc:

                        //! Get HCN before other info to prefill if patient already exists
                        Console.Clear();
                        Console.WriteLine("Please enter the Health Card number for the caregiver: ");
                        HCN = Console.ReadLine();

                        while (!tempPatient.Validate("HCN", HCN))
                        {
                            Console.Clear();
                            Console.SetCursorPosition(0, 0);
                            Console.WriteLine("Invalid HCN. Must be 10 digits followed by 2 letters");
                            HCN = Console.ReadLine();
                        }
                        Patient careGiver = DemographicsUI.PromptForInfo(HCN);
                        HCN = "";

                        Console.Clear();
                        Console.WriteLine("Please enter the Health Card number for the patient: ");
                        HCN = Console.ReadLine();
                        while (!tempPatient.Validate("HCN", HCN))
                        {
                            Console.Clear();
                            Console.SetCursorPosition(0, 0);
                            Console.WriteLine("Invalid HCN. Must be 10 digits followed by 2 letters");
                            HCN = Console.ReadLine();
                        }
                        Patient patient = DemographicsUI.PromptForInfo(HCN, careGiver);

                        DemographicsUI.AddPatient(careGiver);
                        DemographicsUI.AddPatient(patient);
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
