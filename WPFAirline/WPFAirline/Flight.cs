using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace WPFAirline
{
    public class Flight : Aircraft, IWrite
    {

        Aircraft _aircraft = new Aircraft();
        public int FlightNumber;
        public string Origin;
        public string Destination;
        string path = "@PassengerManifest.txt";

        public Dictionary<int, string> manifest = new Dictionary<int, string>()
        {
            {12 , "Ryan Webb"}
        };

        //example flight
        //Flight flight1 = new Flight(7167, new Aircraft(20, 1000, true), "Milwaukee", "Chicago");

        public Flight(int flightNumber, Aircraft aircraft, string origin, string destination)
        {
            this.FlightNumber = flightNumber;
            this._aircraft = aircraft;
            this.Origin = origin;
            this.Destination = destination;

            for (int i = 1; i < MaxPassengerCount; i++)
            {
                manifest.Add(i, "Unoccupied");
            }

        }    

        public void AddPassenger(int seat, string name)
        {
            manifest[seat] = name;
            seatList.Remove(seat);
            WriteToFile();
        }

        public void RemovePassenger(int seat)
        {
            manifest[seat] = null;
            seatList.Insert(seat, seat);
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

    }
}
