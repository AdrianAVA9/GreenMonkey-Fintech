using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenMonkey.Models
{
    public class Customer : BaseEntity
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Nickname { get; set; }
        public string Status { get; set; }
        public DateTime Birthdate { get; set; }
        public int Age {
            get {
                return DateTime.Today.Year - Birthdate.Year;
            }
        }
        public string Fullname { 
            get { 
                return Name + " " + LastName;
            } 
        }

        public DateTime RegisteredAt { get; set; }
    }
}
