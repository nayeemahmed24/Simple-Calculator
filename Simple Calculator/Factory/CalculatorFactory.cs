using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class CalculatorFactory<T> : IFactory<T> where T : IOperator
    {
        private ICalculate<T> Operation;
        public ICalculate<T> GetCalculate(string Operator)
        {
            switch (Operator)
            {
                case "+":
                    Operation = new Add<T>();
                    break;
                case "-":
                    Operation = new Subtract<T>();
                    break;
                case "*":
                    Operation = new Multiply<T>();
                    break;
                case "/":
                    Operation = new Divide<T>();
                    break;
            }

            return Operation;
        }
    }
}
