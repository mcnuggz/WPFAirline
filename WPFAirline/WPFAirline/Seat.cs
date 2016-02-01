using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFAirline
{
    public class Seat
    {
        public Row RowLetter;
        public int SeatNumber;
        public int Price;
        //selling seats
        public Seat(int seatNumber, Row rowLetter, int price)
        {
            this.SeatNumber = seatNumber;
            this.RowLetter = rowLetter;
            this.Price = price;
        }
        //assign seat to passenger
        public Seat(int seatNumber, Row rowLetter)
        {
            this.SeatNumber = seatNumber;
            this.RowLetter = rowLetter;
        }
    }
}
