﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.IntefacesIs
{
    public class SavingsAccount : Account, IAccount
    {
        public void Display()
        {
            Console.WriteLine("Displaying Savings Account Info...");
        }
    }
}
