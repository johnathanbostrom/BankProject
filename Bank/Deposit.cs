using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bank
{
    class Deposit : ITransaction
    {
        public DateTime Time { get; private set; }
        public double Amount { get; private set; }
        public string Description { get; set; }

        public Deposit(DateTime time, double amount, string description)
        {
            Time = time;
            Amount = amount;
            Description = description;
        }
    }
}
