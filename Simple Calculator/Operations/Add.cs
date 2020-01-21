using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class Add<T> : ICalculate<T>
    {
        public T Operation(T input, T result)
        {
            dynamic inp = (dynamic) input + (dynamic) result;
            return inp;
        }

    }
}
