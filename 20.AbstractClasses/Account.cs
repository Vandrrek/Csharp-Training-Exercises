using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.AbstractClasses
{
    public abstract class Account
    {
        public abstract void Display();

        public abstract void WithDraw(double amount);

        public virtual void Deposit(double amount)
        {
            Console.WriteLine($"Depositing {amount} dollars into Account...");
        }
    }
}
