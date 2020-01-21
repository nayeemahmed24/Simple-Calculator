using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    struct ComplexNumber
    {
        public double input1, input2;

        public ComplexNumber(int a, int b)
        {
            input1 = a;
            input2 = b;
        }

        public static ComplexNumber operator +(ComplexNumber b, ComplexNumber c)
        {
            ComplexNumber complexNumberValue = new ComplexNumber();
            complexNumberValue.input1 = b.input1 + c.input1;
            complexNumberValue.input2 = b.input2 + c.input2;

            return complexNumberValue;
        }
    }
}
