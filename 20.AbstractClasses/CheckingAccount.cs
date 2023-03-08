using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.AbstractClasses
{
    public class CheckingAccount : Account
    {
        public override void Display()
        {
            Console.WriteLine("Checking Account Info...");
        }

        public override void WithDraw(double amount)
        {
            Console.WriteLine($"Checking Account Withdrawal for {amount} dollars");
        }
        public override void Deposit(double amount)
        {
            Console.WriteLine($"Depositing {amount} dollars into Account...");
        }
    }
}
