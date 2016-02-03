using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WPFAirline
{
    public class Aircraft
    {
        Seat seat = new Seat();
        public int MaxPassengerCount { get; set; }
        public int PassengerCount { get; set; }
        public int AvailableSeats { get; set; }
        public int TravelRangeInMiles { get; set; }
        public bool MaintenanceStatus { get; set; }

        public SortedList<int, int> seatList = new SortedList<int,int>();

        //schedule
        

        public Aircraft()
        {

        }

        public Aircraft(int maxPassengerCount, int travelRangeInMiles, bool maintenanceStatus)
        {
            this.MaxPassengerCount = maxPassengerCount;
            this.TravelRangeInMiles = travelRangeInMiles;
            this.MaintenanceStatus = maintenanceStatus;
            if (maxPassengerCount <= 20)
            {
                FirstClass();
            }
            else if (maxPassengerCount <= 100)
            {
                BusinessClass();
            }
            else if (maxPassengerCount >= 100)
            {
                EconomyClass();
            }
        }

        private void FirstClass()
        {
            seatList = new SortedList<int, int>();
            for (int i = 1; i < 20; i++)
            {
                seatList.Add(i, seat.Price1);
            }
        }
        private void BusinessClass()
        {
            seatList = new SortedList<int, int>();
            FirstClass();
            for (int i = 20; i < MaxPassengerCount + 1; i++)
            {
                seatList.Add(i, seat.Price2);
            }
        }
        private void EconomyClass()
        {
            seatList = new SortedList<int, int>();
            FirstClass();
            BusinessClass();
            for (int i = 100; i < MaxPassengerCount + 1; i++)
            {
                seatList.Add(i, seat.Price3);
            }
        }
        




    }
}
