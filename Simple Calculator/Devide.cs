using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class Devide : ICalculate
    {
        public double Operation(double input, double result)
        {
            if(input == 0 && result == 0)
            {
                return 0;
            }else if(input == 0)
            {
                throw new ArithmeticException("Can not divide with number 0");
            }
            else
            {
                return result / input;
            }
        }
    }
}
