using GreenMonkey.Manager;
using GreenMonkey.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreenMonkey.Desktop
{
    public partial class Form1 : Form
    {
        public CustomerManager CustomerManager { get; set; }
        public List<Customer> Customers { get; set; }
        public List<Customer> FilteredCustomer { get; set; }
        public Form1()
        {
            InitializeComponent();
            this.Load += new EventHandler(LoadForm);
            CustomerManager = new CustomerManager();
            Customers = new List<Customer>();
        }

        private void LoadForm(System.Object sender, System.EventArgs e)
        {
            SetupCustomerDataGrid();
        }

        private void SetupCustomerDataGrid()
        {
            Customers = CustomerManager.RetrieveAllCustomers();
            FilteredCustomer = Customers;

            FillDataGrid();
        }

        private void SearchCustomer(object sender, EventArgs e)
        {
            var name = customernameTextField.Text;
            var lastname = customerLastnameTextField.Text;
            var id = customerIdTextField.Text;
            var age = int.TryParse(customerAgeTextField.Text, out _) ? int.Parse(customerAgeTextField.Text) : - 1;

            FilteredCustomer = Customers.Where(customer => customer.Id.Contains(id)
                && customer.LastName.Contains(lastname)
                && customer.Name.Contains(name)
                && (age == -1 || customer.Age == age)
                ).ToList();

            FillDataGrid();
        }

        private void FillDataGrid()
        {
            this.customerDataGrid.Rows.Clear();
            
            foreach (var customer in FilteredCustomer)
            {
                var row = new string[] {
                    customer.Id,
                    customer.Fullname,
                    customer.LastName
                };

                this.customerDataGrid.Rows.Add(row);
            }
        }
    }
}
