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
        string path = "@PassengerManifest.txt";

        public Dictionary<int, string> manifest;
        List<Flight> availableFlights = new List<Flight>();
        public void MakeAvailableFlightsList()
        {
            
            availableFlights.Add(new Flight(1234, coolplane, "Milwaukee", "Chicago"));
            this.comboBox.ItemsSource = availableFlights;

        }
        //example flight
        //Flight flight1 = new Flight(7167, new Aircraft(20, 10000, true), "Milwaukee", "Chicago");
        //Flight flight2 = new Flight(7307, bobby, "St. Louis", "Atlanta");
        public Flight()
        {

        }

        public Flight(int flightNumber, Aircraft aircraft, string origin, string destination)
        {
            this.FlightNumber = flightNumber;
            this._aircraft = aircraft;
            this.Origin = origin;
            this.Destination = destination;
            manifest = new Dictionary<int, string>();
            for (int i = 1; i < MaxPassengerCount; i++)
            {
                manifest.Add(i, "Unoccupied");
            }
        }    

        public void AddPassenger(int seat, string name)
        {
            manifest[seat] = name;
            _aircraft.seatList.Remove(seat);
            WriteToFile();
        }

        public void RemovePassenger(int seatNum, ref int seatPrice)
        {
            manifest[seatNum] = "Unoccupied";
            _aircraft.seatList.Add(seatNum, seatPrice);
            WriteToFile();
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
            if (_aircraft.TravelRangeInMiles == 0)
            {
                _aircraft.MaintenanceStatus = false;
                RemoveFlight(flight);
                Thread.Sleep(7000);
                _aircraft.MaintenanceStatus = true;
                AddFlight(flight);
            }
        }

        public void WriteToFile()
        {
            using (TextWriter writer = new StreamWriter(path))
            {
                if (!File.Exists(path))
                {
                    File.Create(path);
                    foreach (KeyValuePair<int,string> passenger in manifest)
                    {
                        writer.Write(manifest);
                    }                    
                }
                else
                {
                    foreach (KeyValuePair<int, string> passenger in manifest)
                    {
                        writer.Write(manifest);
                    }
                }
            }
        }

        public void ReadFile()
        {
            using (StreamReader reader = new StreamReader(path))
            {
                reader.ReadToEnd();
            }
        }
        static Aircraft coolplane = new Aircraft(20, 4000, true);

    }
}
