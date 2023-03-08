using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.InterfacesAsReturn
{
    public class CheckingAccount : Account, IAccount, ITransferable
    {
        public void Display()
        {
            Console.WriteLine("Displaying Checking Account Info...");
        }

        public void Transfer()
        {
            Console.WriteLine("Checking Transfer Completed...");
        }
    }
}
