using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class UnitTestDemographics
    {
        /// <summary>
        /// Ensure that only valid information is in each patient class
        /// </summary>
        /// <remarks>
        /// Performed: Automated Pass a patient with properly filled fields to the method and check if it returns true
        /// Type: Functional
        /// Expected outcome: TRUE
        /// </remarks>
        [TestMethod]
        public void PATIENT_TEST_ValidatePatient()
        {
        }

        /// <summary>
        /// Ensure that invalid information will return false
        /// </summary>
        /// <remarks>
        /// Conducted           : Automated Pass a patient with improperly filled or unfilled fields and check if false is returned
        /// Type                : Functional
        /// Expected Results    : False
        /// </remarks>
        [TestMethod]
        public void PATIENT_TEST_InvalidValidatePatient()
        {
        }

        /// <summary>
        /// Ensure that a patient with a null value will throw an exception
        /// </summary>
        /// <remarks>
        /// Performed           : Automated Pass a patient with a null reference and check for an exception to be thrown
        /// Type                : Exception
        /// Expected outcome    : Exception
        /// </remarks>
        [TestMethod]
        public void PATIENT_TEST_ValidatePatientExceptionCheck()
        {
        }


        /// <summary>
        /// Ensure that CheckIfPresent will return false if the HCN is not in the database
        /// </summary>
        /// <remarks>
        /// Performed           : Automated Pass an HCN that isn't in the database and check if false is returned
        /// Type                : Funtional
        /// Expected outcome    : FALSE
        /// </remarks>
        [TestMethod]
        public void DEMOGRAPHICS_TEST_CheckIfPresent()
        {
        }


        /// <summary>
        /// Ensure that CheckIfPresent will return true if the HCN is already in the database
        /// </summary>
        /// <remarks>
        /// Performed           : Automated Pass an HCN that is known to be in the database and check if true is returned
        /// Type                : Functional
        /// Expected outcome    : TRUE
        /// </remarks>
        [TestMethod]
        public void DEMOGRAPHICS_TEST_TestCheckIfPresent()
        {
        }


        /// <summary>
        /// Check that UI options are properly created 
        /// </summary>
        /// <remarks>
        /// Functional
        /// </remarks>
        [TestMethod]
        public void DEMOGRAPHICS_TEST_PromptForInfo()
        {
        }

        /// <summary>
        /// Check that a search will return the patient's info if found in the database
        /// </summary>
        /// <remarks>
        /// Performed           : Automated Enter a search term for a patient known to be in the database and check if their information is properly returned
        /// Type                : Functional
        /// Expected outcome    : Returns patient information
        /// </remarks>
        [TestMethod]
        public void DEMOGRAPHICS_TEST_Search()
        {
        }

        /// <summary>
        /// Ensure that search will throw an exception if there is not a database to search from
        /// </summary>
        /// <remarks>
        /// Performed           : Automated Pass an HCN to search for and try to access the database. Check if an exception is thrown
        /// Type                : Exception
        /// Expected outcome    : Exception
        /// </remarks>
        [TestMethod]
        public void DEMOGRAPHICS_TEST_SearchExceptionCheck()
        {
        }
    }
}
