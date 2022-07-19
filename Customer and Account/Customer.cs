using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_and_Account
{
    public class Customer
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public Account Account { get; set; }

        public Customer()
        {
            Account = new Account();
        }

        public Customer(string name, string email):this()
        {
            this.Name = name;
            this.Email = email;
        }

        public Customer(string name, string email, Account account):this(name,email)
        {
            this.Account = account;
        }

    }
}
