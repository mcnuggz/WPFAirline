using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
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
            for (int i = 1; i <= maxPassengerCount; i++)
            {
                seatList.Add(i);
            }
        }

        public void RemoveFlight()
        {
            if (seatList.Count == MaxPassengerCount)
            {

            }
        }

        public void Print()
        {
            foreach (int item in seatList)
            {
                Console.WriteLine(item);
            }
        }
       
        public void Remove(int seat)
        {
            if (seat > MaxPassengerCount)
            {
                Console.WriteLine("Seat unavailable");
            }
            else if (!seatList.Contains(seat))
            {
                seatList.Remove(seat);
            }
           
        }
    }
}