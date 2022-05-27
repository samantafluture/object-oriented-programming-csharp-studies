using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsSimpleCalculator
{
    internal class Calculator
    {
        public static int add(int x, int y)
        {
            return x + y;
        }

        public static int subtract(int x, int y)
        {
            return x - y;
        }

        public static int multiply(int x, int y)
        {
            return x * y;
        }

        public static int divide(int x, int y)
        {
            return x / y;
        }

        public static int modulos(int x, int y)
        {
            return x % y;
        }
    }
}
