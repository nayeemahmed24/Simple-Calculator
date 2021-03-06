﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    interface IFactory<T> where T : IOperator
    {
        ICalculate<T> GetCalculate(string Operator);

    }
}
