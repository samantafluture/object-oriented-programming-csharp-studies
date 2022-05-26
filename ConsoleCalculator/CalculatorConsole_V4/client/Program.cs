
//using System;


//using CalculatorConsole_V4.bus;

namespace CalculatorConsole_V4.client
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 77, n2 = 55;
            int sum;

            sum = CalculatorConsole_V4.bus.Calculator.add(n1, n2);

            System.Console.WriteLine("\n Calculator V4 -----\n\n \t\tsum = "  + sum);

            System.Console.ReadKey();

        }
    }
}
