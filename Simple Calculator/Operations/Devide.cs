﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class Devide<T> : ICalculate<T> where T : IOperator
    {
        

        public T Operation(T input, T result)
        {
            return (dynamic) ((dynamic) input / (dynamic) result);
        }
    }
}
