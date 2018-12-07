using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulingUI
{
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    public class Appointment
    {

        private const int maxSlotsPerDay = 6;   // The maximum time slots for appointment for a day
        private int appointmentSlot;            /// The appointment slot for the month       
        public string PrimaryPatientName { get; set; }  /// the primary patient's full name
        public string PrimaryPatientHCN { get; set; }   /// the patient's health card number
        public string CaregiverName { get; set; }       /// the second person, empty string if there is only one person
        public string CaregiverHCN { get; set; }

        public static int MaxSlotsPerDay => maxSlotsPerDay;

        public int AppointmentSlot { get => appointmentSlot; }

        public Appointment(string ppName, string ppHCN) {
            if (ppName == "" || ppHCN == "")
            {
                throw new ArgumentException("The primary patient name or health card number cannot be empty");
            }
            PrimaryPatientName = ppName;
            PrimaryPatientHCN = ppHCN;
            CaregiverName = "";
            CaregiverHCN = "";
            appointmentSlot = 0;
        }

        public Appointment(string ppName, string ppHCN, string cName, string cHCN)
        {
            if (ppName == "" || ppHCN == "" || cName == "" || cHCN == "")
            {
                throw new ArgumentException("The names or health card numbers cannot be empty");
            }
            PrimaryPatientName = ppName;
            PrimaryPatientHCN = ppHCN;
            CaregiverName = cName;
            CaregiverHCN = cHCN;
            appointmentSlot = 0;
        }

        /// <summary>
        /// This method is used to set the appointment slot number
        /// </summary>
        /// <remarks>
        /// Th
        /// </remarks>
        /// <param name="dayOfMonth">int - between 1 and 31 (inclusive)</param>
        /// <param name="timeslot">int - between 1 and the maximum number of slots per day (6)</param>
        public void SetAppointmentSlot(int dayOfMonth, int timeslot)
        {
            if (dayOfMonth < 1 ||  dayOfMonth > 31 )
            {
                throw new ArgumentException("The month parameter is invalid");
            }
            if (timeslot < 1 || timeslot > Appointment.maxSlotsPerDay)
            {
                throw new ArgumentException("The timeslot parameter is invalid");
            }

            int slotNum = (dayOfMonth * 10) + timeslot;

            appointmentSlot = slotNum; 
        }


        /// <summary>
        /// This method returns the day of the month (1 to 31) for the appointment
        /// </summary>
        /// <remarks>
        /// The slot number must follow the format specified in the Appointment class. This method
        /// only checks if the slot number is negative, zero (ArgumentException) or is for a day 
        /// that is greater than 31 (Exception). 
        /// </remarks>
        /// <param name="slotNumber"></param>
        /// <returns>int - the day of the month for the appointment</returns>
        public static int GetDayFromAppointmentSlotNum(int slotNumber)
        {
            if (slotNumber <= 0)
            {
                throw new ArgumentException("The slot number is invalid (negative or zero).");
            }

            int day = slotNumber / 10;    // cuts of any numbers after the decimal place

            if (day > 31)
            {
                throw new Exception("The slot number is invalid");
            }

            return day;
        }


        /// <summary>
        /// This method returns the slot number in the day for the appointment
        /// </summary>
        /// <remarks>
        /// The slot number must follow the format specified in the Appointment class. This method
        /// only checks if the slot number is negative, zero (ArgumentException) or is for a time slot 
        /// that is greater than the maximum slots per day, 6 (Exception). 
        /// </remarks>
        /// <param name="slotNumber">the slot number in the Appointment class object</param>
        /// <returns>int - the timeslot in the day for the appointment</returns>
        public static int GetAppointmentTimeSlotForDay(int slotNumber)
        {
            if (slotNumber <= 0)
            {
                throw new ArgumentException("The slot number is invalid (negative or zero).");
            }

            int slotInDay = slotNumber % Appointment.MaxSlotsPerDay;

            if (slotInDay > Appointment.MaxSlotsPerDay)
            {
                throw new Exception("The slot number is invalid");
            }

            return slotInDay;
        }
    }
}
