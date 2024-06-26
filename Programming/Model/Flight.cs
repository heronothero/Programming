using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    public class Flight
    {
        public string DeparturePoint {  get; set; }
        public string Destination { get; set; }
        private int flightTime;
        public int FlightTime
        {
            get { return flightTime; }
            set
            {
                Validator.AssertOnPositiveValue(value, "FlightTime");
                flightTime = value;
            }
        }
    }
}
