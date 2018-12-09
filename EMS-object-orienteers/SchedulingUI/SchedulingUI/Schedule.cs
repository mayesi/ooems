using System;
using System.Collections.Generic;
using Support;
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
                    Day.showDay(1);
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
            catch(Exception ex)
            {
                Console.Clear();
                Console.WriteLine("Time slot already selected");
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                Month.showMonth();
            }
            HCH++;
        }

        




        
    }
}
