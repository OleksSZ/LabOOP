using System;

namespace Lab23
{
    public class Flight
    {
        public string Number { get; set; }
        public string Departure { get; set; }
        public string Destination { get; set; }
        public DateTime DepartureTime { get; set; }

        public Flight(string number, string departure, string destination, DateTime time)
        {
            Number = number;
            Departure = departure;
            Destination = destination;
            DepartureTime = time;
        }

        public override string ToString()
        {
            return $"{Number}: {Departure} → {Destination}, {DepartureTime}";
        }
    }
}
