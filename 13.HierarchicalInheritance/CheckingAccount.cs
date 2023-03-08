using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.HierarchicalInheritance
{
    public class CheckingAccount : Account
    {
        public void Withdraw()
        {
            Console.WriteLine("Withdrawing Money...");
        }
    }
}
