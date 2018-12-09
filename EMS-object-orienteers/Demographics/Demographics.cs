using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using Support;

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
        private string HCN { get; set; }            //! Health card number, 10 numeric characters 2 alpha
        private string LastName { get; set; }
        private string FirstName { get; set; }
        private char MInitial { get; set; }
        private string DateBirth { get; set; }      //! DDMMYYYY
        private char Sex { get; set; }              //! Sex possible values: M,F,I,H
        private string HeadOfHouse { get; set; }    //! HCN of head of house
        private string AddressLine1 { get; set; }   //! Not required unless no head of house
        private string AddressLine2 { get; set; }   //! Optional
        private string City { get; set; }
        private string Province { get; set; }
        private string NumPhone { get; set; }

        /// <summary>
        /// Validate patient information
        /// </summary>
        /// <remarks>
        /// This method checks that the field is filled out properly
        /// and saves the input to that field if it is
        /// </remarks>
        /// <param name="field"></param>
        /// <param name="input"></param>
        /// <returns>true: successful, false: unsuccessful</returns>
        public bool Validate(string field, string input)
        {
            bool result = false;

            //! Check which field is being validated
            switch (field)
            {
                case "HCN":
                case "HeadOfHouse":
                    Regex HCNRegex = new Regex(@"^[1-9]{10}[a-zA-Z]{2}$");
                    if (HCNRegex.IsMatch(input))
                    {
                        if (field.Equals("HCN"))
                        {
                            this.HCN = input;
                            result = true;
                        }
                        else if (field.Equals("HeadOfHouse"))
                        {
                            this.HeadOfHouse = input;
                            result = true;
                        }
                        
                    }
                    break;
                case "DateBirth":
                    Regex DateBirthRegex = new Regex(@"^([3][0-1]|[1-2][0-9]|[0][1-9])[/]([1][0-2]|[0][1-9])[/][1-9][0-9]{3}$");
                    if (DateBirthRegex.IsMatch(input))
                    {
                        this.DateBirth = input;
                        result = true;
                    }
                    break;
                case "AddressLine 1":
                    Regex AddressRegex = new Regex(@"^\d*\s[a-zA-z]*\s[a-zA-z.]*$");
                    if (AddressRegex.IsMatch(input))
                    {
                        if (field.Equals("AddressLine1"))
                        {
                            this.AddressLine1 = input;
                            result = true;
                        }
                        else if (field.Equals("AddressLin2"))
                        {
                            this.AddressLine2 = input;
                            result = true;
                        }
                    }
                    break;
                case "Province":
                    Regex ProvinceRegex = new Regex(@"^[a-zA-Z]{2}$");
                    if (ProvinceRegex.IsMatch(input))
                    {
                        this.Province = input;
                        result = true;
                    }
                    break;
                case "NumPhone":
                    Regex PhoneNumRegex = new Regex(@"(^[+][0-9]|^[0-9]|^)(([\s-]|)[1-9][0-9]{9}|([\s-]|)[1-9][0-9]{2}[\s-][0-9]{3}[\s-][0-9]{4})$");
                    if (PhoneNumRegex.IsMatch(input))
                    {
                        this.NumPhone = input;
                        result = true;
                    }
                    break;
                case "FirstName":
                case "LastName":
                    Regex NameRegex = new Regex(@"^[a-zA-ZàâäôéèëêïîçùûüÿæœÀÂÄÔÉÈËÊÏÎŸÇÙÛÜÆŒäöüßÄÖÜẞąćęłńóśźżĄĆĘŁŃÓŚŹŻ]*$");
                    if (NameRegex.IsMatch(input))
                    {
                        if (field.Equals("FirstName"))
                        {
                            this.FirstName = input;
                        }
                        else if (field.Equals("LastName"))
                        {
                            this.LastName = input;
                        }
                        result = true;
                    }
                    break;
                case "MInitial":
                    char initial = Convert.ToChar(input);
                    if (char.IsLetter(initial)){
                        this.MInitial = initial;
                        result = true;
                    }
                    break;
                case "Sex":
                    //! Sex possible values: M,F,I,H
                    Regex SexRegex = new Regex(@"^[MFIHmfih]$");
                    if (SexRegex.IsMatch(input))
                    {
                        this.Sex = Convert.ToChar(input);
                        result = true;
                    }
                    break;
                default:
                    break;
            }

            return result;
        }
        public bool SetAddressLine2(string addressLine2)
        {
            this.AddressLine2 = addressLine2;
            return true;
        }
    }

}
