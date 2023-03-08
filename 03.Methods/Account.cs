using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Methods
{
    public class Account
    {
        private string name;
        private double balance;

        public Account()
        {
            this.Name = "DefaultName";
            this.Balance = 0.00;
        }
        public Account(double balance) : this()
        {
            this.Balance = balance;
        }
        public Account(string name, double balance) : this(balance)
        {
            this.Name = name;
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public double Balance
        {
            get
            {
                return this.balance;
            }
            set
            {
                this.balance = value;
            }
        }
    }
}
