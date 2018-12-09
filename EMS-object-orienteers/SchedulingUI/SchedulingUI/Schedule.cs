using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    public class Schedule 
    {
        public const string days = "1";
        public const string week = "2";
        public const string month = "3";

        public const int cMonthvert = 2;
        public const int cMonthHorz = 8;
        public const int cMonthLeftMax = 8;
        public const int cMonthRightMax = 40;
        public const int cMonthTopMax = 4;
        public const int cMonthBotMax = 10;


        Dictionary<int, object> scheduleInfo = new Dictionary<int, object>();

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
        public void format()
        {

            Console.WriteLine("Welcome to the schedule");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("D: View by day");
            Console.WriteLine("W: View by week");
            Console.WriteLine("M: view by month");


     
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
            } while (input.Key != ConsoleKey.Enter);
            //    case days:
            //        Day.showDay(1);
            //        break;
            //    case week:
            //        Week.showWeek();
            //        break;
            //    case month:
            //        Month.showMonth();
            //        break;              
            //    default:
            //        Console.Write("Please select day, week, month");
            //        break;
            //}
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
            
         

        }

        




        
    }
}
