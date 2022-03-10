using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenMonkey.Models
{
    public class Account : BaseEntity
    {
        public string Number { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public string CustomerId { get; set; }
        public int CoinCode { get; set; }
        public decimal Amount { get; set; }
        public string FormattedAmount {
            get { 
                return string.Format("{0}${1}", Amount > 0 ? "" : "-",
                    Amount == 0 ? 0 : Math.Round(Math.Abs(Amount), 2, MidpointRounding.AwayFromZero));
            }
        }
        public DateTime RegisteredAt { get; set; }
    }
}
