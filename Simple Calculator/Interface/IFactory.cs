using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Simple_Calculator;

namespace Simple_Calculator
{
    interface IFactory
    {
        ICalculate GetCalculate(string Operator);
    }
}
