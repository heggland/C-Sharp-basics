using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_exercises
{
    internal class Delegates
    {
        public delegate float OperationDelegate(float a, float b);

        public static float Add(float a, float b)
        {
            return a + b;
        }

        public static float Subtract(float a, float b)
        {
            return a - b;
        }


        public static float Multiply(float a, float b)
        {
            return a * b;
        }

        public static float Divide(float a, float b)
        {
            return a / b;
        }

        public static float ApplyOperation(float a, float b, OperationDelegate oper)
        {
            float result;

            result = oper(a, b);

            return result;
        }
    }
}
