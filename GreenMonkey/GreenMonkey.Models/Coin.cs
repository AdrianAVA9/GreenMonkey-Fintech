﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenMonkey.Models
{
    public class Coin : BaseEntity
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public string FintechCode { get; set; }
    }
}
