using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class UnitTestSchedule
    {
        /// <summary>
        /// Ensure that a patient can be found and where that patient's appointment is located
        /// </summary>
        /// <remarks>
        /// Performed           : Automated: Call the method using a known Health Card Number.
        /// Type                : Functional
        /// Expected outcome    : Return the time slot of patient
        /// </remarks>
        [TestMethod]
        public void SCHEDULE_TEST_PatientSearch()
        {
        }

        /// <summary>
        /// Check to see if the appointment was added to the database
        /// </summary>
        /// <remarks>
        /// Performed           : Automated: Call the method using a time slot
        /// Type                : Functional
        /// Expected outcome    : Return HCN of the time slot
        /// </remarks>
        [TestMethod]
        public void SCHEDULE_TEST_BookAppointment()
        {
        }

        /// <summary>
        /// This method is not testable since it is just contains console writelines and a method to get 
        /// user input that will be tested
        /// </summary>
        /// <remarks>
        /// </remarks>
        [TestMethod]
        public void SCHEDULE_TEST_Format()
        {
        }

        /// <summary>
        /// Description         : Verify that the input is within a valid range
        /// </summary>
        /// <remarks>
        /// Performed           : Manual: Enter a number outside of the range
        /// Type                : Boundary
        /// Expected outcome    : Return number select if valid
        /// </remarks>
        [TestMethod]
        public void MENU_TEST_UserInput()
        {
        }

        /// <summary>
        /// Not testable?
        /// </summary>
        /// <remarks>
        /// </remarks>
        [TestMethod]
        public void MONTH_TEST_ShowMonth()
        {
        }

        /// <summary>
        /// Verify that GetDate method returns the number the monthly schedule is highlighting 
        /// </summary>
        /// <remarks>
        /// Performed           : Automated: Call the method passing X and Y cordinates to see if it matches a predetermined value
        /// Type                : Functional
        /// Expected outcome    : Return the an int of the date selected
        /// </remarks>
        [TestMethod]
        public void MONTH_TEST_GetDate()
        {
        }

        /// <summary>
        /// Verify that GetDate method returns the number the monthly schedule is highlighting 
        /// </summary>
        /// <remarks>
        /// Performed           : Automated: Call the method passing X and Y cordinates to see if it matches a predetermined value
        /// Type                : Functional
        /// Expected outcome    : Return the an int of the date selected
        /// </remarks>
        [TestMethod]
        public void MONTH_TEST_MoveLeft()
        {
        }

        /// <summary>
        /// Verify that when the  right key press the cursor moves right to the next position if possible
        /// </summary>
        /// <remarks>
        /// Description         : Verify that when the  right key press the cursor moves right to the next position if possible
        /// Performed           : Manual: press left key when cursor position is at the left most position already
        /// Type                : Functional
        /// Expected outcome    : True
        /// </remarks>
        [TestMethod]
        public void MONTH_TEST_MoveRight()
        {
        }

        /// <summary>
        /// Verify that when the up key press the cursor moves up to the next position if possible
        /// </summary>
        /// <remarks>
        /// Performed           : Manual: press up key when cursor position is at the upper most position already
        /// Type                : Functional
        /// Expected outcome    : True
        /// </remarks>
        [TestMethod]
        public void MONTH_TEST_MoveUp()
        {
        }

        /// <summary>
        /// Verify that when the up key press the cursor moves up to the next position if possible
        /// </summary>
        /// <remarks>
        /// Performed           : Manual: press up key when cursor position is at the upper most position already
        /// Type                : Functional
        /// Expected outcome    : True
        /// </remarks>
        [TestMethod]
        public void MONTH_TEST_MoveDown()
        {
        }

        /// <summary>
        /// Not testable?
        /// </summary>
        /// <remarks>
        /// </remarks>
        [TestMethod]
        public void MONTH_TEST_ShowWeek()
        {
        }

        /// <summary>
        /// </summary>
        /// <remarks>
        /// </remarks>
        [TestMethod]
        public void WEEK_TEST_MoveLeft()
        {
        }

        /// <summary>
        /// Not testable?
        /// </summary>
        /// <remarks>
        /// </remarks>
        [TestMethod]
        public void DAY_TEST_ShowDay()
        {
        }

        /// <summary>
        /// Verify that SelectAppointment method returns the selcted time slot
        /// </summary>
        /// <remarks>
        /// Performed           : Manual: press up or down when cursor position is at the upper or lower most position already
        /// Type                : Functional
        /// Expected outcome    :
        /// </remarks>
        [TestMethod]
        public void DAY_TEST_SelectAppointment()
        {
        }
    }
}
