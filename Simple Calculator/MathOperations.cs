using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    interface IMathOperations
    {
        double Add( double input);
        double Subtract( double input);
        double Divide( double input);
        double Multiply( double input);

    }
}
