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
        public int Hours
        {
            get { return hours; }
            set
            {
                if (value < 0 || value > 23)
                {
                    throw new ArgumentException("Значение часов от 0 до 23");
                }
                hours = value;
            }
        }
        private int minutes;
        public int Minutes
        {
            get { return minutes; }
            set
            {
                if (value < 0 || value > 60)
                {
                    throw new ArgumentException("Значение минут от 0 до 60");
                }
                minutes = value;
            }
        }
        private int seconds;
        public int Seconds
        {
            get { return seconds; }
            set
            {
                if (seconds < 0 || seconds > 60)
                {
                    throw new ArgumentException("Значение секунд от 0 до 60");
                }
                seconds = value;
            }
        }
    }
}
