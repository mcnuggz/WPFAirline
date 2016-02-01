using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFAirline
{
    class Seat
    {
        int SeatNumber;
        char RowLetter;
        int Price;
        public Seat(int seatNumber, char rowLetter, int price)
        {
            this.SeatNumber = seatNumber;
            this.RowLetter = rowLetter;
            this.Price = price;
        }
    }
}
