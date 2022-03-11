using GreenMonkey.Manager;
using GreenMonkey.Models;
using GreenMonkey.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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
        private SMSClient _SMSClient { get; set; }
        private string _OTPToken { get; set; }
        private Customer _CUSTOMER_IN_PROCESS { get; set; }

        public Form1()
        {
            InitializeComponent();
            this.Load += new EventHandler(LoadForm);
            CustomerManager = new CustomerManager();
            CoinManager = new CoinManager();

            var phoneNumber = ConfigurationManager.AppSettings["TWILIO_PHONE_NUMBER"];
            var accountSId = ConfigurationManager.AppSettings["TWILIO_ACCOUNT_SID"];
            var token = ConfigurationManager.AppSettings["TWILIO_TOKEN"];
            _SMSClient = new SMSClient(token, accountSId, phoneNumber);
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
            this.customerDataGrid.Rows.Clear();

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
            editTFCustomername.Text = customer.Name;
            editTFLastaname.Text = customer.LastName;
            editTFBirdthdate.Value = customer.Birthdate;
            editTFEmail.Text = customer.Email;
            editTFPhoneNumber.Text = customer.PhoneNumber;
            editTFNickname.Text = customer.Nickname;
            editTFStatus.Text = customer.Status;
        }

        private void CreateUser(object sender, EventArgs e)
        {

            try
            {
                if(!IsCustomerFormValid())
                {
                    MessageBox.Show("All fields are requerid");
                    return;
                }

                _CUSTOMER_IN_PROCESS = new Customer()
                {
                    Id = editTFCustomerId.Text,
                    Name = editTFCustomername.Text,
                    LastName = editTFLastaname.Text,
                    Birthdate = editTFBirdthdate.Value,
                    Email = editTFEmail.Text,
                    PhoneNumber = "+506" + editTFPhoneNumber.Text,
                    Nickname = editTFNickname.Text,
                    Status = editTFStatus.Text
                };

                _OTPToken = OTPClient.GenerateOTP(6);
                var message = string.Format("Your 6-digit security code is {0}. Don't share this code whit anyone", _OTPToken);

                _SMSClient.SendMessage(message, _CUSTOMER_IN_PROCESS.PhoneNumber);

                otpTokenPanel.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SaveUser(object sender, EventArgs e)
        {
            var optToken = TFotpToken.Text;

            if (!optToken.Equals(_OTPToken))
            {
                MessageBox.Show("Invalid OTP");
                return;
            }
            
            CustomerManager.CreateCustomer(_CUSTOMER_IN_PROCESS);
            SetupCustomerDataGrid();
            ResetCustomerForm();

            _CUSTOMER_IN_PROCESS = null;
            _OTPToken = string.Empty;
        }

        private void UpdateCustomer(object sender, EventArgs e)
        {
            if (!IsCustomerFormValid())
            {
                MessageBox.Show("All fields are requerid");
                return;
            }

            var customer = new Customer()
            {
                Id = editTFCustomerId.Text,
                Name = editTFCustomername.Text,
                LastName = editTFLastaname.Text,
                Birthdate = editTFBirdthdate.Value,
                Email = editTFEmail.Text,
                PhoneNumber = editTFPhoneNumber.Text,
                Nickname = editTFNickname.Text,
                Status = editTFStatus.Text
            };

            CustomerManager.UpdateCustomer(customer);
            SetupCustomerDataGrid();
        }

        private bool IsCustomerFormValid()
        {
            Func<string, bool> isEmpty = (value) => string.IsNullOrEmpty(value);

            return !(isEmpty(editTFCustomerId.Text) || isEmpty(editTFCustomername.Text) || isEmpty(editTFLastaname.Text) || isEmpty(editTFEmail.Text)
                || isEmpty(editTFPhoneNumber.Text) || isEmpty(editTFNickname.Text) || isEmpty(editTFStatus.Text));
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
                    account.FormattedAmount,
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

        private void ClearCustomerForm()
        {
            editTFCustomerId.Text = "";
            editTFCustomername.Text = "";
            editTFLastaname.Text = "";
            editTFBirdthdate.Value = DateTime.Now;
            editTFEmail.Text = "";
            editTFPhoneNumber.Text = "";
            editTFStatus.Text = "";
            editTFNickname.Text = "";
        }

        private void ResetCustomerForm()
        {
            ClearCustomerForm();
            otpTokenPanel.Visible = false;
            TFotpToken.Text = "";
        }

        private void resetCustomerForm_Click(object sender, EventArgs e)
        {
            ResetCustomerForm();
        }

        private void LoadTransactions(Customer customer)
        {

        }
    }
}
