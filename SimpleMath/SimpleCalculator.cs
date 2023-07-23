using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMath
{
    internal class SimpleCalculator : Calculator
    {
        public SimpleCalculator(MathOperations MathOperation) : base(MathOperation)
        {
        }
    
        public override int add(int num1, int num2)
        {
            return base._MathOperations.add(num1, num2);
        }

        public override int sub(int num1, int num2)
        {
            return base._MathOperations.sub(num1, num2);
        }

        public override int divide(int num1, int num2)
        {
            return base._MathOperations.divide(num1, num2);
        }

        public override int multiply(int num1, int num2)
        {
            return base._MathOperations.multiply(num1, num2);
        }
    }
}
