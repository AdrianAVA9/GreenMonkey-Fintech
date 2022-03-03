using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenMonkey.Dtos
{
    public class AccountDto
    {
        public string Number { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public string CustomerId { get; set; }
        public int CoinCode { get; set; }
        public DateTime RegisteredAt { get; set; }
    }
}
