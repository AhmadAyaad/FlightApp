using System;
using System.Collections.Generic;
using System.Text;

namespace FlightApp.Entities
{
    class PieceOfLuggage
    {
        public int LuggaageId { get; set; }
        public float Weight { get; set; }
        public Coupon Coupon { get; set; }
    }
}
