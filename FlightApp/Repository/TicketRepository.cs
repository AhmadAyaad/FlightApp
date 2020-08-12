using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlightApp.Entities;
using FlightApp.Helper;
using Newtonsoft.Json;

namespace FlightApp.Repository
{
    class TicketRepository : ITicketRepostiory
    {
        string path = "C:\\Users\\ahmed.ayaad\\source\\repos\\FlightApp\\FlightApp\\tickets.json";

        public List<Ticket> GetTickets(int customerId)
        {
            var tickets = HelperMethods.ReadFile<Ticket>(path);
                var customerTickets = tickets.Where(t => t.Customer.CustomerId == customerId).ToList();

                if (customerTickets != null)
                    return customerTickets;
                return new List<Ticket>();

        }
    }
}
