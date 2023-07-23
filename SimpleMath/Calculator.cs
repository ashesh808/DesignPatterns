using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMath
{
    internal class Calculator
    {
        protected MathOperations _MathOperations;

        public Calculator(MathOperations MathOperations)
        {
            this._MathOperations = MathOperations;
        }

        public virtual int add( int num1, int num2)
        {
            return _MathOperations.add(num1,num2);
        }

        public virtual int sub(int num1, int num2)
        {
            return _MathOperations.sub(num1, num2);
        }

        public virtual int divide(int num1, int num2)
        {
            return _MathOperations.divide(num1, num2);
        }

        public virtual int multiply(int num1, int num2)
        {
            return _MathOperations.multiply(num1, num2);
        }
    }
}
