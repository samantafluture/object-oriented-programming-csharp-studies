using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * TO DO:
      1-  implementing methodes for the folloeing operations: +, -, *, / , %
      2-  use an option menu and switch case
      3-  loop
 * */
namespace CalculatorConsole_V2
{
    class Program
    {
        //Module 01
        static int add(int x , int y)
        {
            int sum;//local variable - automatic variable
            sum = x + y;
            return sum;
        }

        static int mult( int x,  int y)
        {
            int result;//local variable - automatic variable
            result = x * y;
            return result;
        }


        //Main process (entry point of the application)
        static void Main(string[] args)
        {
            //Declaration
            string input;
            int number1, number2, sum, multiplication;

            Console.WriteLine("\n\n \t Calculator - Version 02 \n\n");

            Console.WriteLine("\n Input the first integer number:  ");
            input = Console.ReadLine();       //   | '1' | '2' | '3' |
            number1 = Convert.ToInt32(input);

            Console.WriteLine("\n Input the second integer number:  ");
            input = Console.ReadLine();       //   | '2' | '2' | '3' |
            number2 = Convert.ToInt32(input);

           /////// sum = number1 + number2;
             //function call:
             sum = add(number1, number2);

            multiplication = mult(number1, number2);

            Console.WriteLine("\n\n \t\t " + number1 + " + " + number2 + " = " + sum);

            Console.WriteLine("\n\n \t\t " + number1 + " * " + number2 + " = " + multiplication);


            Console.WriteLine("\n\n \t Type any key to end the application \n\n");
            Console.ReadKey();
        }
    }
}
