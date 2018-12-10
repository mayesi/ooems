using System;
using Support;
using billing;
namespace SchedulingUI
{
    class Day
    {
        enum timeSlot { eightAM, nineAM, tenAM, elevenAM, noon, onePM }

        public const int cDayVert = 6;
        public const int cDayTopMax = 4;
        public const int cDayBotMax = 30;

        public const int cHCN = 1;
        public const int cFirstName = 3;
        public const int cLastName = 4;
  

        /// <summary>
        /// Display day to user.
        /// </summary>
        /// <remarks>
        ///  This method displays all appointment slots for each day. The user can use the
        ///  arrow keys to changed the highlighted day and press enter to select.
        ///  The user can switch between months.
        /// </remarks>
        /// <param name="selectedDay">day selected from month</param>
        /// <param name="year">year to display</param>
        /// <returns>void</returns>
        static public void showDay(int selectedDay, int year)
        {
            Console.Clear();
            Console.WindowHeight = 40;
            Console.WindowWidth = 60;

            Database db = new Database(Month.CurMonth + " Database");
            db.GetDatabase();
            Console.WriteLine("ESM Schedule " + Month.CurMonth + " " + selectedDay);
            Console.WriteLine("_____________________");
            
            foreach (timeSlot val in Enum.GetValues(typeof(timeSlot)))
            {
                string dbKey = selectedDay.ToString() + (int)val;
                try
                {
                    string[] parse = db.database[dbKey].Split('|');
                    Console.WriteLine("|                   |");
                    Console.WriteLine("|\t" + parse[cHCN] + "\t    |              Add Billing Code");
                    Console.WriteLine("|                   |  " + val);
                    Console.WriteLine("|\t" + parse[cFirstName]+ " " + parse[cLastName] +" |");
                    Console.WriteLine("|                   |");
                    Console.WriteLine("|___________________|");
                }
                catch(Exception)
                {
                    Console.WriteLine("|                   |");
                    Console.WriteLine("|                   |              Book appointment");
                    Console.WriteLine("|                   |  " + val);
                    Console.WriteLine("|                   |");
                    Console.WriteLine("|                   |");
                    Console.WriteLine("|___________________|");
                }
            }
            selectAppointment(selectedDay, year);

            Menu.mainMenu();
        }


        /// <summary>
        /// select the slot for an appointment.
        /// </summary>
        /// <remarks>
        ///  This method will allow the user to select which time slot the 
        ///  patient wishes to book their appointment. The option is to book
        ///  an appointment or enter a billing code depending on whether there
        ///  is an appointment booked in the slot or not.
        /// </remarks>
        /// <param name="day">day selected from month</param>
        /// <param name="year">current year</param>
        /// <returns>int selection: which slot is picked</returns>
        static public int selectAppointment(int day, int year)
        {
            int yPos = 4;
            int xPos = 23;
            int selection = 0;
            Console.SetCursorPosition(xPos, yPos);
            ConsoleKeyInfo input;

            do
            {
                highlightSelection(xPos, yPos, selection, "red");
                input = Console.ReadKey(true);
                highlightSelection(xPos, yPos, selection, "green");
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

            //build a parsing for the database
            string parsingDatabase = day.ToString() + selection.ToString();
            //instantiate the db
            Database db = new Database(Month.CurMonth+" Database");
            //Assign Parsingdb to the result of that record
            string record = db.GetRecord(parsingDatabase);
            //split this all
            if (record != "")
            {
                string[] values = record.Split('|');
                Console.Clear();
                Schedule.addBillingCode(day, year, values[cHCN]);
            }
            else
            {
                Schedule.bookAppointment(day, selection);
            }

            return selection;
        }


        /// <summary>
        /// Highlight selected item.
        /// </summary>
        /// <remarks>
        ///  The colour of a word where the cursor is placed will
        ///  change colour as a way to clearly show to the user 
        ///  clearly which option they will select.
        /// </remarks>
        /// <param name="xPos">X position of cursor</param>
        /// <param name="yPos">Y position of cursor</param>
        /// <param name="selection">what is being changed colours</param>
        /// <param name="colour">colour to change to</param>
        /// <returns>void</returns>
        static public void highlightSelection(int xPos, int yPos, int selection, string colour)
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
        }
    }  
}
