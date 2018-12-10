// FILE 			: Menu.cs
// PROJECT          : INFO2180 EMS Solution
// PROGRAMMER 		: Sean O'Biren, Object Orienteers
// FIRST VERSION 	: December 9th 2018
// DESCRIPTION 	    : Contains the logic for displaying menus of the ems System;
using System;
using billing;

/// <summary>
/// This class contains menus that are used to display infomation to the user.
/// The purpose of this class is to display different user interface menus and
/// allow them to control the flow of the program.
/// </summary>
namespace SchedulingUI
{
    public class Menu
    {
        public const int cVert = 6;
        public const int cHorz = 16;
        public const int cTopMax = 4;
        public const int cBotMax = 20;
        public const int cLeftMax = 3;
        public const int cRightMax = 36;

        public static string[] cAllMonths = { "January", "Febuary", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };


        /// <summary>
        /// Display main menu.
        /// </summary>
        /// <remarks>
        ///  This method will display the options for the user to start navigating the menu
        ///  of the EMS system. The select method is called to receive the option the user selected.
        /// </remarks>
        /// <returns name="select">return value of the the select function</returns>
        public static string mainMenu()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the hospital - Main Menu");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("1: Create new patient visit");
            Console.WriteLine("2: Create new patient visit with caregiver");
            Console.WriteLine("3: Schedule menu");
            Console.WriteLine("4: Billing menu");
            Console.WriteLine("5: Exit");
      

            return select();
        }

        /// <summary>
        /// Display schedule menu.
        /// </summary>
        /// <remarks>
        ///  his method will display the options for the user of the EMS system. 
        ///  The select method is called to receive the option the user selected
        /// </remarks>
        /// <returns name="select">return value of the the select function</returns>
        public string scheduleMenu()
        {
            Console.WriteLine("Welcome to the hospital - Schedule Menu");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("1: Select scale of Schedule");
            Console.WriteLine("2: View schedule");
            Console.WriteLine("3: Search schedule");
            Console.WriteLine("5: Exit");


            return select();
        }



        /// <summary>
        /// Display billing report.
        /// </summary>
        /// <remarks>
        ///  The user can select a month in order to view the billing report
        ///  for the selected month.
        /// </remarks>
        /// <returns>void</returns>
        public static void BillingMenu()
        {
            int monthCount = 0;
            for (int j = 0; j <= 3; ++j)
            {
                for (int i = 0; i <= 2; ++i)
                {
                    Console.SetCursorPosition(16 * i, j * 6);
                    if (j == 0)
                    {
                        Console.Write("________________");
                    }
                    else
                    {
                        Console.Write("|_______________|");
                    }
                    Console.SetCursorPosition(cHorz * i, cVert * j + 1);
                    Console.Write("|\t \t|");
                    Console.SetCursorPosition(cHorz * i, cVert * j + 2);
                    Console.Write("|\t\t|");
                    Console.SetCursorPosition(cHorz * i, cVert * j + 3);
                    Console.Write("|   "+cAllMonths[monthCount] +" \t|  ");
                    Console.SetCursorPosition(cHorz * i, cVert * j + 4);
                    Console.Write("|\t \t|");
                    Console.SetCursorPosition(cHorz * i, cVert * j + 5);
                    Console.Write("|\t\t|");
                    Console.SetCursorPosition(cHorz * i, cVert * j + 6);
                    Console.Write("|_______________|\n");
                    monthCount++;
                }
            }
            selectMonth();
        }

        /// <summary>
        /// select the slot for an appointment.
        /// </summary>
        /// <remarks>
        ///  This method will allow the user to select which time slot the 
        ///  patient wishes to book their appointment. The option is select
        ///  which day of the month the user wishes to view in day view.
        /// </remarks>
        /// <param name="day">day selected from month</param>
        /// <param name="year">current year</param>
        /// <returns name="selection">which slot is picked</returns>
        static public void selectMonth()
        {
            int yPos = 3;
            int xPos = 4;
            int selection = 0;
            Console.SetCursorPosition(xPos, yPos);
            
            ConsoleKeyInfo input;


            do
            {
                highlightSelection(xPos, yPos, selection, "red");
                input = Console.ReadKey(true);
                highlightSelection(xPos, yPos, selection, "green");
                if (input.Key == ConsoleKey.UpArrow && yPos > cTopMax)
                {
                    yPos = yPos - cVert;
                    selection -= 3;
                }
                else if (input.Key == ConsoleKey.DownArrow && yPos <= cBotMax)
                {
                    yPos = yPos + cVert;
                    selection += 3;
                }
                else if (input.Key == ConsoleKey.RightArrow && xPos < cRightMax)
                {
                    xPos = xPos + cHorz;
                    ++selection;
                }
                else if (input.Key == ConsoleKey.LeftArrow && xPos >= cLeftMax)
                {
                    xPos = xPos - cHorz;
                    --selection;
                }
                else if (input.Key == ConsoleKey.D)
                {
                    Day.showDay(1, 2018);
                }
                else if (input.Key == ConsoleKey.M)
                {
                    Month.showMonth();
                }

                Console.SetCursorPosition(xPos, yPos);
            }
            while (input.Key != ConsoleKey.Enter);
            Console.Clear();
            Billing.ViewReport(selection, 2018);
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            mainMenu();
            

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
        static public int highlightSelection(int xPos, int yPos, int selection, string colour)
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
            Console.WriteLine(cAllMonths[selection]);

            return 0;
        }


        /// <summary>
        /// Get user input.
        /// </summary>
        /// <remarks>
        ///  The user is promted to enter a key to select an option
        ///  from a menu. 
        /// </remarks>
        /// <returns name="buffer">user entered value</returns>
        static public string select()
        {
            
            Console.Write("Plase select an option: ");
            
            string buffer = Console.ReadLine();
            Console.Clear();
            return buffer;
        }
    }
}
