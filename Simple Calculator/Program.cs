using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculatorFactory c = new CalculatorFactory();
            ICalculate temp = c.GetCalculate("-");
            Console.WriteLine(
                temp.operation(10, 4));
        }
    }
}
