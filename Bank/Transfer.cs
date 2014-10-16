using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Bank
{
    class Transfer: ITransaction
    {
        public DateTime Time { get; private set; }
        public double Amount { get; private set; }
        public string Description { get; set; }
        public Guid From;
        public Guid To;

        public Transfer(DateTime time, double amount, Guid from, Guid to, string description)
        {
            Time = time;
            Amount = amount;
            Description = description;
            From = from;
            To = to;
        }
    }
}
