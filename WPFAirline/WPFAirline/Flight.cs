using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFAirline
{
    public class Flight : Aircraft
    {

        Aircraft _aircraft = new Aircraft();
        public int FlightNumber;
        public string Origin;
        public string Destination;

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

        }    

        public void AddPassenger(int seat, string name)
        {

        }

        public void RemovePassenger(int seat, string name)
        {          

            seatList.Add(seat);   
        }
       

    }
}
