using GreenMonkey.DataAccess.Crud;
using GreenMonkey.Models;
using GreenMonkey.Utils;
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
        private AccountCrudFactory AccountFactory { get; set; }
        public CustomerManager()
        {
            CustomerFactory = new CustomerCrudFactory();
            AccountFactory = new AccountCrudFactory();
        }

        public void CreateCustomer(Customer customer)
        {
            CustomerFactory.Create(customer);
            AccountFactory.Create(new Account()
            {
                Status = "Activa",
                Name = "Credito",
                CustomerId = customer.Id,
                CoinCode = "1028"
            });
        }

        public Customer RetrieveCustomer(Customer customer)
        {
            return CustomerFactory.Retrieve<Customer>(customer);
        }

        public Customer RetrieveCustomerWithAccounts(Customer customer)
        {
            var existingCustomer = CustomerFactory.Retrieve<Customer>(customer);

            if (existingCustomer == null)
                return null;

            existingCustomer.Accounts = AccountFactory
                .RetrieveAllByCustomer<Account>(new Account { CustomerId = existingCustomer.Id });

            return existingCustomer;
        }

        public List<Customer> RetrieveAllCustomers()
        {
            return CustomerFactory.RetrieveAll<Customer>();
        }

        public void UpdateCustomer(Customer customer)
        {
            CustomerFactory.Update(customer);
        }

        public void DeleteCustomer(Customer customer)
        {
            CustomerFactory.Delete(customer);
        }
    }
}
