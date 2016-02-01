using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFAirline
{
    public class Flight : Aircraft
    {
        Aircraft _aircraft;
        public int FlightNumber;
        public string Origin;
        public string Destination;

        public List<Passenger> manifest = new List<Passenger>()
        {
            (new Passenger("Ryan Webb", new Seat(2, Row.A))),
            (new Passenger("Christian Petersen", new Seat(3, Row.D)))
        };

        //example flight
        //Flight flight1 = new Flight(7167, new Aircraft(20, 1000, true), "Milwaukee", "Chicago");

        public Flight(int flightNumber, Aircraft aircraft, string origin, string destination)
        {
            this.FlightNumber = flightNumber;
            this._aircraft = aircraft;
            this.Origin = origin;
            this.Destination = destination;
        }    

        public void AddPassenger(string name, int seat, Row row)
        {
            manifest.Add(new Passenger(name, new Seat(seat, row)));
        }

        public void RemovePassenger(Passenger name)
        {
            if (manifest.Contains(name))
            {
                manifest.Remove(name);                
            }
        }

    }
}
