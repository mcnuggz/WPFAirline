using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFAirline
{
    public class Seat
    {
        public int SeatNumber { get; set; }
        public Price price { get; set; }
        public Seat()
        {

        }
        //selling seats
        public Seat(int seatNumber, Price price)
        {
            this.SeatNumber = seatNumber;
            this.price = price;
        }
        //assign seat to passenger
        public Seat(int seatNumber)
        {
            this.SeatNumber = seatNumber;
        }
    
    }
}
