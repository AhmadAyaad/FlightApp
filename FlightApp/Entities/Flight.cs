using System;
using System.Collections.Generic;
using System.Text;

namespace FlightApp.Entities
{
    class Flight
    {
        public int FlightId { get; set; }
  
        public ICollection<Coupon> Coupons { get; set; }
        public FlightNumber FlightNumber { get; set; }

        public override string ToString()
        {
            return $"flight id: { FlightId} , flight number {FlightNumber.FlightNumberId}";
        }
    }
}
