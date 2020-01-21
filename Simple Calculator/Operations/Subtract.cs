using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Calculator
{
    class Subtract : ICalculate
    {
        public double operation(double input1, double input2)
        {
            return input1 - input2;   
        }
    }
}
