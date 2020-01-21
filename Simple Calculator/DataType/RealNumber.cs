using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    struct RealNumber
    {
        public double input1;

        public RealNumber(double input1)
        {
            this.input1 = input1;
        }

        public static RealNumber operator +(RealNumber b, RealNumber c)
        {
            RealNumber realNumberValue = new RealNumber();
            realNumberValue.input1 = b.input1 + c.input1;
            
            return realNumberValue;
        }


    }
}
