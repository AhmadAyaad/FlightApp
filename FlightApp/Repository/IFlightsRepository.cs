using FlightApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FlightApp.Repository
{
    interface IFlightsRepository
    {
        List<Flight> GetFlights();
    }
}
