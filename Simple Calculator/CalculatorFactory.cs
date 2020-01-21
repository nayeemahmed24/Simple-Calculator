using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class CalculatorFactory<T> : IFactory<T>
    {
        private ICalculate<T> Operation;
        public ICalculate<T> GetCalculate(string Operator)
        {
            if (Operator == "+")
                Operation = new Add<T>();
            else if (Operator == "-")
                Operation = new Subtract<T>();
            else if (Operator == "*")
                Operation = new Multiply<T>();
            else if (Operator == "/")
                Operation = new Devide<T>();
            return Operation;
        }
    }
}
