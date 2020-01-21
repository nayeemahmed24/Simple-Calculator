using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Calculator
{
    public class CalculatorFactory : IFactory
    {
        //public double Result { get; private set; }

        public ICalculate Operation;


        public ICalculate GetCalculate(string Operator)
        {
            if (Operator == "+")
                Operation = new Add();
            else if (Operator == "-")
                Operation = new Subtract();
            else if (Operator == "*")
                Operation = new Multiply();
            else if (Operator == "/")
                Operation = new Devide();
            return Operation;
        }
    }


}
