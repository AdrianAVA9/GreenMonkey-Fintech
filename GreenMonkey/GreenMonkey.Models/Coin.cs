using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenMonkey.Models
{
    public class Coin : BaseEntity
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string FintechCode { get; set; }
        public Suscriptor Fintech { get;set;}
    }
}
