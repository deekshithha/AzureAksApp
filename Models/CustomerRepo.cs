using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerManagementProject.Models
{
    public class CustomerRepo : IRepo<Customer>
    {
        public List<Customer> customers { get; set; }
        public CustomerRepo()
        {
            customers = new List<Customer>()
            {
                new Customer
                {
                    Id=1,
                    Name="Hello",
                    Age=120
                }
            };
        }
        public void AddItems(Customer item)
        {
            this.customers.Add(item);
        }

        public IEnumerable<Customer> GetItems()
        {
            return customers;
        }
    }
}
