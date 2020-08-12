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

            Console.WriteLine("_______________________________________________\n");


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
            Console.WriteLine("_______________________________________________\n");
            Console.WriteLine("couponDetails");

            Console.WriteLine(couponDetails);

            if (couponDetails.Flight != null) {
                Console.WriteLine("_______________________________________________\n");

                Console.WriteLine($"Coupon flights details {couponDetails.Flight}" );

                Console.WriteLine("_______________________________________________\n");

                Console.WriteLine("Flight number details :");

                Console.WriteLine($"Airline: {couponDetails.Flight.FlightNumber.AirLine}");
                Console.WriteLine($"Departure: {couponDetails.Flight.FlightNumber.Departure}");
                Console.WriteLine($"Description: {couponDetails.Flight.FlightNumber.Description}");

                Console.WriteLine("_______________________________________________\n");
                Console.WriteLine("Airport details :");

                Console.WriteLine($"Airport id: {couponDetails.Flight.FlightNumber.Airport.AirportId }");
                Console.WriteLine($"Airport Name: {couponDetails.Flight.FlightNumber.Airport.AirportName}");
                Console.WriteLine($"Airport Location: {couponDetails.Flight.FlightNumber.Airport.AirportLocation}");
                

            }










        }
    }
}
