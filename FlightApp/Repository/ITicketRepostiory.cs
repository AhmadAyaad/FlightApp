using FlightApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FlightApp.Repository
{
    interface ITicketRepostiory
    {
        List<Ticket> GetTickets(int customerId);
    }
}
