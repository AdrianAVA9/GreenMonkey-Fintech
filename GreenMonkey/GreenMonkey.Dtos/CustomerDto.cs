using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenMonkey.Dtos
{
    public class CustomerDto
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Nickname { get; set; }
        public string Status { get; set; }
        public DateTime Birthdate { get; set; }
        public int Age { get; set; }
        public DateTime RegisteredAt { get; set; }
    }
}
