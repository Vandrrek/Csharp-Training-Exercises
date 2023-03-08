using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.EncapsulateLogic
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

        public string AccountLevel
        {
            get
            {
                return this.DisplayAccountLevel();
            }
        }

        private string DisplayAccountLevel()
        {
            if (this.balance < 300.00)
            {
                return "Silver account";
            }
            else if (this.balance < 500.00)
            {
                return "Gold account";
            }
            else
            {
                return "Platinum account";
            }
        }
    }
}
