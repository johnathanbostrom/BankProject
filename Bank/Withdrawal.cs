using System;

namespace Bank
{
    [Serializable]
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

        public override string ToString()
        {
            return "Withdrawal: $" + Amount + " at " + Time;
        }
    }
}
