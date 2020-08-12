using System;
using System.Collections.Generic;
using System.Text;

namespace FlightApp.Entities
{
    class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }

        public ICollection<Ticket> Tickets { get; set; } = new HashSet<Ticket>();
        public override string ToString()
        {
            return $"cusotmer id is : {CustomerId} , name : {Name} ";
        }
    }
}
