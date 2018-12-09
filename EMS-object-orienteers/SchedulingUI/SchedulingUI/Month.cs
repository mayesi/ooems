using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulingUI
{
    class Month 
    {
        public const int cMonthvert = 2;
        public const int cMonthHorz = 8;
        public const int cMonthLeftMax = 8;
        public const int cMonthRightMax = 40;
        public const int cMonthTopMax = 4;
        public const int cMonthBotMax = 12;
        public const int cMonthBuffer = 29;
        public static string[] cMonths = { "October", "November", "December" };

        private static string curMonth;
        public static string CurMonth
        {
            get
            {
                return curMonth;
            }
            set
            {
                curMonth = value;
            }
        }
        private static int monthSelect;
        public static int MonthSelect
        {
            get
            {
                return monthSelect;
            }
            set
            {
               monthSelect = value;
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
        public static void showMonth()
        {
            Console.Clear();

            int date = 1;
            CurMonth = cMonths[MonthSelect];
            int startDate = getStartDate();
            int monthLength = getMonthLength();

            int pos;
            Console.WriteLine("\tESM Schedule " + CurMonth + " 2018\n");//will be made dynamic later
            Console.WriteLine("Sun\tMon\tTues\tWed\tThus\tFri\tSun\n");
            //CurMonth = "october";
            for (
                
                
                pos = 1; pos <= startDate; ++pos)
            {
                Console.Write("\t");

            }

            while (date <= monthLength)
            {

                if (pos % 7 == 0)
                {
                    Console.Write(date + "\n\n");
                }
                else
                {
                    Console.Write(date + "\t");
                }
                ++pos;
                ++date;
            }
            Day.showDay(selectDate(startDate));
        }

        ///
        /// \Called to move the cursor of the 
        /// \details <b>selectDate</b>
        ///
        ///  This method will multiple the LHS with the RHS. The new object's name and colour are from the RSH object
        /// 
        /// \return  Returns void
        ///
        public static int selectDate(int start)
        {
            int yPos = cMonthTopMax;
            int yMonthEnd = (cMonthHorz) * (start + getMonthLength() - cMonthBuffer); //needs to be made dynamic based on the month
            int xPos = cMonthHorz * (start);
            Console.SetCursorPosition(xPos, yPos);
            ConsoleKeyInfo input;
            do
            {
                getDate(xPos, yPos, start, "red");
                input = Console.ReadKey(true);
                getDate(xPos, yPos, start, "green");

                //add a method for checking each of the directions with a bool return
                if (input.Key == ConsoleKey.RightArrow && xPos <= cMonthRightMax)
                {
                    if (!(yPos == cMonthBotMax && xPos == yMonthEnd))
                    {
                        xPos += cMonthHorz;
                    }
                }
                else if (input.Key == ConsoleKey.LeftArrow && xPos >= cMonthLeftMax)
                {
                    if (!(yPos == cMonthTopMax && xPos == cMonthHorz * start))
                    {
                        xPos -= cMonthHorz;
                    }
                }
                else if (input.Key == ConsoleKey.UpArrow && yPos > cMonthTopMax)
                {
                    if (!(yPos == cMonthTopMax + cMonthvert && xPos <= 8 * start - 4))
                    {
                        yPos -= cMonthvert;
                    }
                }
                else if (input.Key == ConsoleKey.DownArrow && yPos < cMonthBotMax)
                {
                    if (!(yPos == cMonthBotMax - cMonthvert && xPos > yMonthEnd))
                    {
                        yPos += cMonthvert;
                    }
                }
                else if (input.Key == ConsoleKey.D)
                {
                    Day.showDay(getDate(xPos, yPos, start, null));
                }
                else if (input.Key == ConsoleKey.W)
                {
                    Week.showWeek();
                }
                else if (input.Key == ConsoleKey.E && MonthSelect < 2)
                {
                    MonthSelect++;
                    showMonth();
                }
                else if (input.Key == ConsoleKey.Q && MonthSelect > 0)
                {
                    MonthSelect--;
                    showMonth();
                }
                Console.SetCursorPosition(xPos, yPos);
            }
            while (input.Key != ConsoleKey.Enter);

            return getDate(xPos, yPos, start, null);
        }

        public static int getStartDate()
        {
            int startDate = 0;
            if (CurMonth == "October")
            {
                startDate = 1;
            }
            else if (CurMonth == "November")
            {
                startDate = 4;
            }
            else if (CurMonth == "December")
            {
                startDate = 6;
            }
            return startDate;
        }


        public static int getMonthLength()
        {
            int monthLength = 0;
            if (CurMonth == "October")
            {
                monthLength = 31;
            }
            else if (CurMonth == "November")
            {
                monthLength = 30;
            }
            else if (CurMonth == "December")
            {
                monthLength = 31;
            }
            return monthLength;
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
        public static int getDate(int xPos, int yPos, int offSet, string colour)
        {
            int yDate = yPos;
            int xDate = xPos;
            yDate -= 4;
            yDate /= cMonthvert;
            xDate /= cMonthHorz;

            --offSet;
            int date = xDate + yDate * 7 - offSet;
            Console.SetCursorPosition(xPos, yPos);
            if (colour == "red")
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else if (colour == "green")
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            Console.WriteLine(date);

            return date;
        }

    }
}
