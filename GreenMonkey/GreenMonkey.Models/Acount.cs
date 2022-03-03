using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenMonkey.Models
{
    public class Account
    {
        public string Number { get; set; }
        public int Consecutive { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public DateTime RegisteredAt { get; set; }
    }
}
