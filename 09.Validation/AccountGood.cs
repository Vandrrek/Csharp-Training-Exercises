using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Validation
{
    public class AccountGood
    {
        private const double minimumbalance = 100.00;
        private string name;
        private double balance;

        public AccountGood(string name, double balance)
        {
            this.Name = name;
            this.Balance = balance;
        }


        public string Name
        {
            get => name;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Account name cannot be empty!");
                }
                this.name = value;
            }
        }

        public double Balance
        {
            get => balance;
            set
            {
                if (value < minimumbalance)
                {
                    throw new Exception($"Account must have a min balance of {minimumbalance} dollars");
                }
                this.balance = value;
            }
        }
    }
}
