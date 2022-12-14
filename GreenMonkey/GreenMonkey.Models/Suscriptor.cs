using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenMonkey.Models
{
    public class Suscriptor : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Owner { get; set; }
        public string BaseUrl { get; set; }
        public string Code { get; set; }
        public string Active { get; set; }
        public List<SuscriptorStatus> StatusList { get; set; }
    }
}
