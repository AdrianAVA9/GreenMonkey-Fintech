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
        public CoinManager CoinManager { get; set; }
        public List<Customer> Customers { get; set; }
        public List<Coin> Coins { get; set; }

        public Form1()
        {
            InitializeComponent();
            this.Load += new EventHandler(LoadForm);
            CustomerManager = new CustomerManager();
            CoinManager = new CoinManager();
        }

        private void LoadForm(System.Object sender, System.EventArgs e)
        {
            SetupCustomerDataGrid();
            SetupCoinsDataGrid();
        }

        private void SetupCoinsDataGrid()
        {
            Coins = CoinManager.RetrieveAllCoinWithFintech();

            foreach (var coin in Coins)
            {
                var row = new string[] {
                    coin.Fintech?.Name,
                    coin.FintechCode,
                    coin.Code.ToString(),
                    coin.Name
                };

                this.coinsDataGrid.Rows.Add(row);
            }
        }

        private void SetupCustomerDataGrid()
        {
            Customers = CustomerManager.RetrieveAllCustomers();

            foreach (var customer in Customers)
            {
                var row = new string[] {
                    customer.Id,
                    customer.Name,
                    customer.LastName,
                    customer.Age.ToString(),
                    customer.PhoneNumber,
                    customer.Email
                };

                this.customerDataGrid.Rows.Add(row);
            }
        }

        private void SelectCustomer(object sender, DataGridViewCellEventArgs e)
        {
            var rowIndex = customerDataGrid.CurrentCell.RowIndex;

            if (Customers.ElementAtOrDefault(rowIndex) != null)
                DisplayCustomer(Customers[rowIndex]);
        }

        private void DisplayCustomer(Customer customer)
        {
            if (customer == null)
                return;

            editTFCustomerId.Text = customer.Id;
            editTFCustomername.Text = customer.Fullname;
            editTFLastaname.Text = customer.LastName;
            editTFAge.Text = customer.Age.ToString();
        }

        private void SearchCustomer(object sender, EventArgs e)
        {
            var id = customerIdTextField.Text;
            var existingCustomer = CustomerManager.RetrieveCustomerWithAccounts(new Customer { Id = id });

            if(existingCustomer != null)
            {
                customernameTextField.Text = existingCustomer.Name;
                customerLastnameTextField.Text = existingCustomer.LastName;
                customerAgeTextField.Text = existingCustomer.Age.ToString();
                
                LoadAccounts(existingCustomer.Accounts);
            }
            else
            {
                customernameTextField.Text = "";
                customerLastnameTextField.Text = "";
                customerAgeTextField.Text = "";
                ClearAccountDataGrid();

                MessageBox.Show(string.Format("The customer id: {0} does not exists", id));
            }
        }

        private void LoadAccounts(List<Account> accounts)
        {
            ClearAccountDataGrid();

            foreach (var account in accounts)
            {
                var row = new string[] {
                    account.CustomerId,
                    account.Number,
                    "",
                    account.Name,
                    account.Status,
                };

                this.accountsDataGrid.Rows.Add(row);
            }
        }

        private void ClearAccountDataGrid()
        {
            this.accountsDataGrid.Rows.Clear();
        }

        private void LoadTransactions(Customer customer)
        {

        }
    }
}
