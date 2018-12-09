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

        public const int cWeekVert = 6;
        public const int cWeekHorz = 16;
        public const int cWeekTopMax = 2;
        public const int cWeekBotMax = 31;
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

            Console.WindowHeight = 38;
            Console.WindowWidth = 70;
            Console.CursorSize = 100;
            Console.CursorVisible = true;
            
            int weeks = 2;
            Console.CursorSize = 100;
            for (int i = 0; i <= weeks; ++i)
            {
                foreach (DofW day in Enum.GetValues(typeof(DofW)))
                {
                    Console.SetCursorPosition(16 * i, (int)day * 6);
                    if (day == 0)
                    {
                        Console.Write("_____Week_"+ i +"_____");
                    }
                    else
                    {
                        Console.Write("|_______________|");
                    }
                    Console.SetCursorPosition(16 * i, (int)day * 6 + 1);
                    Console.Write("|\t \t|");
                    Console.SetCursorPosition(16 * i, (int)day * 6 + 2);
                    Console.Write("|\t\t|");
                    Console.SetCursorPosition(16 * i, (int)day * 6 + 3);
                    Console.Write("|\t  \t|  " + day);
                    Console.SetCursorPosition(16 * i, (int)day * 6 + 4);
                    Console.Write("|\t \t|");
                    Console.SetCursorPosition(16 * i, (int)day * 6 + 5);
                    Console.Write("|\t\t|");
                    Console.SetCursorPosition(16 * i, (int)day * 6 + 6);
                    Console.Write("|_______________|\n");

                }
            }
            selectAppointment();
        }



        public void createDisplay(string output, int xPos, int yPos)
        {
            Console.SetCursorPosition(xPos, yPos);
            Console.Write(output);
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
            int yPos = 1;
            int xPos = 1;
            int selection = 0;
            Console.SetCursorPosition(xPos, yPos);
            ConsoleKeyInfo input;
            

            do
            {
                //getTimeSlot(xPos, yPos, selection, "red");
                input = Console.ReadKey(true);
                //getTimeSlot(xPos, yPos, selection, "green");
                if (input.Key == ConsoleKey.UpArrow && yPos > cWeekTopMax)
                {
                    yPos = yPos - cWeekVert;
                    --selection;
                }
                else if (input.Key == ConsoleKey.DownArrow && yPos <= cWeekBotMax)
                {
                    yPos = yPos + cWeekVert;
                    ++selection;
                }
                else if (input.Key == ConsoleKey.RightArrow && yPos > cWeekTopMax)
                {
                    xPos = xPos + cWeekHorz;
                    --selection;
                }
                else if (input.Key == ConsoleKey.LeftArrow && yPos <= cWeekBotMax)
                {
                    xPos = xPos - cWeekHorz;
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
