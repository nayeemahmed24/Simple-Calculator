using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    struct VectorObject : IOperator
    {
        public double X { get; private set; }
        public double Y { get; private set; }
        public double Z { get; private set; }
        public VectorObject(double x, double y,double z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        public static VectorObject operator +(VectorObject b, VectorObject c)
        {
            VectorObject vectorObject = new VectorObject();
            vectorObject.X = b.X + c.X;
            vectorObject.Y = b.Y + c.Y;
            vectorObject.Z = b.Z + c.Z;
            return vectorObject;
        }
        public static VectorObject operator *(VectorObject b, VectorObject c)
        {
            VectorObject vectorObject = new VectorObject();
            vectorObject.X = (b.Y * c.Z ) - (b.Z * c.Y) ;
            vectorObject.Y = (b.X * c.Z) - (b.Z * c.X);
            vectorObject.Z = (b.X * c.Y) - (b.Y * c.X);
            return vectorObject;

        }
        public static VectorObject operator -(VectorObject b, VectorObject c)
        {
            VectorObject vectorObject = new VectorObject();
            vectorObject.X = b.X - c.X;
            vectorObject.Y = b.Y - c.Y;
            vectorObject.Z = b.Z - c.Z;
            return vectorObject;
        }
    }
}
