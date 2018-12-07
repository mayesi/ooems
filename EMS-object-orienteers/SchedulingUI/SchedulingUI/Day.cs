using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulingUI
{
    class Day
    {
        enum timeSlot { eightAM, nineAM, tenAM, elevenAM, noon, onePM }

        public const int cDayVert = 6;
        public const int cDayTopMax = 4;
        public const int cDayBotMax = 30;
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
        static public void showDay(int selectedDay)
        {
            Console.Clear();
            Console.WriteLine("\tESM Schedule " + selectedDay);

            Console.WindowHeight = 40;
            Console.WindowWidth = 60;
            Console.WriteLine("_____________________");

            foreach (timeSlot val in Enum.GetValues(typeof(timeSlot)))
            {
                Console.WriteLine("|                   |");
                Console.WriteLine("|                   |");
                Console.WriteLine("|                   |  " + val);
                Console.WriteLine("|                   |");
                Console.WriteLine("|                   |");
                Console.WriteLine("|___________________|");

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
                else if (input.Key == ConsoleKey.M)
                {
                    Month.showMonth();
                }
                else if (input.Key == ConsoleKey.W)
                {
                    Week.showWeek();
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
            Console.WriteLine(Enum.GetName(typeof(timeSlot), selection));

            return 0;
        }
    }

    
}
