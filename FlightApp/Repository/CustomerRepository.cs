using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using FlightApp.Entities;
using FlightApp.Helper;
using Newtonsoft.Json;

namespace FlightApp.Repository
{
    class CustomerRepository : ICustomerRepostiory
    {




        string path = "C:\\Users\\ahmed.ayaad\\source\\repos\\FlightApp\\FlightApp\\customer.json";

        //public Customer GetCustomer(int customerId)
        //{
        //throw new NotImplementedException();
        //}


        //static Customer customer1 = new Customer
        //{
        //    CustomerId = 1,
        //    Name = "a",
        //    Tickets = new List<Ticket>() {
        //        new Ticket(){TicketId=1, Customer=customer1}
        //    }
        //};

        //static Customer customer2 = new Customer
        //{
        //    CustomerId = 2,
        //    Name = "aa",
        //    Tickets = new List<Ticket>() {
        //        new Ticket(){TicketId=2, Customer=customer2}
        //    }
        //};


        //List<Customer> customers = new List<Customer>
        //{
        //  customer1,
        //  customer2
        //};




        public List<Customer> GetCustomers()
        {

            var customers = HelperMethods.ReadFile<Customer>(path);

            if (customers != null)
                return customers;
            return new List<Customer>();
            //using (StreamReader r = new StreamReader(path))
            //{
            //    string json = r.ReadToEnd();
            //    List<Customer> customers = JsonConvert.DeserializeObject<List<Customer>>(json);

            //    if (customers != null)
            //        return customers;
            //    return new List<Customer>();
            //}

        }
    }
}
