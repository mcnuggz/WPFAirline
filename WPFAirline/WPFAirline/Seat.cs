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
        public string RowLetter;
        public int Price;
        //selling seats
        public Seat(int seatNumber, string rowLetter, int price)
        {
            this.SeatNumber = seatNumber;
            this.RowLetter = rowLetter;
            this.Price = price;
        }
        //assign seat to passenger
        public Seat(int seatNumber, string rowLetter)
        {
            this.SeatNumber = seatNumber;
            this.RowLetter = rowLetter;
        }
    }
}
