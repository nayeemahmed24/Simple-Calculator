using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator 
{
    public struct RealNumber : IOperator
    {
        public double realNumber { get; private set; }

        public RealNumber(double realNumber)
        {
            this.realNumber = realNumber;
        }

        public static RealNumber operator +(RealNumber b, RealNumber c)
        {
            RealNumber realNumberValue = new RealNumber();
            realNumberValue.realNumber = b.realNumber + c.realNumber;
            
            return realNumberValue;
        }


    }
}
