using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFAirline
{
    public class Aircraft
    {
        int PassengerCount;
        int TravelRangeInMiles;
        bool MaintenanceStatus;
        //schedule
        public Aircraft(int passengerCount, int travelRangeInMiles, bool maintenanceStatus = true)
        {
            this.PassengerCount = passengerCount;
            this.TravelRangeInMiles = travelRangeInMiles;
        }

    }
}
