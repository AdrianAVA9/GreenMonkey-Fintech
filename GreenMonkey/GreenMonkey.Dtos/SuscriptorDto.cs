using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenMonkey.Dtos
{
    public class SuscriptorDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Owner { get; set; }
        public string BaseUrl { get; set; }
        public string Code { get; set; }
        public List<SuscriptorStatusDto> StatusList { get; set; }
    }
}
