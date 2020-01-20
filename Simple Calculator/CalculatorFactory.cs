using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
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

            double TempReslt =  add.Operation(input, Result);
            Result = TempReslt;
            return TempReslt;

        }

        public double Divide( double input)
        {
            double TempReslt = devide.Operation(input, Result);
            Result = TempReslt;
            return TempReslt;
        }

        public double Multiply( double input)
        {
            double TempReslt = multiply.Operation(input, Result);
            Result = TempReslt;
            return TempReslt;
        }

        public double Subtract( double input)
        {

            double TempReslt = subtact.Operation(input, Result);
            Result = TempReslt;
            return TempReslt;
        }
    }
}
