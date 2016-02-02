using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace WPFAirline
{
    public class Flight : Aircraft, IWrite, IRead
    {

        Aircraft _aircraft = new Aircraft();
        public int FlightNumber;
        public string Origin;
        public string Destination;
        string path = "@PassengerManifest.txt";

        public Dictionary<int, string> manifest;

        //example flight
        //Flight flight1 = new Flight(7167, new Aircraft(20, 1000, true), "Milwaukee", "Chicago");
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
    }
}
