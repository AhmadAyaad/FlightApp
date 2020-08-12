using System;
using System.Collections.Generic;
using System.Text;

namespace FlightApp.Entities
{
    class FlightNumber
    {
        public int FlightNumberId { get; set; }
        public DateTime Departure { get; set; }
        public string Description { get; set; }
        public string AirLine { get; set; }
        public ICollection<Flight> Flights { get; set; } = new HashSet<Flight>();
        public Airport Airport { get; set; }

        public override string ToString()
        {
            return $"flight number: {FlightNumberId} , depature: {Departure.ToShortDateString()} ," +
                $"Description : {Description} , airline : {AirLine}  ";
        }
    }
}
