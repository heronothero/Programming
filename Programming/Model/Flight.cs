using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    public class Flight
    {
        /// <summary>
        /// A private property of flight time
        /// </summary>
        private int flightTime;

        /// <summary>
        /// A public property of departure point
        /// </summary>
        public string DeparturePoint{ get; set; }

        /// <summary>
        /// A public property of destination
        /// </summary>
        public string Destination{ get; set; }

        /// <summary>
        /// Cheking flight time, which must be positive and int
        /// </summary>
        public int FlightTime
        {
            get { return flightTime; }
            set 
            {
                Validator.AssertOnPositiveValue(value, "FlightTime");
                flightTime = value;
            }
        }

        /// <summary>
        /// A flight's constructor
        /// </summary>
        /// <param name="destination"> The field can contain letters and numbers </param>
        /// <param name="departurePoint"> The field can contain letters and numbers </param>
        /// <param name="flightTime"> The field must be int </param>
        public Flight(string destination, string departurePoint, int flightTime)
        {
            Destination = destination;
            DeparturePoint = departurePoint;
            FlightTime = flightTime;
        }
    }
}
