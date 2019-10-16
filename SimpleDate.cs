using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalShelter
{
    [Serializable]
    /// <summary>
    /// A simple class to store dates.
    /// 
    /// This class is called SimpleDate because it's a simplyfied version of 
    /// the .Net DateTime object. SimpleDate hides the more complex interface of DateTime
    /// and makes it easy to  work with dates only.
    /// </summary>
    public class SimpleDate
    {
        private DateTime date;

        /// <summary>
        /// Creates a SimpleDate object whicht stores the given date.
        /// </summary>
        /// <param name="day">The day of the month</param>
        /// <param name="month">The month of the year</param>
        /// <param name="year">The year</param>
        public SimpleDate(int day, int month, int Year)
        {
            if (Year < 0001)
            {
                throw new ArgumentOutOfRangeException("please fill in a year before 0001");
            }
            date = new DateTime(Year, month, day);
        }

        /// <summary>
        /// The day of the month
        /// </summary>
        public int Day
        {
            get { return date.Day; }
        }

        /// <summary>
        /// The month of the year
        /// </summary>
        public int Month
        {
            get { return date.Month; }
        }

        /// <summary>
        /// The year
        /// </summary>
        public int Year
        {
            get { return date.Year; }
        }

        /// <summary>
        /// Get the tumber of days between this objects date and the given date.
        /// </summary>
        /// <param name="date">The end date.</param>
        /// <returns>The number of days between this date and endDate.</returns>
        /// <exception>gives an exception when date is not a date</exception>
        public int DaysDifference(SimpleDate date) //enddate
        {
            if (!(date is SimpleDate))
            {
                throw new ArgumentException("please fill in a SimpleDate");
            }
            TimeSpan timespan = date.date.Subtract(this.date);
            return timespan.Days;
        }

        /// <summary>
        /// Returns the date info in the form DD-MM-YYYY (e.g. "04-11-2013").
        /// 
        /// Note: Every class inherits (automagically) from the 'Object' class,
        /// which contains the virtual ToString method which you can override for your own good.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return date.ToString("dd-MM-yyyy");
        }
    }
}
