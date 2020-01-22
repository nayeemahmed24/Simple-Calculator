using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
     struct ComplexNumber :IOperator 
    {
        public double realNumber { get; private set ; }
        public double imaginaryNumber { get; private set; }


        public ComplexNumber(double a, double b)
        {
            realNumber = a;
            imaginaryNumber = b;
        }

        public static ComplexNumber operator +(ComplexNumber b, ComplexNumber c)
        {
            ComplexNumber complexNumberValue = new ComplexNumber();
            complexNumberValue.realNumber = b.realNumber + c.realNumber;
            complexNumberValue.imaginaryNumber = b.imaginaryNumber + c.imaginaryNumber;

            return complexNumberValue;
        }
        public static ComplexNumber operator -(ComplexNumber b, ComplexNumber c)
        {
            ComplexNumber complexNumberValue = new ComplexNumber();
            complexNumberValue.realNumber = b.realNumber - c.realNumber;
            complexNumberValue.imaginaryNumber = b.imaginaryNumber - c.imaginaryNumber;

            return complexNumberValue;
        }
        public static ComplexNumber operator *(ComplexNumber b, ComplexNumber c)
        {
            ComplexNumber complexNumberValue = new ComplexNumber();
            complexNumberValue.realNumber = b.realNumber * c.realNumber;
            complexNumberValue.imaginaryNumber = b.imaginaryNumber * c.imaginaryNumber;

            return complexNumberValue;
        }
        public static ComplexNumber operator /(ComplexNumber b, ComplexNumber c)
        {
            ComplexNumber complexNumberValue = new ComplexNumber();
            complexNumberValue.realNumber = b.realNumber / c.realNumber;
            complexNumberValue.imaginaryNumber = b.imaginaryNumber / c.imaginaryNumber;

            return complexNumberValue;
        }

    }
}
