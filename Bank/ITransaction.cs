using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bank
{
    public interface ITransaction
    {
        DateTime Time { get; }
        Double Amount { get; }
        string Description { get; set; }
    }
}
