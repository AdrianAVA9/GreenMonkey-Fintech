using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenMonkey.Models
{
    public class ApplicationMessage : BaseEntity  
    {
        public int Id { get; set; }
        public string Message { get; set; }   

    }
}
