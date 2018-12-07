using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulingUI
{
    /// 
    /// \class Menu
    ///
    /// \brief The purpose of this class is to display different user interface menus
    /// for the user.
    ///
    /// This file contains the class methods used in Menu.cs.
    ///
    /// \author A <i>Sean O'Brien</i>
    ///
    public class Menu
    {
        ///
        /// \Called to display the main menu of the user interface
        /// \details <b>Main Menu</b>
        ///
        ///  This method will display the options for the user to start navigating the menu
        ///  of the EMS system. The select method is called to receive the option the user selected.
        /// 
        /// \return   Returns int: return value from the select method
        ///
        public int mainMenu()
        {
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
        public int scheduleMenu()
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
        public int billingMenu()
        { 
            Console.WriteLine("Welcome to the hospital - Billing Menu");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("1: Generate monthly billing");
            Console.WriteLine("2: Reconsile monthly billing");
            Console.WriteLine("3: View monthly report");
            Console.WriteLine("4: Exit");

            return select();
        }


        ///
        /// \Called to get user input
        /// \details <b>Select</b>
        /// 
        ///  This method will prompt the user to enter a selection.
        /// 
        /// \return  Returns int: ascii value of what the user selected
        ///
        public int select()
        {
            Console.Write("Please select an option: ");         
            int buffer = Console.Read();
            
            return buffer;
        }


    }

   
}
