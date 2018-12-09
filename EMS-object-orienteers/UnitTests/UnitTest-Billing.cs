using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class UnitTestBilling
    {
        /// <summary>
        /// 
        /// Test Name           : BILLING_TEST_Constructor_Default
        /// Description         : Verify the default constructor works as expected
        /// Performed           : Manual: Call the constructor and use the overloaded tostring() to determine
        /// Type                : functional
        /// Expected outcome    : Default values in place and empty strings
        ///
        /// </summary>
        [TestMethod]
        public void BILLING_TEST_Constructor_Default()
        {
        }

        /// <summary>
        /// 
        /// Test Name           : BILLING_TEST_Constructor_WithoutResponce
        /// Description         : Verify the main constructor works as expected without a response
        /// Performed           : Manual: Call the constructor with the A655 code and todays date with a valid HCN and use the overloaded tostring() to determine
        /// Type                : functional
        /// Expected outcome    : The proper values within the to string
        ///
        /// </summary>
        [TestMethod]
        public void BILLING_TEST_Constructor_WithoutResponse()
        {
        }

        /// <summary>
        /// 
        /// Test Name           : BILLING_TEST_Constructor_WithResponse
        /// Description         : Verify the main constructor works as expected without a response
        /// Performed           : Manual: Call the constructor with the A655 code and todays date with a valid HCN and response code and use the overloaded tostring() to determine
        /// Type                : functional
        /// Expected outcome    : The proper values within the to string
        ///
        /// </summary>
        [TestMethod]
        public void BILLING_TEST_Constructor_WithResponse()
        {
        }

        /// <summary>
        /// 
        /// Test Name           : BILLING_TEST_Constructor_WithResponse
        /// Description         : This method cannot be properly tested
        /// Performed           : 
        /// Type                : 
        /// Expected outcome    : 
        ///
        /// </summary>
        [TestMethod]
        public void BILLING_TEST_BillingUI()
        {
        }

        /// <summary>
        /// 
        /// Test Name           : BILLING_TEST_AddBillingCode
        /// Description         : This method tests the logic of the AddBillingCode Logic, including adding a record into the billing file and 
        ///                       the flag for recall option
        /// Performed           : Automatic : Class is instantiated within the static method on function call
        /// Type                : functional
        /// Expected outcome    : expected billing record to be added into the billing file
        ///
        /// </summary>
        [TestMethod]
        public void BILLING_TEST_AddBillingCode()
        {
        }

        /// <summary>
        /// 
        /// Test Name           : BILLING_TEST_InvalidBillingCode
        /// Description         : This method tests what should happen with an invalid billing code
        /// Performed           : Automatic : Class is instantiated within the static method on function call
        /// Type                : exception
        /// Expected outcome    : Error returned
        ///
        /// </summary>
        [TestMethod]
        public void BILLING_TEST_InvalidBillingCode()
        {
        }

        /// <summary>
        /// 
        /// Test Name           : BILLING_TEST_ThrowRecallException
        /// Description         : This method tests the flag for recall option, thrown as an exception from the AddBillingCode()
        /// Performed           : Manual : Class is instantiated within the static method on function call, a flag of 1 week is selected
        /// Type                : exception
        /// Expected outcome    : Error returned
        ///
        /// </summary>
        [TestMethod]
        public void BILLING_TEST_ThrowRecallException()
        {
        }

        /// <summary>
        /// 
        /// Test Name           : BILLING_TEST_ParseBillingCode
        /// Description         : This method tests the classes ability to pull the money from the master billing files codes
        /// Performed           : Automatic : Call the static method add billing code with the A655
        /// Type                : functional
        /// Expected outcome    : The money for the A655 code
        ///
        /// </summary>
        [TestMethod]
        public void BILLING_TEST_ParseBillingCode()
        {
        }

        /// <summary>
        /// 
        /// Test Name           : BILLING_TEST_AddRecordToBillingFile
        /// Description         : This method tests the classes intergration with the Support Module
        /// Performed           : Automatic : Call the static method add billing code with the A655, method at the end calls the support module
        /// Type                : functional
        /// Expected outcome    : The record is placed into the correct months billing file
        ///
        /// </summary>
        [TestMethod]
        public void BILLING_TEST_AddRecordToBillingFile()
        {
        }

        /// <summary>
        /// 
        /// Test Name           : BILLING_TEST_ParseBillingResponse
        /// Description         : This method tests the classes ability to parse the response file
        /// Performed           : Automatic : Call the static method Reconcile() with the path of the response file, method calls the support module,
        ///                       Support module sends back the response file for the month, along with the billing file as an array, compares the two
        /// Type                : functional
        /// Expected outcome    : The correct response is pulled from the response file 
        ///
        /// </summary>
        [TestMethod]
        public void BILLING_TEST_ParseBillingResponse()
        {
        }

        /// <summary>
        /// 
        /// Test Name           : BILLING_TEST_FalseResponseCode
        /// Description         : This method tests the classes ability to parse the response file containing a false responsecode
        /// Performed           : Automatic : Call the static method Reconcile() with the path of the response file, throws exception
        /// Type                : exception
        /// Expected outcome    : throws exception
        ///
        /// </summary>
        [TestMethod]
        public void BILLING_TEST_FalseResponseCode()
        {
        }

        /// <summary>
        /// 
        /// Test Name           : BILLINGSUMMARY_TEST_CalculateMonthlySummary
        /// Description         : This method tests the integration with the support module, creates a billing summary for the month if there
        ///                       isnt one out of the response file.
        /// Performed           : Automatic : Two tests, instantiate through static method, one with a file present and one without
        /// Type                : functional
        /// Expected outcome    : displays the billing summary as expected using thr tostring method
        ///
        /// </summary>
        [TestMethod]
        public void BILLINGSUMMARY_TEST_CalculateMonthlySummary()
        {
        }

        /// <summary>
        /// 
        /// Test Name           : BILLINGSUMMARY_TEST_TrackTotalBillableVisits
        /// Description         : This method counts the total number of entries there are in the billing response file
        /// Performed           : Automatic : instantiate the class through static method
        /// Type                : functional
        /// Expected outcome    : displays the billing summary as expected using thr tostring method
        ///
        /// </summary>
        [TestMethod]
        public void BILLINGSUMMARY_TEST_TrackTotalBillableVisits()
        {
        }

        /// <summary>
        /// 
        /// Test Name           : BILLINGSUMMARY_TEST_CalculatePercentage
        /// Description         : Performs the calculations required to calculate the percentage of 
        /// Performed           : Automatic : 
        /// Type                : Functional
        /// Expected outcome    : the proper results from the calculate percentage
        /// 
        /// </summary>
        [TestMethod]
        public void BILLINGSUMMARY_TEST_CalculatePercentage()
        {
        }

        /// <summary>
        /// 
        /// Test Name           : BILLINGSUMMARY_TEST_FlagForViewing
        /// Description         : Tests the FlagForViewing Methods ability to throw an exception containing the amound of records that are to be reviewed
        /// Performed           : Automatic : Call the method and catch the exception using a test file that contains a record that has to be reviewed.
        /// Type                : exception
        /// Expected outcome    : exception thrown containing total number of review inserts.
        ///
        /// </summary>
        [TestMethod]
        public void BILLINGSUMMARY_TEST_FlagForViewing()
        {
        }
    }
}
