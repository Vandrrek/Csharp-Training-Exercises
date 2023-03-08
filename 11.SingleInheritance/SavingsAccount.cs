using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.SingleInheritance
{
    public class SavingsAccount : Account
    {
        public void GetInterestEarned()
        {
            Console.WriteLine("Getting Interest Earned...");
        }
    }
}
