using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Calculator
{
    public class CalculatorFactory : IMathOperations
    {
        public double Result { get; private set; }

        ICalculate add, subtact, multiply, devide;
        public CalculatorFactory()
        {
            this.add = new Add();
            this.subtact = new Subtract();
            this.multiply = new Multiply();
            this.devide = new Devide();
            Result = 0;
        }
        




        public double Add( double input)
        {

            double TempReslt =  add.operation(input, Result);
            Result = TempReslt;
            return TempReslt;

        }

        public double Divide( double input)
        {
            double TempReslt = devide.operation(input, Result);
            Result = TempReslt;
            return TempReslt;
        }

        public double Multiply( double input)
        {
            double TempReslt = multiply.operation(input, Result);
            Result = TempReslt;
            return TempReslt;
        }

        public double Subtract( double input)
        {
            double TempReslt = subtact.operation(input, Result);
            Result = TempReslt;
            return TempReslt;
        }
    }
}
