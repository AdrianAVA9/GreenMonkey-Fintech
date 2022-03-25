using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace GreenMonkey.Utils
{
    public class SMSClient
    {
        public string Token { get; set; }
        public string AccountId { get; set; }
        public string PhoneNumber { get; set; }
        public SMSClient(string token, string accountId, string phoneNumber)
        {
            Token = token;
            AccountId = accountId;
            PhoneNumber = phoneNumber;
        }

        public void SendMessage(string message, string phoneNumber)
        {
            TwilioClient.Init(AccountId, Token);

            if(!phoneNumber.StartsWith("+"))
                phoneNumber = "+" + phoneNumber;

            var messageResource = MessageResource.Create(
                body: message,
                from: new PhoneNumber(PhoneNumber),
                to: new PhoneNumber(phoneNumber)
              );

            var result = messageResource.DateSent;
        }
    }
}
