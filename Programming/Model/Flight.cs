using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    public class Flight
    {
        private int flightTime;
        public string DeparturePoint{ get; set; }
        public string Destination{ get; set; }
        public int FlightTime
        {
            get { return flightTime; }
            set 
            {
                Validator.AssertOnPositiveValue(value, "FlightTime");
                flightTime = value;
            }
        }
        public Flight(string destination, string departurePoint, int flightTime)
        {
            Destination = destination;
            DeparturePoint = departurePoint;
            FlightTime = flightTime;
        }
    }
}
