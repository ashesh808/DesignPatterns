using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMath
{
    public interface MathOperations
    {
        public int add(int num1, int num2);
        public int sub(int num1, int num2);
        public int multiply(int num1, int num2);
        public int divide(int num1, int num2);
    }
}
