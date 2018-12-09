using System;
using System.Collections.Generic;
using Support;
using billing;
/// 
/// \class Schedule
///
/// \brief The purpose of this class is to model a schedule that can store appointmants.
///
/// This flies contains the class methods used in Schedule.cs.
///
/// \author A <i>Sean O'Brien</i>
///
namespace SchedulingUI
{
    class Schedule 
    {
        public const int cMonthvert = 2;
        public const int cMonthHorz = 8;
        public const int cMonthLeftMax = 8;
        public const int cMonthRightMax = 40;
        public const int cMonthTopMax = 4;
        public const int cMonthBotMax = 10;
        public static int HCH = 1;
        Dictionary<int, object> scheduleInfo = new Dictionary<int, object>();
        Database db = new Database("October Database");


        enum scale {days = 1, week, month};
        enum monthLenghts { october = 31, november = 30, december = 31}

        private int day;
        public int iDay
        {
            //modualized so that other 
            get { return day; }
            set
            {
                day = value;    
            }
        }

        

        public Schedule()
        {
            Console.CursorVisible = false;
            if (Database.StartDatabaseSystem() == false)
            { 
                Database.CreateNewDatabase("October Database", 10000, "Health Card Number");
                Database.CreateNewDatabase("November Database", 10000, "Health Card Number");
                Database.CreateNewDatabase("December Database", 10000, "Health Card Number");
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
        public static void ScheduleMenu()
        {

            Console.WriteLine("Welcome to the schedule");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("D: View by day");
            Console.WriteLine("W: View by week");
            Console.WriteLine("M: view by month");
            Console.WriteLine("H: Search by Health Card Number");
            Console.WriteLine("L: Search by last name");

            ConsoleKeyInfo input;

            do
            {
                input = Console.ReadKey(true);

                if (input.Key == ConsoleKey.D)
                {
                    Day.showDay(1, 2018);
                }
                else if (input.Key == ConsoleKey.W)
                {
                    Week.showWeek();
                }
                else if (input.Key == ConsoleKey.M)
                {
                    Month.showMonth();
                }
                else if (input.Key == ConsoleKey.H)
                {
                    SearchSchedule("HCN");
                }
                else if (input.Key == ConsoleKey.L)
                {
                    SearchSchedule("Name");
                }
            } while (input.Key != ConsoleKey.Enter);
    
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
        public static void SearchSchedule(string searchType)
        {
            if (searchType == "HCN")
            {
                Console.Write("Enter the Health Card Number to search for: ");
            }
            else if (searchType == "name")
            {
                Console.Write("Enter the last name to search for: ");
            }
            Console.ReadLine();
            

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
            Database db = new Database(Month.CurMonth + " Database");
            db.GetRecord("140");


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
        public static void bookAppointment(int day, int appointment)
        {
            Database db = new Database(Month.CurMonth + " Database");
            try
            {
                db.AddRecord(day.ToString() + appointment.ToString() + "|" + HCH + "|" + Month.CurMonth + "|Sean|Obrien");
            }
            catch(Exception)
            {
                Console.Clear();
                Console.WriteLine("Time slot already selected");
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                Month.showMonth();
            }
            HCH++;
        }




        /// <summary>
        /// 
        /// </summary>
        /// <param name="day"></param>
        /// <param name="year"></param>
        /// <param name="HCN"></param>
        public static void addBillingCode(int day, int year, string HCN)
        {
            //This is the following for the ad billing code and 
            string recall = "";
            bool success = true;
            string month = Month.CurMonth;
            string todaysDay = day.ToString();
            string thisYear = year.ToString();

            //Get the month number
            switch (month)
            {
                case "January":
                    {
                        month = "1";
                        break;
                    }
                case "Febuary":
                    {
                        month = "2";
                        break;
                    }
                case "March":
                    {
                        month = "3";
                        break;
                    }
                case "April":
                    {
                        month = "4";
                        break;
                    }
                case "May":
                    {
                        month = "5";
                        break;
                    }
                case "June":
                    {
                        month = "6";
                        break;
                    }
                case "July":
                    {
                        month = "7";
                        break;
                    }
                case "August":
                    {
                        month = "8";
                        break;
                    }
                case "September":
                    {
                        month = "9";
                        break;
                    }
                case "October":
                    {
                        month = "10";
                        break;
                    }
                case "November":
                    {
                        month = "11";
                        break;
                    }
                case "December":
                    {
                        month = "12";
                        break;
                    }
            }

            // build the date
            string date = month + "/" + day + "/" + year;


            // Now get the code from the user.
            string code = "";
            Console.WriteLine("Enter the Billing Code: ");
            code += Console.ReadKey().ToString();
            code += Console.ReadKey().ToString();
            code += Console.ReadKey().ToString();
            code += Console.ReadKey().ToString();
            Console.WriteLine("\n");

            try
            {
                //This date format and my respective function will probably have to be changed.
                //Else the call requires the billing code, the HCN and potentially the gender, can parse that out 
                //seperately within the function
                if (Billing.AddBillingCode(date, code, HCN) == false)
                {
                    Console.WriteLine("Invalid Billing Code.\n");
                    success = false;
                }
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
                    //Console.WriteLine("Success\n");
                    // billing code success, recall thrown
                    if (recall != "")
                    {
                        Console.WriteLine("Recall in " + recall + "\nPress Any Key to return to Month Screen\n");
                        Console.ReadKey();
                    }
                }
                Month.showMonth();
            }
        }
    }
}
