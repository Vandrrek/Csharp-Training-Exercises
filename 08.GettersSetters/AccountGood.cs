using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.GettersSetters
{
    public class AccountGood
    {
        private const double minimumbalance = 100.00;
        private string name;
        private double balance;

        public AccountGood(string name, double balance)
        {
            this.name = name;
            this.balance = balance;
        }

        public static double Minimumbalance => minimumbalance;

        public string Name
        {
            get => name;
            set => name = value;
        }

        public double Balance
        {
            get => balance;
            set => balance = value;
        }
    }
}
