using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace WPFAirline
{
    public class Flight : Aircraft, IWrite, IRead
    {
        
        Aircraft _aircraft = new Aircraft();
        public int FlightNumber { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public string DepartureTime { get; set; }
        public string DepartureDate { get; set; }

        public SortedDictionary<int, string> manifest { get; set; }
        List<string> list { get; set; }
        List<Flight> availableFlights = new List<Flight>();
        public Flight()
        {

        }

        public Flight(int flightNumber, string origin, string destination, string departureTime, string departureDate)
        {
            this.FlightNumber = flightNumber;
            this.Origin = origin;
            this.Destination = destination;
            this.DepartureTime = departureTime;
            this.DepartureDate = departureDate;
            manifest = new SortedDictionary<int, string>();
            for (int i = 1; i < MaxPassengerCount; i++)
            {
                manifest.Add(i, null);
            }
        }    

        public void AddPassenger(int seat, string name)
        {
            manifest = new SortedDictionary<int, string>();
            manifest[seat] = name;
            _aircraft.seatList.Remove(seat);   
        }

        public void RemovePassenger(int seatNum, ref int seatPrice)
        {
            manifest = new SortedDictionary<int, string>();
            manifest[seatNum] = "Unoccupied";
            _aircraft.seatList.Add(seatNum, seatPrice);          
        }

        public void AddFlight(Flight flight)
        {
            availableFlights.Add(flight);
        }

        public void RemoveFlight(Flight flight)
        {
            if (seatList.Count == MaxPassengerCount)
            {
                availableFlights.Remove(flight);
            }
        }

        public void Refuel(Flight flight)
        {
            _aircraft.MaintenanceStatus = false;
            RemoveFlight(flight);
            Thread.Sleep(7000);
            _aircraft.MaintenanceStatus = true;
            AddFlight(flight);        
        }

        public void WriteToFile(string path)
        {
            using (StreamWriter writer = new StreamWriter(path, true))
            {
                foreach (KeyValuePair<int, string> passenger in manifest)
                {
                    writer.WriteLine("Seat {0}: {1}", passenger.Key, passenger.Value);
                }
            }
        }

        public void ReadFile(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    list.Add(line);
                }
            }         
        }
      
        public override string ToString()
        {
            return String.Format("{0}: {1} to {2, -45} Departs On: {3} at {4}", FlightNumber, Origin, Destination, DepartureDate, DepartureTime);
        }


    }
}
