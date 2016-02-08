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
        public Seat(int seatNumber, Price price)
        {
            this.SeatNumber = seatNumber;
            this.price = price;
        }
        public Seat(int seatNumber)
        {
            this.SeatNumber = seatNumber;
        }

        public override string ToString()
        {
            return "Seat " + SeatNumber + " : $" + Convert.ToInt32(price);
        }

    }
}
