using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public abstract class Overload<T> where T : Overload<T>
    {
        public static T operator +(Overload<T> a, T b) => a.Add(b);

        public abstract T Add(T another);
           
    }
}
