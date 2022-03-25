using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenMonkey.Models
{
    public class Transaction : BaseEntity
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public string Type { get; set; }
        public string UBAN { get; set; }
        public int AcccountId { get; set; }
        public string FintechRequester { get; set; }
        public string Desc { get; set; }
        public DateTime RegisteredAt { get; set; }
        public string FintechCode
        {
            get
            {

                return UBAN.Substring(3, 4);
            }
        }
    }
}
