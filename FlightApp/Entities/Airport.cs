using System;
using System.Collections.Generic;
using System.Text;

namespace FlightApp.Entities
{
    class Airport
    {
        public int AirportId { get; set; }
        public string AirportName { get; set; }
        public string AirportLocation { get; set; }
        public ICollection<FlightNumber> StartFlightsNumbers { get; set; } = new HashSet<FlightNumber>();
        public ICollection<FlightNumber> DestinationFlightsNumbers { get; set; } = new HashSet<FlightNumber>();

    }
}
