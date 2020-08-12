using System;
using System.Collections.Generic;
using System.Text;

namespace FlightApp.Entities
{
    class Ticket
    {
        public int TicketId { get; set; }
  
        public Customer Customer { get; set; }

        public ICollection<Coupon> Coupons { get; set; } = new HashSet<Coupon>();

        public override string ToString()
        {
            return $"{TicketId}";
        }
    }
}
