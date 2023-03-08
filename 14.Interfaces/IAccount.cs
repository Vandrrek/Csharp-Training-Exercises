using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Interfaces
{
    public interface IAccount
    {
        double Balance { get; }
        void Display();
    }
}
