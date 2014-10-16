using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32;

namespace Bank
{
    class Withdrawal: ITransaction
    {
        public DateTime Time { get; private set; }
        public double Amount { get; private set; }
        public string Description { get; set; }

        public Withdrawal(DateTime time, double amount, string description)
        {
            Time = Time;
            Amount = amount;
            Description = description;
        }
    }
}
