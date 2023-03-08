using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Interfaces
{
    public class Account : IAccount
    {
        public double Balance
        {
            get
            {
                return 100.00;
            }
        }
        public void Display()
        {
            Console.WriteLine("Displaying Account Info...");
        }
    }
}
