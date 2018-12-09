﻿using System;
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
            Console.WriteLine("Please enter patient information");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Health Card Number:");
            Console.WriteLine("Lastname:");
            Console.WriteLine("Firstname:");
            Console.WriteLine("Middle initial:");
            Console.WriteLine("Date of birth:");
            Console.WriteLine("Sex:");
            Console.WriteLine("Head of Household:");
            Console.WriteLine("Address Line 1:");
            Console.WriteLine("Address Line 2:");
            Console.WriteLine("City:");
            Console.WriteLine("Province:");
            Console.WriteLine("Phone number:");
            return false;
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
            if(CheckIfPresent(HCN)){
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
    }
}
