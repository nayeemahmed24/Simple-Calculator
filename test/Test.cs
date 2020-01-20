using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using SimpleCalculator;

namespace test
{
    [TestFixture]
    class Test
    {
        [TestCase]
        public void Add()
        {
            CalculatorFactory c = new CalculatorFactory();
            Assert.AreEqual(3.1,c.Add(3.1));            
        }


    }
}
