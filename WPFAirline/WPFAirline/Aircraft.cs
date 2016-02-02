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
        public List<int> seatList = new List<int>();

        //schedule
        List<Flight> availableFlights = new List<Flight>();

        public Aircraft()
        {

        }

        public Aircraft(int maxPassengerCount, int travelRangeInMiles, bool maintenanceStatus)
        {
            this.MaxPassengerCount = maxPassengerCount;
            this.TravelRangeInMiles = travelRangeInMiles;
            this.MaintenanceStatus = maintenanceStatus;
            for (int i = 0; i < maxPassengerCount; i++)
            {
                seatList.Add(i);
            }
        }

        public void AddFlight(Flight flight)
        {
            availableFlights.Add(flight);
        }

        public void RemoveFlight(Flight flight)
        {
            if (PassengerCount == MaxPassengerCount)
            {
                availableFlights.Remove(flight);
            }
        }

    }
}
