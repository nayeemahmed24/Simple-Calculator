using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            
            CalculatorFactory<ComplexNumber> c = new CalculatorFactory<ComplexNumber>();
            ICalculate<ComplexNumber> aa = c.GetCalculate("+");
            Console.WriteLine(
            aa.Operation(new ComplexNumber(1,2), new ComplexNumber(2,3)).input1
            );

            CalculatorFactory<RealNumber> cr= new CalculatorFactory<RealNumber>();
            ICalculate<RealNumber> aar = cr.GetCalculate("+");
            Console.WriteLine(
                aar.Operation(new RealNumber(1), new RealNumber(3)).input1
            );
        }
    }
}
