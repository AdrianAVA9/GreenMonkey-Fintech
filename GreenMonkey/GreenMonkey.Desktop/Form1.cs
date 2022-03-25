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

        /** Properties for customer registration **/
        private string _CustomerRegistrationOTPToken { get; set; }
        private Customer _CUSTOMER_IN_PROCESS { get; set; }
        
        /** Properties for transaction **/
        private string _TransactionOTPToken { get; set; }
        private Transaction _TRANSACTION_IN_PROCESS { get; set; }

        /** Properties for consulted customer **/
        private Customer _CUSTOMER_IN_ACTION { get; set; }

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
            SetupTransactionType();
        }

        private void SetupTransactionType()
        {
            transferTypeTF.Items.Add("Credito");
            transferTypeTF.Items.Add("Debito");
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

                _CustomerRegistrationOTPToken = OTPClient.GenerateOTP(6);
                var message = string.Format("Your 6-digit security code is {0}. Don't share this code whit anyone", _CustomerRegistrationOTPToken);

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

            if (!optToken.Equals(_CustomerRegistrationOTPToken))
            {
                MessageBox.Show("Invalid OTP");
                return;
            }
            
            CustomerManager.CreateCustomer(_CUSTOMER_IN_PROCESS);
            SetupCustomerDataGrid();
            ResetCustomerForm();

            _CUSTOMER_IN_PROCESS = null;
            _CustomerRegistrationOTPToken = string.Empty;
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
                _CUSTOMER_IN_ACTION = existingCustomer;

                LoadAccounts(existingCustomer.Accounts);
            }
            else
            {
                _CUSTOMER_IN_ACTION = null;
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
                this.transferFromTF.Items.Add(account.Number);
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

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            try
            {
                if (_CUSTOMER_IN_ACTION == null)
                    throw new Exception("Plese select a customer");

                Func<string, bool> isEmpty = (value) => string.IsNullOrEmpty(value);
                var from = this.transferFromTF.Text;
                var to = this.transferToTF.Text;
                var amount = this.transferAmountTF.Text;
                var type = this.transferTypeTF.Text;

                if (isEmpty(from))
                    throw new Exception("Invalid ");

                if (isEmpty(to) && to.Length != 14)
                    throw new Exception("Invalid destination account number. Must has 14 characters. ex: CR_0000_000000");

                if (isEmpty(amount) || !decimal.TryParse(amount, out _) || decimal.Parse(amount) <= 0)
                    throw new Exception("The amount must be numeric and up to zero");

                if (isEmpty(type))
                    throw new Exception("Please choose the transaction type");

                var _TRANSACTION_IN_PROCESS = new Transaction()
                {
                    UBAN = to,
                    Amount = decimal.Parse(amount),
                    RegisteredAt = DateTime.Now,
                    Type = type
                };

                if (isEmpty(_CUSTOMER_IN_ACTION.PhoneNumber))
                    throw new Exception("The customer phoneNumber is invalid");

                _TransactionOTPToken = OTPClient.GenerateOTP(6);
                var message = string.Format("Your 6-digit security code is {0}. Don't share this code whit anyone", _TransactionOTPToken);

                //_SMSClient.SendMessage(message, _CUSTOMER_IN_ACTION.PhoneNumber);
                this.transferOTPTF.Text = _TransactionOTPToken; //Eliminar luego
                transferOTPPanel.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ResetTransferForm()
        {
            this.transferFromTF.Text = "";
            this.transferToTF.Text = "";
            this.transferAmountTF.Text = "";
            this.transferTypeTF.Text = "";
        }
    }
}
