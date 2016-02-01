namespace WPFAirline
{
    public class Passenger
    {
        public Seat _seat;
        public string Name;
        public Passenger( string name, Seat seat)
        {
            this.Name = name;
            this._seat = seat;
        }
    }
}