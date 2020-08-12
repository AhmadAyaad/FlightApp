using System;
using System.Collections.Generic;
using System.Text;
using FlightApp.Entities;
using FlightApp.Helper;

namespace FlightApp.Repository
{
    class FlightNumbersRepository : IFlightNumbersRepository
    {
        string path = "C:\\Users\\ahmed.ayaad\\source\\repos\\FlightApp\\FlightApp\\FlightNumbers.json";
        public List<FlightNumber> GetFlightNumbers()
        {
            var flightNumbers = HelperMethods.ReadFile<FlightNumber>(path);
            if (flightNumbers != null)
                return flightNumbers;
            return new List<FlightNumber>();
        }
    }
}
