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
        }

        public Customer RetrieveCustomer(Customer customer)
        {
            var smsClient = new SMSClient("092a341683abe9326d9866e622d907e8", "ACf01d579cfb2428dd04e5e6962b97ab7c", "+15402992669");
            smsClient.SendMessage("Hello World", "+50671221940");
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
