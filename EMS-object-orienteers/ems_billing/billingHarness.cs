// FILE 			: billingHarness.cs
// PROJECT          : INFO2180 EMS Solution
// PROGRAMMER 		: Brendan Brading, Object Orienteers
// FIRST VERSION 	: December 7th 2018
// DESCRIPTION 	    : Contains the test harness for the billing module.
using billing;
using System;

namespace ems_billing_TEST
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is the following for the ad billing code and 
            string recall = "";
            bool success = true;
            try
            {
                //This date format and my respective function will probably have to be changed.
                //Else the call requires the billing code, the HCN and potentially the gender, can parse that out 
                //seperately within the function
                //if (Billing.AddBillingCode(DateVariable, BillingCode, "1234567890AB") == false)
                //{
                //    Console.WriteLine("Invalid Billing Code.\n");
                //    success = false;
                //}
            }
            //The following exception catching handles a flag for recall or an argument exception scenario being thrown by bad information
            catch (Billing.BillingRecallException ex)
            {
                recall = ex.Message;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                success = false;
            }
            //This finally happens regardless if an exception was thrown
            finally
            {
                // Display if the code was successfully done
                if (success == true)
                {
                    Console.WriteLine("Success\n");
                    // billing code success, recall thrown
                    if (recall != "")
                    {
                        Console.WriteLine("Recall in " + recall + "\n");
                        Console.ReadKey(true);
                    }
                }
            }
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //This is the function call to get the billing reports for a specific month
            //This method requires an int for the month, 1-12 and the year as an int.
            Billing.ViewReport(12, 2018);
          
        }
    }
}



