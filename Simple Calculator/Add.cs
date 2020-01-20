using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Calculator
{
    class Add : ICalculate
    {
        public double add(double input, double result)
        {
            return input + result;
        }
    }
}
