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
            manifest = new Dictionary<int, string>();
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
            _aircraft.MaintenanceStatus = false;
            RemoveFlight(flight);
            Thread.Sleep(7000);
            _aircraft.MaintenanceStatus = true;
            AddFlight(flight);
            
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
                        writer.Write(manifest.ToString());
                    }                    
                }
                else
                {
                    foreach (KeyValuePair<int, string> passenger in manifest)
                    {
                        writer.Write(manifest.ToString());
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
      
        public override string ToString()
        {
            return FlightNumber + ": " + Origin + " to " + Destination;
        }

        
    }
}
