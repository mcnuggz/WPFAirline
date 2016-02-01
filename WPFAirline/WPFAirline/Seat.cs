using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFAirline
{
    public class Seat
    {
        public string _Seat;
        public int Price;

        //selling seats
        public Seat(string seatNumber, int price)
        {
            this._Seat = seatNumber;
            this.Price = price;
        }
        //assign seat to passenger
        public Seat(string seatNumber, bool isOccupied = true)
        {
            this._Seat = seatNumber;
        }
    
    }
}
