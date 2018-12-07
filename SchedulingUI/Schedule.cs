using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Support;

namespace SchedulingUI
{
    /// 
    /// \class Schedule
    ///
    /// \brief The purpose of this class is to model a schedule that can store appointments.
    ///
    /// This file contains the class methods used in Schedule.cs.
    ///
    /// \author A <i>Sean O'Brien</i>
    ///
    public class Schedule : Menu
    {
        public const int days = 49;
        public const int week = 50;
        public const int month = 51;
        private string day;
        public string strDay
        {  
            get { return day; }
            set
            {
                day = value;    
            }
        }

        ///
        /// \Called to switch views of the schedule
        /// \details <b>period</b>
        ///
        ///  This method will get input from the user to select whether they wish
        ///  to view the schedule by day, week or month
        /// 
        /// \return  Returns void
        ///
        public void period()
        {
            Console.WriteLine("Welcome to the schedule");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("D: View by day");
            Console.WriteLine("W: View by week");
            Console.WriteLine("M: view by month");
            Console.WriteLine("Please select an option: ");
            Menu mu = new Menu();

            int userInput = mu.select();
            Console.Clear();
            switch (userInput)
            {
                case days:
                    showDay();
                    break;
                case week:
                    showWeek();
                    break;
                case month:
                    showMonth();
                    break;              
                default:
                    Console.Write("Please select day, week, month");
                    break;
            }
        }

        ///
        /// \Called to display monthly user interface
        /// \details <b>showMonth</b>
        ///
        ///  This method displays every day of the month. The user can use the
        ///  arrow keys to changed the highlighted day and press enter to select.
        ///  The user can switched between months.
        /// 
        /// \return  Returns void
        ///
        ///
        public void showMonth()
        {

            int startDay = 4;
            int date = 1;
            int pos;
            Console.WriteLine("\n");
            Console.WriteLine("\t\tSun\tMon\tTues\tWed\tThus\tFri\tSun\n");
            Console.Write("\t\t");
            for (pos = 1; pos < startDay; ++pos)
            {
                Console.Write("\t");

            }

            while (date <= 31)
            {

                if (pos % 7 == 0)
                {
                    Console.Write(date + "\n\n\t\t");
                }
                else
                {
                    Console.Write(date + "\t");
                }
                ++pos;
                ++date;
            }
            selectDate(startDay);
        }


        ///
        /// \Called to display weekly user interface
        /// \details <b>showWeek</b>
        ///
        ///  This method displays 3 weeks of the schedule. The user can use the
        ///  arrow keys to change the highlighted day and press enter to select.
        ///  The user can switch between different weeks.
        /// 
        /// \return  Returns void
        ///
        ///
        public void showWeek()
        {



        }


        ///
        /// \Called to display dayly user interface
        /// \details <b>showDay</b>
        ///
        ///  This method displays all appointment slots for each day. The user can use the
        ///  arrow keys to changed the highlighted day and press enter to select.
        ///  The user can switch between months.
        /// 
        /// \return  Returns void
        ///
        ///
        public void showDay()
        {

            int yPos = 4;
            int xPos = 8;
            Console.SetCursorPosition(xPos, yPos);
            ConsoleKeyInfo input;
            do
            {

                input = Console.ReadKey(true);
                if (input.Key == ConsoleKey.RightArrow)
                {
                    xPos = xPos + 8;
                }
                else if (input.Key == ConsoleKey.LeftArrow)
                {
                    xPos = xPos - 8;
                }
                else if (input.Key == ConsoleKey.UpArrow)
                {
                    yPos = yPos - 2;
                }
                else if (input.Key == ConsoleKey.DownArrow)
                {
                    yPos = yPos + 2;
                }
                Console.SetCursorPosition(xPos, yPos);
            }
            while (input.Key != ConsoleKey.Enter);
           



        }


        ///
        /// \Called to search for a patient by HCN
        /// \details <b>patientSearch</b>
        /// \param  string: sHCN - Health Card Number
        /// 
        ///  This method will search for a patient based on their unique
        ///  health card number
        /// 
        /// \return void 
        ///
        public void patientSearch(string sHCN)
        {
            int yPos = 4;
            int xPos = 8 ;
            Console.SetCursorPosition(xPos, yPos);
            ConsoleKeyInfo input;
            do
            {

                input = Console.ReadKey(true);
                if (input.Key == ConsoleKey.RightArrow)
                {
                    xPos = xPos + 8;
                }
                else if (input.Key == ConsoleKey.LeftArrow)
                {
                    xPos = xPos - 8;
                }
                else if (input.Key == ConsoleKey.UpArrow)
                {
                    yPos = yPos - 2;
                }
                else if (input.Key == ConsoleKey.DownArrow)
                {
                    yPos = yPos + 2;
                }
                Console.SetCursorPosition(xPos, yPos);
            }
            while (input.Key != ConsoleKey.Enter);
            

        }


        ///
        /// \Called to book an appointment for the patient 
        /// \details <b>bookAppointment</b>
        /// 
        ///  This method will save the patient's appointment after the 
        ///  slot has been selected
        /// 
        /// \return void 
        ///
        public void bookAppointment()
        {
            int yPos = 4;
            int xPos = 8 ;
            Console.SetCursorPosition(xPos, yPos);
            ConsoleKeyInfo input;
            do
            {

                input = Console.ReadKey(true);
                if (input.Key == ConsoleKey.RightArrow)
                {
                    xPos = xPos + 8;
                }
                else if (input.Key == ConsoleKey.LeftArrow)
                {
                    xPos = xPos - 8;
                }
                else if (input.Key == ConsoleKey.UpArrow)
                {
                    yPos = yPos - 2;
                }
                else if (input.Key == ConsoleKey.DownArrow)
                {
                    yPos = yPos + 2;
                }
                Console.SetCursorPosition(xPos, yPos);
            }
            while (input.Key != ConsoleKey.Enter);
         

        }

        ///
        /// \Called to select the slot for an appointment 
        /// \details <b>selctAppointment</b>
        /// 
        ///  This method will allow the user to select which time slot the 
        ///  patient wishes to book their appointment
        /// 
        /// \return void 
        ///
        private void selectAppointment()
        {
            int yPos = 4;
            int xPos = 8 ;
            Console.SetCursorPosition(xPos, yPos);
            ConsoleKeyInfo input;
            do
            {

                input = Console.ReadKey(true);
                if (input.Key == ConsoleKey.RightArrow)
                {
                    xPos = xPos + 8;
                }
                else if (input.Key == ConsoleKey.LeftArrow)
                {
                    xPos = xPos - 8;
                }
                else if (input.Key == ConsoleKey.UpArrow)
                {
                    yPos = yPos - 2;
                }
                else if (input.Key == ConsoleKey.DownArrow)
                {
                    yPos = yPos + 2;
                }
                Console.SetCursorPosition(xPos, yPos);
            }
            while (input.Key != ConsoleKey.Enter);
    

        }


        ///
        /// \Called to move the cursor of the 
        /// \details <b>selectDate</b>
        ///
        ///  This method will multiple the LHS with the RHS. The new object's name and colour are from the RSH object
        /// 
        /// \return  Returns void
        ///
        public void selectDate(int start)
        {
            int yPos = 4;
            int xPos = 8 * start;
            Console.SetCursorPosition(xPos, yPos);
            ConsoleKeyInfo input;
            do
            {
                
                input = Console.ReadKey(true);
                if (input.Key == ConsoleKey.RightArrow)
                {
                    xPos = xPos + 8;
                }
                else if (input.Key == ConsoleKey.LeftArrow)
                {
                    xPos = xPos - 8;
                }
                else if (input.Key == ConsoleKey.UpArrow)
                {
                    yPos = yPos - 2;
                }
                else if (input.Key == ConsoleKey.DownArrow)
                {
                    yPos = yPos + 2;
                }
                Console.SetCursorPosition(xPos, yPos);
            }
            while (input.Key != ConsoleKey.Enter);
            getDate(xPos, yPos, start);
            
        }


        ///
        /// \Called to determine the date selected
        /// \details <b>getDate</b>
        /// \param int: xPos, yPos, offSet 
        /// 
        ///  This method will determine what date was selected on the monthly calender
        ///  based on the position of the cursor and the offset of the start date due 
        ///  to months starting on different days
        /// 
        /// \return int: return the number selected
        ///
        public int getDate(int xPos, int yPos, int offSet)
        {
            return 0;
        }


        /// <summary>
        /// This method returns true if the day is on the weekend, false otherwise.
        /// </summary>
        /// <remarks>
        /// This method throws exceptions from the DateTime class.
        /// </remarks>
        /// <param name="year">the year 1 through 9999</param>
        /// <param name="month">the month 1 through 12</param>
        /// <param name="day">the day of the month</param>
        /// <returns></returns>
        public static bool IsOnWeekEnd(int year, int month, int day)
        {
            DateTime dt = new DateTime(year, month, day);
            if (dt.DayOfWeek == DayOfWeek.Saturday || dt.DayOfWeek == DayOfWeek.Sunday)
            {
                return true;
            }

            return false;
        }

        
        /// <summary>
        /// This method returns the day of the week for the first day of the month.
        /// </summary>
        /// <remarks>
        /// This method will throw exceptions from the DateTime class.
        /// </remarks>
        /// <param name="year">the year 1 through 9999</param>
        /// <param name="month">the month 1 through 12</param>
        /// <returns>int - the day of the week 0-sunday to 6-saturday</returns>
        public int StartDayOfWeekForMonth(int year, int month)
        {
            DateTime dt = new DateTime(year, month, 1);
            int dayOfWeek = Convert.ToInt32(dt.DayOfWeek);
            return dayOfWeek;
        }



        /// <summary>
        /// This method saves the appointment to the database
        /// </summary>
        /// <remarks>
        /// It automatically finds the correct database based on a naming scheme scheduleyyyymmm. If the database
        /// does not exist it will create a new one. It will add the appointment to the database with the 
        /// Appointment slot number as its primary key value. Empty strings have a space as a placeholder.
        /// </remarks>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="app"></param>
        /// <returns>bool - true if saved the appointment, false otherwise</returns>
        public static bool SaveAppointment(int year, int month, Appointment app)
        {
            if(app.AppointmentSlot == 0)
            {
                string details = "The appointment slot field in the Appointment object is not initialized.";
                Logging.LogMsg("Schedule", "SaveAppointment", details);
                return false;
            }

            string dbName = "schedule" + year.ToString() + month.ToString();

            string cgName = " ";
            string cgHCN = " ";

            if (app.CaregiverName.Length != 0 && app.CaregiverHCN.Length != 0)
            {
                cgName = app.CaregiverName;
                cgHCN = app.CaregiverHCN;
            }

            string record = app.AppointmentSlot.ToString() + "|"
                + app.PrimaryPatientName + "|"
                + app.PrimaryPatientHCN + "|"
                + cgName + "|"
                + cgHCN;

            Database db;
            try
            {
                // Try to call the Database constructor, if it throws a FileNotFoundException create a new database
                db = new Database(dbName);
            }
            catch (FileNotFoundException fnfe)
            {
                try
                {
                    Database.CreateNewDatabase(dbName, 512, "Appointment Slot Number");
                    db = new Database(dbName);
                    db.AddRecord(record);
                }
                catch (Exception ex)
                {
                    Logging.LogMsg("Schedule", "SaveAppointment", ex.Message);
                    return false;
                }               
            }
            
            return true;
        }
    }
}
