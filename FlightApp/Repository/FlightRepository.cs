using System;
using System.Collections.Generic;
using System.Text;
using FlightApp.Entities;
using FlightApp.Helper;

namespace FlightApp.Repository
{
    class FlightRepository : IFlightsRepository
    {
        string path = "C:\\Users\\ahmed.ayaad\\source\\repos\\FlightApp\\FlightApp\\Flights.json";

        public List<Flight> GetFlights()
        {
            var flights =  HelperMethods.ReadFile<Flight>(path);
            if (flights != null)
                return flights;

            return new List<Flight>();
        }
    }
}
