using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal Answer = 0, value1 = 0, value2 = 0;
            char Operator;
            Console.WriteLine("Enter first number");
        Check1:
            try
            {
                value1 = decimal.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter a valid value");
                goto Check1;

            }
            Console.WriteLine("Enter Second number");
        check2:
            try
            {
                value2 = decimal.Parse(Console.ReadLine());
            }
            catch (System.Exception)
            {
                Console.WriteLine("Please enter a valid value");
                goto check2;

            }
            Console.WriteLine("Enter Operatortion which you want to perform!{+ , - , * , /, Quit: q}");

        check3:
            try
            {
                Operator = Convert.ToChar(Console.ReadLine());
            }
            catch (System.Exception)
            {
                Console.WriteLine("Please enter a valid Operator");
                goto check3;

            }
            switch (Operator)
            {
                //Addition
                case char c when (c == '+'):
                    Answer = value1 + value2;
                    Console.WriteLine($"Result of {value1} + {value2} is {Answer}");
                    break;
                //Subtraction
                case char c when (c == '-'):
                    Answer = value1 - value2;
                    Console.WriteLine($"Result of {value1} - {value2} is {Answer}");
                    break;
                //Multiplication
                case char c when (c == '*'):
                    Answer = value1 * value2;
                    Console.WriteLine($"Result of {value1} * {value2} is {Answer}");
                    break;
                //Division
                case char c when (c == '/'):
                    division(value1, value2);
                    break;
                //Modolus
                case char c when (c == '%'):
                    Answer = value1 % value2;
                    Console.WriteLine($"Result of {value1} % {value2} is {Answer}");
                    break;
                //Quit
                case 'q':
                    break;
                default:
                    Console.WriteLine("Please Choose right option or enter \"q\" to quit");
                    goto check3;

            }
            void division(decimal a, decimal b)
            {

                if (b == 0)
                {
                    Console.WriteLine("Division by Zero is not possible");
                    return;

                }
                else
                {
                    Answer = a / b;
                    Console.WriteLine($"Result of {value1} / {value2} is {Answer}");
                }


            }
        }

    }
}
   
