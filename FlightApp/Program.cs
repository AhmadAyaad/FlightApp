using FlightApp.Entities;
using FlightApp.Repository;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace FlightApp
{
    class Program
    {
        static void Main(string[] args)
        {

            CustomerRepository customerRepository = new CustomerRepository();
            var customers = customerRepository.GetCustomers();

            Console.WriteLine("App Customers :");

            foreach (var item in customers)
            {
                Console.WriteLine(item);

            }



            TicketRepository ticketRepository = new TicketRepository();

            var customerTickets = ticketRepository.GetTickets(1);

            foreach (var item in customerTickets)
            {
                Console.WriteLine($"Customer {item.Customer.CustomerId} Ticket id is: {item}");

                foreach (var coupon in item.Coupons)
                {
                    Console.WriteLine($"Ticket {item.TicketId} {coupon}");
                }
            }


            CouponRepository couponRepository = new CouponRepository();
            var couponDetails = couponRepository.GetCouponDetails(1);

            Console.WriteLine("couponDetails");

            Console.WriteLine(couponDetails);

            if (couponDetails.Flight != null) {
                Console.WriteLine($"Coupon flights details {couponDetails.Flight}" );
                
                Console.WriteLine($"Flight number : {couponDetails.Flight.FlightNumber}");
            }






            //FlightRepository flightRepository = new FlightRepository();
            //var flights = flightRepository.GetFlights();

            ////var couponFlights = flights.SelectMany(f => f.Coupons)
            ////                .Where(c => c.CouponId == couponDetails.CouponId).ToList();

            //var flag = false;


            //foreach (var item in flights)
            //{
            //    foreach (var item2 in item.Coupons)
            //    {
            //        if (item2.CouponId == couponDetails.CouponId)
            //            flag = true;
            //    }
            //    if(flag)
            //        Console.WriteLine(item);
            //    flag = false;
            //}
            //if (cf != null)
            //    foreach (var item in couponFlights)
            //        Console.WriteLine(item.Flight);

            //FlightNumbersRepository flightNumbersRepository = new FlightNumbersRepository();
            //var flightNumbers = flightNumbersRepository.GetFlightNumbers();







        }
    }
}
