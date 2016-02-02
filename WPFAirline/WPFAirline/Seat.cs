using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFAirline
{
    public class Seat
    {
        public int SeatNumber;
        public int Price;
        public int Price1 = 49;
        public int Price2 = 39;
        public int Price3 = 29;
        public Seat()
        {

        }
        //selling seats
        public Seat(int seatNumber, int price)
        {
            this.SeatNumber = seatNumber;
            this.Price = price;
        }
        //assign seat to passenger
        public Seat(int seatNumber)
        {
            this.SeatNumber = seatNumber;
        }
    
    }
}
