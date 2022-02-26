using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GreenMonkey.UI.Models
{
    public class Suscriptor
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Owner { get; set; }
        public string BaseUrl { get; set; }
        public string Code { get; set; }
        public List<SuscriptorStatus> StatusList { get; set; }
    }
}