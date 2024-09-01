using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    public class Time
    {
        /// <summary>
        /// A private property of hours
        /// </summary>
        private int hours;

        /// <summary>
        /// A private property of minutes
        /// </summary>
        private int minutes;

        /// <summary>
        /// A private property of seconds
        /// </summary>
        private int seconds;

        /// <summary>
        /// Hours must be in range 0 and 23
        /// </summary>
        public int Hours
        {
            get { return hours; }
            set
            {
                Validator.AssertValueInRange(value, 0, 23, "Hours");
                hours = value;
            }
        }

        /// <summary>
        /// Minutes must be in range 0 and 60
        /// </summary>
        public int Minutes
        {
            get { return minutes; }
            set
            {
                Validator.AssertValueInRange(value, 0, 60, "Minutes");
                minutes = value;
            }
        }

        /// <summary>
        /// Seconds must be in range 0 and 60
        /// </summary>
        public int Seconds
        {
            get { return seconds; }
            set
            {
                Validator.AssertValueInRange(value, 0, 60, "Seconds");
                seconds = value;
            }
        }

        /// <summary>
        /// A time's constructor
        /// </summary>
        /// <param name="hours"> The field must be int in range </param>
        /// <param name="minutes"> The field must be int in range </param>
        /// <param name="seconds"> The field must be int in range </param>
        public Time(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }
    }
}
