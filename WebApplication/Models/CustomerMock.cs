using System.Collections.Generic;

namespace WebApplication.Models
{
    public static class CustomerMock
    {
        private static List<Customer> CustomersList { get; set; } = new List<Customer>
        {
            new Customer {Name = "Peter Ring", Id = 1},
            new Customer {Name = "Alex Carstensen", Id = 2}
    };

        public static List<Customer> GetCustomers()
        {
            return CustomersList;
        }
    }
}