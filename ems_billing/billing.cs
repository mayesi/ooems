using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ems_billing
{
    /// <summary>
    /// This class handles billing related functions in the EMS, such as producing
    /// database records and the UI. In particular, it interacts with the Menu and 
    /// Database classes. Exceptions are thrown for file IO, database, and parameter
    /// errors.
    /// </summary>
    class Billing
    {
        // learn how to build a class in C#
        // learn how to create different getters and setters
        // 

        // Private Data Members
        
        private string Month { get; set; } /// The month for the record to be kept in 
        // For Billing File
        private string DateOfAppointment { get; set; } /// The date of the appointment
        private string HealthCardNumber { get; set; } /// the HCN of the patient
        private char Gender { get; set; } /// this contains the persons gender
        private string BillingCode { get; set; } /// This contains the billing code for the visit
        private double Fee { get; set; } /// This will contain the fee for the visit

        //For Reconcile File
        private string Response { get; set; } /// This will contain the response for the response code for this billing entry


        /// <summary>
        /// This method adds a billing code to a record and stores that record in
        /// the Billing database.
        /// </summary>
        /// <remarks>
        /// This method gets the billing information from the patient database needed,
        /// and the fee from the master file associated with that code. It then adds
        /// that record into a billing records database.
        /// </remarks>
        /// <param name="Date"> visit date </param>
        /// <param name="Code"> billing code </param>
        /// <param name="HCN"> health card number </param>
        public void AddBillingCode(string Date, string Code, string HCN)
        {
            
        }



        /// <summary>
        /// Parses out the response from the billing summary.
        /// </summary>
        /// <param name="billingRecord">the record</param>
        /// <returns> the response code is returned  </returns>
        public string ParseReconcileEntry(string billingRecord)
        {
            string responseCode = "";
            return responseCode;
        }

        




        /// <summary>
        /// Parses the billing record database, and pulls all of the records into a single monthly bill.
        /// </summary>
        /// <param name="month"> month for the bill to be made</param>
        public void GenerateMonthlyBill(string month)
        {

        }


        /// <summary>
        /// Parses the master billing file for the fee associated with the code in question.
        /// </summary>
        /// <param name="code">The </param>
        /// <returns>The Fee of the master billing file</returns>
        public double ParseMasterBillingFile(string code)
        {
            double fee = 00.00;

            return fee;
        }
        
        ///<summary>
        /// Default constructor for the billing class
        ///</summary>
        Billing()
        {
            Month = "";
            DateOfAppointment = "";
            HealthCardNumber = "";
            Gender = 'U';
            BillingCode = "";
            Fee = 00.00;
            Response = "";
        }



        /// <summary>
        /// Constructor for generating a billing Object without response code.
        /// </summary>
        /// <param name="BMonth">Billed Month</param>
        /// <param name="DoA">Date of Appointment</param>
        /// <param name="HCN">Health Card Number</param>
        /// <param name="BGender">Gender of the patient</param>
        /// <param name="BC">Billing Code</param>
        /// <param name="BFee">Billed Fee</param>
        Billing(string BMonth, string DoA, string HCN, char BGender, string BC, double BFee)
        {
            Month = BMonth;
            DateOfAppointment = DoA;
            HealthCardNumber = HCN;
            Gender = BGender;
            BillingCode = BC;
            Fee = BFee;
            Response = "";
        }



        /// <summary>
        /// Constructor for generating a billing Object with response code.
        /// </summary>
        /// <param name="BMonth">Billed Month</param>
        /// <param name="DoA">Date of Appointment</param>
        /// <param name="HCN">Health Card Number</param>
        /// <param name="BGender">Gender of the patient</param>
        /// <param name="BC">Billing Code</param>
        /// <param name="BFee">Billed Fee</param>
        /// <param name="Reconcile">The Response code from the goverment</param>
        Billing(string BMonth, string DoA, string HCN, char BGender, string BC, double BFee, string Reconcile)
        {
            Month = BMonth;
            DateOfAppointment = DoA;
            HealthCardNumber = HCN;
            Gender = BGender;
            BillingCode = BC;
            Fee = BFee;
            Response = Reconcile;
        }



        /// <summary>
        /// This method provides the user interface for the Billing class.
        /// </summary>
        public void BillingUI()
        {

        }
    }
}
