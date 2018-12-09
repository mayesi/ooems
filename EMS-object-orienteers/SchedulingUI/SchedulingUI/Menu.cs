using System;

/// 
/// \class Menu
///
/// \brief The purpose of this class is to display different user interface menus
/// for the user.
///
/// This flies contains the class methods used in Menu.cs.
///
/// \author A <i>Sean O'Brien</i>
///
namespace SchedulingUI
{
    class Menu
    {
        public const int cVert = 6;
        public const int cHorz = 16;
        public const int cTopMax = 4;
        public const int cBotMax = 20;
        public const int cLeftMax = 3;
        public const int cRightMax = 40;

        public static string[] cAllMonths = { "January", "Febuary", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };



        ///
        /// \Called to display the main menu of the user interface
        /// \details <b>Main Menu</b>
        ///
        ///  This method will display the options for the user to start navigating the menu
        ///  of the EMS system. The select method is called to receive the option the user selected.
        /// 
        /// \return   Returns int: return value from the select method
        ///
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



        ///
        /// \Called to display the Schedule menu of the user interface
        /// \details <b>Schedule Menu</b>
        ///
        ///  This method will display the options for the user 
        ///  of the EMS system. The select method is called to receive the option the user selected.
        /// 
        /// \return   Returns int: return value from the select method
        ///
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


        ///
        /// \Called to display the billing menu of the user interface
        /// \details <b>Billing Menu</b>
        ///
        ///  This method will display the options for the user to navigate the billing menu
        ///  of the ESM system. The select method is called to receive the option the user selected.
        /// 
        /// \return  Returns int: return value from the select method
        ///
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

        ///
        /// \Called to select the slot for an appointment 
        /// \details <b>selctAppointment</b>
        /// 
        ///  This method will allow the user to select which time slot the 
        ///  patient wishes to book their appointment
        /// 
        /// \return void 
        ///
        static public void selectMonth()
        {
            int yPos = 3;
            int xPos = 4;
            int selection = 0;
            Console.SetCursorPosition(xPos, yPos);
            
            ConsoleKeyInfo input;


            do
            {
                getTimeSlot(xPos, yPos, selection, "red");
                input = Console.ReadKey(true);
                getTimeSlot(xPos, yPos, selection, "green");
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
                else if (input.Key == ConsoleKey.RightArrow && xPos > cRightMax)
                {
                    xPos = xPos + cHorz;
                    ++selection;
                }
                else if (input.Key == ConsoleKey.LeftArrow && xPos <= cLeftMax)
                {
                    xPos = xPos - cHorz;
                    --selection;
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
            //Billing.ViewReport(selection, 2018);
            // .ViewReport(selection, 2018);
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
            Console.WriteLine(cAllMonths[selection]);

            return 0;
        }

        ///
        /// \Called to get user input
        /// \details <b>Select</b>
        /// 
        ///  This method will prompt the user to enter a selection.
        /// 
        /// \return  Returns int: ascii value of what the user selected
        ///
        static public string select()
        {
            
            Console.Write("Plase select an option: ");
            
            string buffer = Console.ReadLine();
            Console.Clear();
            return buffer;
        }


    }

   
}
