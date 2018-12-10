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
        public string HCN { get; private set; }            //! Health card number, 10 numeric characters 2 alpha
        public string LastName { get; set; }
        public string FirstName { get; set; }
        private char MInitial { get; set; }
        private string DateBirth { get; set; }      //! DDMMYYYY
        private char Sex { get; set; }              //! Sex possible values: M,F,I,H
        private string HeadOfHouse { get; set; }    //! HCN of head of house
        public string AddressLine1 { get; private set; }   //! Not required unless no head of house
        public string AddressLine2 { get; private set; }   //! Optional
        public string City { get; private set; }
        public string Province { get; private set; }
        public string NumPhone { get; private set; }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string thisstring = "";
            thisstring += this.HCN + "|" + this.LastName + "|" + this.FirstName + "|" + this.MInitial + "|" + this.DateBirth +
                "|" + this.Sex + "|" + this.HeadOfHouse + "|" + this.AddressLine1 + "|" + this.AddressLine2 + "|" + this.City
                + "|" + this.Province + "|" + this.NumPhone;

            return thisstring;
        }


        public static Patient addPatient()
        {
            Patient tempPatient = new Patient();
            //! Get HCN before other info to prefill if patient already exists
            Console.Clear();
            Console.WriteLine("Please enter the Health Card number for the patient: ");
            tempPatient.HCN = Console.ReadLine();

            while (!tempPatient.Validate("HCN", tempPatient.HCN))
            {
                Console.Clear();
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Invalid HCN. Must be 10 digits followed by 2 letters");
                tempPatient.HCN = Console.ReadLine();
            }
            //! Only prompt for info once a valid HCN has been entered
            tempPatient = DemographicsUI.PromptForInfo(tempPatient.HCN);
            DemographicsUI.AddPatient(tempPatient);

            return tempPatient;
        }

        public static Patient[] addPatientWithCaregiver()
        {

            Patient[] patients = new Patient[]
            {
                new Patient(),
                new Patient()
            };
            Patient tempPatient = new Patient();

            Console.Clear();
            Console.WriteLine("Please enter the Health Card number for the caregiver: ");
            tempPatient.HCN = Console.ReadLine();

            while (!tempPatient.Validate("HCN", tempPatient.HCN))
            {
                Console.Clear();
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Invalid HCN. Must be 10 digits followed by 2 letters");
                tempPatient.HCN = Console.ReadLine();
            }
            patients[0] = DemographicsUI.PromptForInfo(tempPatient.HCN);

            tempPatient = new Patient();

            Console.Clear();
            Console.WriteLine("Please enter the Health Card number for the patient: ");
            tempPatient.HCN = Console.ReadLine();
            while (!tempPatient.Validate("HCN", tempPatient.HCN))
            {
                Console.Clear();
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Invalid HCN. Must be 10 digits followed by 2 letters");
                tempPatient.HCN = Console.ReadLine();
            }
            patients[1] = DemographicsUI.PromptForInfo(tempPatient.HCN, patients[0]);

            DemographicsUI.AddPatient(patients[0]);
            DemographicsUI.AddPatient(patients[1]);

            return patients;
        }




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
                    //Regex AddressRegex = new Regex(@"^\d*\s[a-zA-z ]*\s[a-zA-z.]*$");

                    this.AddressLine1 = input;
                    result = true;

                    break;
                case "AddressLine 2":
                    //Regex AddressRegex = new Regex(@"^\d*\s[a-zA-z ]*\s[a-zA-z.]*$");

                    this.AddressLine2 = input;
                    result = true;

                    break;
                case "City":
                    this.City = input;
                    result = true;
                    break;
                case "Province":
                    string[] provinces = {"AB","BC","MB","NB","NL","NS",
                        "NT","NU","ON","PE","QC","SK","YT"};
                    if (provinces.Contains(input))
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
                    //! Ministry only accepts standard ascii
                    Regex NameRegex = new Regex(@"^[a-zA-Z]*$");
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
                    if (char.IsLetter(initial))
                    {
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
    }
}
