using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenMonkey.Dtos
{
    public class FintechStatusDto
    {
        public SuscriptorDto Suscriptor { get; set; }
        public string Status { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
