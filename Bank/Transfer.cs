using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Bank
{
    [Serializable]
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

        public override string ToString()
        {
            return "Transfer: $" + Amount + " from Account " + getSmallGuid(From) + " to Account " + getSmallGuid(To) +" on " + Time;
        }

        private string getSmallGuid(Guid guid)
        {
            string s = guid.ToString();
            return s.Substring(0, Math.Min(s.Length, 8));
        }
    }
}
