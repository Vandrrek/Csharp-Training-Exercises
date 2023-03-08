using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.AbstractClasses
{
    public class SavingsAccount : Account
    {
        public override void Display()
        {
            Console.WriteLine("Savings Account Info...");
        }

        public override void WithDraw(double amount)
        {
            Console.WriteLine($"Savings Account Withdrawal for {amount} dollars");
        }
        public override void Deposit(double amount)
        {
            //amount = amount * 1.02;
            amount *= 1.02;
            Console.WriteLine($"Depositing {amount} dollars after earning interest...");
        }
    }
}