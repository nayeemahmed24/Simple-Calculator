﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory f = new Factory();
            Console.WriteLine(f.Add(7));
            Console.WriteLine(f.Subtract(3));
        }
    }
}
