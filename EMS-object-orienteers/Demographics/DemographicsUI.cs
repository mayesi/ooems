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
        private const int MIN_X_VALUE = 26;
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
            try
            {
                Database.CreateNewDatabase("Patients", 1000, "HCN");
            }
            catch (ArgumentException)
            { 
                //! Send HCN to search function in database
                if (Search(HCN) != "")
                {
                    return true;
                }
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
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
        public static Patient PromptForInfo(string HCN)
        {
            Console.Clear();
            Console.CursorVisible = true;
            Patient patient = new Patient();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Please enter patient information");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Health Card Number       :");
            Console.WriteLine("Lastname                 :");
            Console.WriteLine("Firstname                :");
            Console.WriteLine("Middle initial           :");
            Console.WriteLine("Date of birth DD/MM/YYYY :");
            Console.WriteLine("Sex                      :");
            Console.WriteLine("Head of Household        :");
            Console.WriteLine("Address Line 1           :");
            Console.WriteLine("Address Line 2 optional  :");
            Console.WriteLine("City                     :");
            Console.WriteLine("Province                 :");
            Console.WriteLine("Phone number xxx xxx xxxx:");
            Console.WriteLine("Done                     :");

            if (CheckIfPresent(HCN))
            {
                //! Prefill patient information
                int numFields = 0;
                string[] patientString = Search(HCN).Split('|');
                int y = 2;
                numFields = patientString.Length;
                //! Fill each line with the corresponding information
                for (int i = 0 ; i <= 11; i++)
                {
                    Console.SetCursorPosition(MIN_X_VALUE, y);
                    Console.WriteLine(patientString[i]);
                    ++y;
                }
                patient.Validate("HCN", patientString[0]);
                patient.Validate("LastName", patientString[1]);
                patient.Validate("FirstName", patientString[2]);
                patient.Validate("MInitial", patientString[3]);
                patient.Validate("DateBirth", patientString[4]);
                patient.Validate("Sex", patientString[5]);
                patient.Validate("HeadOfHouse", patientString[6]);
                patient.Validate("Address Line 1", patientString[7]);
                patient.Validate("Address Line 2", patientString[8]);
                patient.Validate("City", patientString[9]);
                patient.Validate("Province", patientString[10]);
                patient.Validate("NumPhone", patientString[11]);

            }

            Console.SetCursorPosition(MIN_X_VALUE, MIN_Y_VALUE);
            Console.WriteLine(HCN);
            patient.Validate("HCN",HCN);
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
            return patient;
        }

        public static Patient PromptForInfo(string HCN, Patient careGiver)
        {
            Console.Clear();
            Console.CursorVisible = true;
            Patient patient = new Patient();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Please enter patient information");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Health Card Number       :");
            Console.WriteLine("Lastname                 :");
            Console.WriteLine("Firstname                :");
            Console.WriteLine("Middle initial           :");
            Console.WriteLine("Date of birth DD/MM/YYYY :");
            Console.WriteLine("Sex                      :");
            Console.WriteLine("Head of Household        :");
            Console.WriteLine("Address Line 1           :");
            Console.WriteLine("Address Line 2 optional  :");
            Console.WriteLine("City                     :");
            Console.WriteLine("Province                 :");
            Console.WriteLine("Phone number xxx xxx xxxx:");
            Console.WriteLine("Done                     :");

            if (CheckIfPresent(HCN))
            {
                //! Prefill patient information
                int numFields = 0;
                string[] patientString = Search(HCN).Split('|');
                int y = 2;
                numFields = patientString.Length;
                //! Fill each line with the corresponding information
                for (int i = 0; i <= 11; i++)
                {
                    Console.SetCursorPosition(MIN_X_VALUE, y);
                    Console.WriteLine(patientString[i]);
                    ++y;
                }
                patient.Validate("HCN", patientString[0]);
                patient.Validate("LastName", patientString[1]);
                patient.Validate("FirstName", patientString[2]);
                patient.Validate("MInitial", patientString[3]);
                patient.Validate("DateBirth", patientString[4]);
                patient.Validate("Sex", patientString[5]);
                patient.Validate("HeadOfHouse", patientString[6]);
                patient.Validate("Address Line 1", patientString[7]);
                patient.Validate("Address Line 2", patientString[8]);
                patient.Validate("City", patientString[9]);
                patient.Validate("Province", patientString[10]);
                patient.Validate("NumPhone", patientString[11]);
            }

            Console.SetCursorPosition(MIN_X_VALUE, 2);
            Console.WriteLine(HCN);

            //! Fill out caregiver's information that is the same for the patient
            Console.SetCursorPosition(MIN_X_VALUE, 9);
            Console.WriteLine(careGiver.AddressLine1);
            patient.Validate("AddressLine 1",careGiver.AddressLine1);
            Console.SetCursorPosition(MIN_X_VALUE, 10);
            Console.WriteLine(careGiver.AddressLine2);
            patient.Validate("AddressLine 2", careGiver.AddressLine2);

            Console.SetCursorPosition(MIN_X_VALUE, 11);
            Console.WriteLine(careGiver.City);
            patient.Validate("City", careGiver.City);

            Console.SetCursorPosition(MIN_X_VALUE, 12);
            Console.WriteLine(careGiver.Province);
            patient.Validate("Province", careGiver.Province);

            Console.SetCursorPosition(MIN_X_VALUE, 13);
            Console.WriteLine(careGiver.NumPhone);
            patient.Validate("NumPhone", careGiver.NumPhone);



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
            return patient;
        }

        /// <summary>
        /// Check if current input line is valid
        /// </summary>
        /// <remarks>
        /// This function will check which value the line that is highlighted is referring to.
        /// It will then validate the value that is there
        /// </remarks>
        /// <param name="patient"></param>
        /// <param name="yPos"></param>
        /// <param name="value"></param>
        /// <returns>true: successful, false: unsuccessful</returns>
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
                    result = patient.Validate("AddressLine 1", value);
                    break;
                case 10:
                    result = patient.Validate("AddressLine 2", value);
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
                if(Search(HCN) != "")
                {
                    
                }
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

        /// <summary>
        /// Add a patient to the database
        /// </summary>
        /// <remarks>
        /// This function will split the patient into a string and send that to be
        /// saved by the database
        /// </remarks>
        /// <param name="patient"></param>
        /// <returns>true: successful, false: unsuccessful</returns>
        static public bool AddPatient(Patient patient)
        {
            Database db = new Database("Patients");
            try
            {
                return db.AddRecord(patient.ToString());
            }
            catch
            {
                Console.WriteLine("Patient already exists in database");
                return false;
            }
        }
        public bool PatientWithCaregiver(string HCN)
        {
            Patient careGiver = PromptForInfo(HCN);
            PromptForInfo(careGiver.HCN);
            return false;
        }
    }
}
