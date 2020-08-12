using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FlightApp.Entities;
using FlightApp.Helper;

namespace FlightApp.Repository
{
    class CouponRepository : ICouponRepostiory
    {

        //Coupon coupon = new Coupon
        //{
        //    CouponId = 1,
        //    CouponType = CouponType.Flight,
        //    Flight = new Flight()
        //    {
        //        FlightId = 1,
        //        FlightNumber = new FlightNumber
        //        {

        //        }
        //    }
        //};


        string path = "C:\\Users\\ahmed.ayaad\\source\\repos\\FlightApp\\FlightApp\\Coupon.json";
        public Coupon GetCouponDetails(int id)
        {

            var coupons = HelperMethods.ReadFile<Coupon>(path);

            var couponDetails = coupons.FirstOrDefault(c => c.CouponId == id);

            if (couponDetails != null)
                return couponDetails;
            return new Coupon();

        }
    }
}
