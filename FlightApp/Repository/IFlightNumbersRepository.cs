using FlightApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FlightApp.Repository
{
    interface IFlightNumbersRepository
    {
   

        List<FlightNumber> GetFlightNumbers();
    }
}
