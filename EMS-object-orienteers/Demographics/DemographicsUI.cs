using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Support;


namespace Demographics
{

    /// <summary>
    /// This class creates the ui for creating and updating patient information
    /// </summary>
    /// <remarks>
    /// The methods in this class create different ui for updating a patient, creating a new patient and searching for a patient
    /// </remarks>
    public class DemographicsUI
    {
        private const int MIN_X_VALUE = 22;
        private const int MIN_Y_VALUE = 2;



        /// <summary>
        /// Check if patient is already present in the database
        /// </summary>
        /// <remarks>
        /// This function will request the support class to check if the HCN is 
        /// already in the database
        /// </remarks>
        /// <param name="HCN"></param>
        /// <returns>true: Present in database, false: Not present</returns>
        public static bool CheckIfPresent(string HCN)
        {
            if (Database.CreateNewDatabase("Patients", 1000, "HCN"))
            {
                //! Send HCN to search function in database
                if (Search(HCN) != "")
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Create ui to prompt user for patient information
        /// </summary>
        /// <remarks>
        /// This function will prompt the user to enter the patient's information
        /// </remarks>
        /// <param name="HCN"></param>
        /// <returns>true: successful, false: unsuccessful</returns>
        public static bool PromptForInfo(string HCN)
        {
            Patient patient = new Patient();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Please enter patient information");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Health Card Number   :");
            Console.WriteLine("Lastname             :");
            Console.WriteLine("Firstname            :");
            Console.WriteLine("Middle initial       :");
            Console.WriteLine("Date of birth        :");
            Console.WriteLine("Sex                  :");
            Console.WriteLine("Head of Household    :");
            Console.WriteLine("Address Line 1       :");
            Console.WriteLine("Address Line 2       :");
            Console.WriteLine("City                 :");
            Console.WriteLine("Province             :");
            Console.WriteLine("Phone number         :");
            Console.WriteLine("Done                 :");

            if (CheckIfPresent(HCN))
            {
                //! Prefill patient information
                string[] patientString = Search(HCN).Split('|');
                int y = 2;

                //! Fill each line with the corresponding information
                for (int i = 0 ; y <= 14; i++)
                {
                    Console.SetCursorPosition(MIN_X_VALUE, y);
                    Console.WriteLine(patientString[i]);
                }
            }

            Console.SetCursorPosition(MIN_X_VALUE, MIN_Y_VALUE);
            ConsoleKeyInfo input;
            string value = "";
            int xPos = MIN_X_VALUE;
            int yPos = MIN_Y_VALUE;
            //! Check which key is being pressed to move the cursor
            while (true)
            {
                do
                {
                    input = Console.ReadKey(true);
                    if (input.Key == ConsoleKey.UpArrow && yPos > MIN_Y_VALUE)
                    {
                        --yPos;
                    }
                    else if (input.Key == ConsoleKey.DownArrow && yPos < 14)
                    {
                        ++yPos;
                    }
                    Console.SetCursorPosition(xPos, yPos);

                }
                while (input.Key != ConsoleKey.Enter);

                //! Break if done is chosen
                if (yPos == 14)
                {
                    break;
                }

                value = Console.ReadLine();

                if (!CheckLine(patient, yPos, value))
                {
                    Console.SetCursorPosition(MIN_X_VALUE, yPos);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(value);
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                
                Console.SetCursorPosition(MIN_X_VALUE, yPos);

            }
            return false;
        }

        public static bool CheckLine(Patient patient, int yPos, string value)
        {
            bool result = false;
            switch (yPos)
            {
                case 2:
                    result = patient.Validate("HCN", value);
                    break;
                case 3:
                    result = patient.Validate("LastName", value);
                    break;
                case 4:
                    result = patient.Validate("FirstName", value);
                    break;
                case 5:
                    result = patient.Validate("MInitial", value);
                    break;
                case 6:
                    result = patient.Validate("DateBirth", value);
                    break;
                case 7:
                    result = patient.Validate("Sex", value);
                    break;
                case 8:
                    result = patient.Validate("HeadOfHouse", value);
                    break;
                case 9:
                    result = patient.Validate("AddressLine1", value);
                    break;
                case 10:
                    result = patient.Validate("AddressLine2", value);
                    break;
                case 11:
                    result = patient.Validate("City", value);
                    break;
                case 12:
                    result = patient.Validate("Province", value);
                    break;
                case 13:
                    result = patient.Validate("NumPhone", value);
                    break;
            }
            return result;
        }

        /// <summary>
        /// Create ui to prompt user to enter information to update for patient
        /// </summary>
        /// <remarks>
        /// This function will prompt the user with the current information for the patient
        /// and then allow the user to update fields that have changed
        /// </remarks>
        /// <param name="HCN"></param>
        public static void UpdatePatient(string HCN)
        {
            if (CheckIfPresent(HCN))
            {
                Search(HCN);
            }
            //! Receive patient information back
            //! Show patient information and allow edits
        }

        /// <summary>
        /// Send 
        /// </summary>
        /// <remarks>
        /// This function will prompt the user with the current information for the patient
        /// and then allow the user to update fields that have changed
        /// </remarks>
        /// <param name="HCN"></param>
        public static string Search(string HCN)
        {
            string searchResult = "";
            Database patients = new Database("Patients");

            searchResult = patients.GetRecord(HCN);
            return searchResult;
        }

        public bool AddPatient(Patient patient)
        {
            Database db = new Database("Patients");

            return db.AddRecord("");
        }
    }
}
