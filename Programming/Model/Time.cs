using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    public class Time
    {
        private int hours;
        private int minutes;
        private int seconds;
        public int Hours
        {
            get { return hours; }
            set
            {
                Validator.AssertValueInRange(value, 0, 23, "Hours");
                hours = value;
            }
        }
        public int Minutes
        {
            get { return minutes; }
            set
            {
                Validator.AssertValueInRange(value, 0, 60, "Minutes");
                minutes = value;
            }
        }
        public int Seconds
        {
            get { return seconds; }
            set
            {
                Validator.AssertValueInRange(value, 0, 60, "Seconds");
                seconds = value;
            }
        }
        public Time(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }
    }
}
