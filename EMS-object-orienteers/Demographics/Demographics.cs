using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace Demographics
{

    /// <summary>
    /// This class stores patient information
    /// </summary>
    /// <remarks>
    /// This class stores patient information so that it may be shown in the ui or
    /// so that it may be sent to the database. If the entries are not valid then 
    /// it will send an error message to the user through the DemographicsUI
    /// </remarks>
    public class Patient
    {
        /// <summary>
        /// Private data members to hold patient information
        /// </summary>
        private string HCN { get; set; }         //! Health card number, 10 numeric characters 2 alpha
        private string LastName { get; set; } 
        private string FirstName { get; set; }
        private string MInitial { get; set; }
        private string DateBirth { get; set; }  //! DDMMYYYY
        private char Sex { get; set; }          //! Sex possible values: M,F,I,H
        private string HeadOfHouse { get; set; }//! HCN of head of house
        private string AddressLine1 { get; set; }
        private string AddressLine2 { get; set; }
        private string City { get; set; }
        private string Province { get; set; }
        private string NumPhone { get; set; }

        /// <summary>
        /// Validate patient information
        /// </summary>
        /// <remarks>
        /// This function will check that all required fields have a value and that the values
        /// are in the proper format
        /// </remarks>
        /// <param name="patient"></param>
        /// <returns>true: successful, false: unsuccessful</returns>
        static public bool ValidatePatient(Patient patient) {
            Regex HCNRegex = new Regex("^[1-9]{10}[a-zA-Z]{2}$");
            Regex DateBirthRegex = new Regex("^[0-3]{2}[/]([1][0-2]|[0][1-9])[/][1-9][0-9]{3}");
            Regex PhoneNumRegex = new Regex("(^[+][0-9]|^)([1-9][0-9]{9}|[\\s-][1-9][0-9]{2}[\\s-][0-9]{3}[\\s-][0-9]{4})$");
            Regex ProvinceRegex = new Regex("^[a-zA-Z]{2}$");
            return false;
        }
    }

}
