using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulingUI
{
    class Week
    {
        enum DofW { Sunday, Monday, Tuesday, Wednesday, Thusday, Friday, Saturday };

        public const int cDayVert = 5;
        public const int cDayTopMax = 2;
        public const int cDayBotMax = 31;
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
        public static void showWeek()
        {
            Console.Clear();
            Console.WriteLine("\t\tESM Schedule ");

            Console.WindowHeight = 40;
            Console.WindowWidth = 120;
            Console.WriteLine("__________________");
            int weeks = 2;
            Console.CursorSize = 100;
            for (int i = 0; i <= weeks; ++i)
            {
                foreach (DofW val in Enum.GetValues(typeof(DofW)))
                {


                    Console.SetCursorPosition(20 * i, (int)val * 6);
                    //if (i == 0)
                    //{
                        Console.Write("\n|\t\t|\n");
                        Console.Write("|\t" + weeks + "\t|\n");
                        Console.Write("|\t\t|  " + val + "\n");
                        Console.Write("|\t\t|\n");
                        Console.Write("|\t\t|\n");
                        Console.Write("|_______________|\n");
                    //}
                    //else
                    //{
                    //    Console.Write("hello?\n");
                    //    Console.Write("|\n");
                    //}

                }
            }
            selectAppointment();
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
        static public void selectAppointment()
        {
            int yPos = 4;
            int xPos = 23;
            int selection = 0;
            Console.SetCursorPosition(xPos, yPos);
            ConsoleKeyInfo input;

            do
            {
                getTimeSlot(xPos, yPos, selection, "red");
                input = Console.ReadKey(true);
                getTimeSlot(xPos, yPos, selection, "green");
                if (input.Key == ConsoleKey.UpArrow && yPos > cDayTopMax)
                {
                    yPos = yPos - cDayVert;
                    --selection;
                }
                else if (input.Key == ConsoleKey.DownArrow && yPos <= cDayBotMax)
                {
                    yPos = yPos + cDayVert;
                    ++selection;
                }
                else if (input.Key == ConsoleKey.D)
                {
                    Day.showDay(1);
                }
                else if (input.Key == ConsoleKey.M)
                {
                    Month.showMonth();
                }

                Console.SetCursorPosition(xPos, yPos);
            }
            while (input.Key != ConsoleKey.Enter);
            Console.ReadLine();

        }


        static public int getTimeSlot(int xPos, int yPos, int selection, string colour)
        {

            Console.SetCursorPosition(xPos, yPos);
            if (colour == "red")
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else if (colour == "green")
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            Console.WriteLine(Enum.GetName(typeof(DofW), selection));

            return 0;
        }
    }
}
