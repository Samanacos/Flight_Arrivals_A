using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlightArrivals_A
{
    public class Flight
    {
        public string FlightNo;
        public string DepartName;
        public string ArrivalTime;

        public Flight(string flNo, string dep, string time)
        {
            FlightNo = flNo;
            DepartName = dep;
            ArrivalTime = time;
        }

        public override string ToString()
        {
            return String.Format("{0,-15}{1,-15}{2,-10}", FlightNo, DepartName, ArrivalTime);
        }
    }
}
