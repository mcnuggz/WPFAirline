using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFAirline
{
    public class Aircraft
    {
        public int MaxPassengerCount;
        public int PassengerCount;
        public int AvailableSeats;
        public int TravelRangeInMiles;
        public bool MaintenanceStatus;

        //schedule
        Dictionary<string, string> availableFlights = new Dictionary<string, string>()
        {
            {"Los Angeles", "1:45pm" }
        };

        public Aircraft()
        {

        }

        public Aircraft(int maxPassengerCount, int travelRangeInMiles, bool maintenanceStatus = true)
        {
            this.MaxPassengerCount = maxPassengerCount;
            this.TravelRangeInMiles = travelRangeInMiles;
        }

        public static void RemoveFlight()
        {
            
        }
    }
}
