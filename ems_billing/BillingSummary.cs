using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ems_billing
{
    /// <summary>
    /// This class produces billing summaries. It uses the Ontario Ministry of Health
    /// standards for generating billing summaries. It generates these using encounter
    /// information stored in a database in the EMS. Exceptions are thrown for database,
    /// file, and parameter errors.
    /// </summary>
    class BillingSummary
    {
        //These are the values we are required to keep track of. 
        private int EncountersBilled { get; set; }          /// sum of encounters that month
        private float TotalBilledProcedures { get; set; }   /// total billed in dollars
        private float ReceivedTotal { get; set; }           /// total received in dollars
        private float ReceivedPercentage { get; set; }      /// (received total)/(total billed)*100
        private float AverageBilling { get; set; }          /// (received total)/(total encounters billed) in dollars
        private int FollowUpEncounters { get; set; }        /// number of encounters to follow-up, sum of 'flag encounters for review' and 'contact ministry of health'


        /// <summary>
        /// Generates the billing summary file
        /// </summary>
        /// <param name="month">the month to summarize</param>
        public void GenerateBillingSummary(string month)
        {
            
        }


        /// <summary>
        /// Displays the monthly billing summary
        /// </summary>
        /// <param name="month">the month to display</param>
        public void DisplayBillingSummary(string month)
        {

        }


        /// <summary>
        /// Default constructor
        /// </summary>
        BillingSummary()
        {

        }


        /// <summary>
        /// The full billing summary constructor
        /// </summary>
        /// <param name="Encounter"> num of encounters billed</param>
        /// <param name="total"> total billed </param>
        /// <param name="received"> money received </param>
        /// <param name="percentage"> received percentage</param>
        /// <param name="avg"> average amount per encounter </param>
        /// <param name="followup"> followup </param>
        BillingSummary(int Encounter, float total, float received, float percentage, float avg, int followup)
        {

        }



        /// <summary>
        /// Calculates entire response file and returns the results in a string
        /// </summary>
        /// <param name="All"> An array of response files</param>
        /// <returns> results of the calculations</returns>
        public static string CalculateResponse(string[] All)
        {
            string allItems = "";



            return allItems;
        }


        /// <summary>
        /// Parses out the item from the string to store.
        /// </summary>
        /// <param name="allItems">string containing all items</param>
        /// <param name="field">where to parse the value for a field</param>
        /// <returns>value of that parsed calculation</returns>
        public static double ParseCalculatedResponse(string allItems, int field)
        {
            double value = 0.00;
            return value;
        }
    }
}
