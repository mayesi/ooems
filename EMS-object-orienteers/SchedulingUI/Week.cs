﻿// FILE 			: Week.cs
// PROJECT          : INFO2180 EMS Solution
// PROGRAMMER 		: Sean O'Brien, Object Orienteers
// FIRST VERSION 	: December 9th 2018
// DESCRIPTION 	    : Contains the logic for displaying a week. nothing else
using System;

namespace SchedulingUI
{
    /// <summary>
    /// This class represends the scheduling for a weeks worth of appointments.
    /// Bugs include Functionality breaking issues regarding the month being superimposed
    /// Not functional, but pretty.
    /// </summary>
    class Week
    {
        enum DofW { Sunday, Monday, Tuesday, Wednesday, Thusday, Friday, Saturday };

        public const int cWeekVert = 5;
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
                    Console.SetCursorPosition(cWeekHorz * i, (int)day * cWeekVert);
                    if (day == 0)
                    {
                        Console.Write("_____Week_"+ i +"_____");
                    }
                    else
                    {
                        Console.Write("|_______________|");
                    }
                    Console.SetCursorPosition(cWeekHorz * i, (int)day * cWeekVert + 1);
                    Console.Write("|\t \t|");
                    Console.SetCursorPosition(cWeekHorz * i, (int)day * cWeekVert + 2);
                    Console.Write("|\t\t|");
                    Console.SetCursorPosition(cWeekHorz * i, (int)day * cWeekVert + 3);
                    Console.Write("|\t  \t|  " + day);
                    Console.SetCursorPosition(cWeekHorz * i, (int)day * cWeekVert + 4);
                    Console.Write("|\t\t|");
                    Console.SetCursorPosition(cWeekHorz * i, (int)day * cWeekVert + 5);
                    Console.Write("|_______________|\n");

                }
            }
            selectAppointment();
        }




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
                    Day.showDay(1, 2018);
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
