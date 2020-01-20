using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class Subtract : ICalculate
    {
        public double Operation(double input, double result)
        {
            return result - input;   
        }
    }
}
