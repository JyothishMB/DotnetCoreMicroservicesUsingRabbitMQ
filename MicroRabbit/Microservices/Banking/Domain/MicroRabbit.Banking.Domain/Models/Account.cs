using System;
using System.Text;
using System.Collections.Generic;

namespace MicroRabbit.Banking.Domain.Models
{
    public class Account
    {
        public int Id { get; set; }
        public string AccountType { get; set; }
        public decimal AccountBalance { get; set; }
    }
}