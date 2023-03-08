using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.InterfacesAsReturn
{
    public class AutoAccount : Account, ITransferable
    {
        public void Transfer()
        {
            Console.WriteLine("Auto Transfer Completed...");
        }
    }
}
