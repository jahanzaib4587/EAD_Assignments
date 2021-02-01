using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double value = 0.0;
        check1:
            Console.WriteLine("Enter Floating point value");
            try
            {
                value = Convert.ToDouble(Console.ReadLine());
            }
            catch (System.Exception)
            {
                Console.WriteLine("Enter valid floating point value");
                goto check1;

            }
            Console.WriteLine("**********Banker's Algorithm**********");
            BnakersAlgo(value);
            Console.WriteLine("**********Traditional Way*************");
            traditionalRounding(value);
            void BnakersAlgo(double val)
            {
                Console.WriteLine($"{System.Convert.ToInt32(val)}");
            }
            void traditionalRounding(double val)
            {
                Console.WriteLine(Math.Round(value: val, digits: 0,
               mode: MidpointRounding.AwayFromZero));
            }
        }
    }
}
