using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.EncapsulateFields
{
    public class AccountBad
    {
        public double minimumbalance = 100.00;
        public string name;
        public double balance;

        public AccountBad(string name, double balance)
        {
            this.name = name;
            this.balance = balance;
        }
    }
}
