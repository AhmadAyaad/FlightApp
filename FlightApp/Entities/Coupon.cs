using System;
using System.Collections.Generic;
using System.Text;

namespace FlightApp.Entities
{
    class Coupon
    {
        public int CouponId { get; set; }
        public CouponType CouponType { get; set; }
        public Ticket Ticket { get; set; }
        public ICollection<PieceOfLuggage> PieceOfLuggage { get; set; } = new HashSet<PieceOfLuggage>();
        public Flight Flight { get; set; }

        public override string ToString()
        {
            var couponType = Enum.GetName(typeof(CouponType), CouponType);

            return $"coupon id: {CouponId} ,Coupon Type:{couponType} , ticket id : {Ticket}";

        }
    }
}
