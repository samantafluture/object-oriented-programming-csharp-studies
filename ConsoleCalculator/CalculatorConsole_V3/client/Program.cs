using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CalculatorConsole_V3.bus;

namespace CalculatorConsole_V3
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1, number2, sum, mult;
            number1 = 11;
            number2 = 33;


            Console.WriteLine("\n\n \t Calculator - Version 03 \n\n");
            //sum = CalculatorConsole_V3.bus.Calculator.add(number1, number2);

            sum = Calculator.add(number1, number2);
            mult = Calculator.mult(number1, number2);

           

            Console.WriteLine("\n\n \t\t " + number1 + " + " + number2 + " = " + sum);

            Console.WriteLine("\n\n \t\t " + number1 + " * " + number2 + " = " + mult);


            Console.WriteLine("\n\n \t Type any key to end the application \n\n");

            Console.ReadKey();
        }
    }
}
