using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bank
{
    class User
    {
        public Guid ID { get; private set; }
        public String userName { get; private set; }
        public List<IAccount> Accounts;
        private String password;
    }
}
