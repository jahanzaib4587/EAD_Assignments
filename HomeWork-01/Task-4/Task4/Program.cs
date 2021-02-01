using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal swap = 0, value1 = 0, value2 = 0;

            Console.WriteLine("Enter first number");
        Check1:
            try
            {
                value1 = decimal.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter a valid number");
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
                Console.WriteLine("Please enter a valid number");
                goto check2;

            }
            Swapping(value1, value2);
            void Swapping(decimal val1, decimal val2)
            {
                swap = val1;
                val1 = val2;
                val2 = swap;
                Console.WriteLine($"Value-1={val1} & value-2={val2}");
            }
        }
    }
}
