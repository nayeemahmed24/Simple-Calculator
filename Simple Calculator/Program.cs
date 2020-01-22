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
            
            CalculatorFactory<VectorObject> c = new CalculatorFactory<VectorObject>();
            ICalculate<VectorObject> aa = c.GetCalculate("+");
            Console.WriteLine(
            aa.Operation(new VectorObject(1,2,3), new VectorObject(2,3,4)).X
            );

            //CalculatorFactory<RealNumber> cr = new CalculatorFactory<RealNumber>();
            //ICalculate<RealNumber> aar = cr.GetCalculate("+");
            //Console.WriteLine(
            //    aar.Operation(new RealNumber(1), new RealNumber(3)).input1
            //);
        }
    }
}
