using System;
/*
 * TO DO:
      1-  operations: +, -, *, / , %
      2- use an option menu switch case
      3- loop
 * */
namespace ConsoleCalculator
{ // begin

    //1>CSC : error CS5001: Program does not contain a static 'Main' method suitable for an entry point
    //     //entry point of the application
    //           void Main(string[] args)ram
     //        {}
    public  class Program
    {
        //entry point of the application
        static  void Main(string[] args)
        {//begin

            //Declaration
            string input;
            int number1, number2, sum ,mult;

            Console.WriteLine("\n\n \t Calculator - Version 01 \n\n");

            Console.WriteLine("\n Input the first integer number:  ");
            input = Console.ReadLine();       //   | '1' | '2' | '3' |
            number1 = Convert.ToInt32(input);

            Console.WriteLine("\n Input the second integer number:  ");
            input = Console.ReadLine();       //   | '2' | '2' | '3' |
            number2 = Convert.ToInt32(input);

            sum = number1 + number2;
            mult = number1 * number2;

            Console.WriteLine(  "\n\n \t\t "  + number1 +  " + "  +  number2 +  " = "  + sum);
            Console.WriteLine(  "\n\n \t\t "  + number1 +  " * "  +  number2 +  " = "  + mult);


            Console.WriteLine("\n\n \t Type any key to end the application \n\n");
            Console.ReadKey();
        }//end
    }
}//end
