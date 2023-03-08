using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.MultipleInheritance
{
    public class FlexibleSavingsAccount : SavingsAccount
    {
        public void PayHealthCareCost()
        {
            Console.WriteLine("Paying Health Care Costs...");
        }
    }
}
