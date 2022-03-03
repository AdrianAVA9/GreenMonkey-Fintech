﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenMonkey.Dtos
{
    public class TransactionDto
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public string Type { get; set; }
        public string AccountNumber { get; set; }
        public DateTime RegisteredAt { get; set; }
    }
}