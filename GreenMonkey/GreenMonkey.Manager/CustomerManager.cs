using GreenMonkey.DataAccess.Crud;
using GreenMonkey.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenMonkey.Manager
{
    public class CustomerManager : BaseManager
    {
        private CustomerCrudFactory CustomerFactory { get; set; }
        public CustomerManager()
        {
            CustomerFactory = new CustomerCrudFactory();
        }

        public void CreateCustomer(Customer customer)
        {
            CustomerFactory.Create(customer);
        }

        public Customer RetrieveCustomer(Customer customer)
        {
            return CustomerFactory.Retrieve<Customer>(customer);
        }

        public List<Customer> RetrieveAllCustomers()
        {
            return CustomerFactory.RetrieveAll<Customer>();
        }
    }
}
