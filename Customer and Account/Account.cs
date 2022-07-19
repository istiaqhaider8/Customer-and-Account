using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_and_Account
{
    public class Account
    {
        private double balance;
        public string AccountNo {get; set;}
        public string OpeningDate { get; set; }

        public double Balance
        {
            get { return balance; }
        }
       
        public Account()
        {
            balance = 0;
        }

        public Account (string accountNo, string openingData):this()
        {
            this.AccountNo = accountNo;
            this.OpeningDate = openingData;
        }

        public bool Deposit(double amount)
        {
            balance = balance + amount;
            return true;
        }

        public bool Withdraw(double amount)
        {
            balance = balance - amount;
            return true;
        }
    }
}
