using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal value = 0;
        checkPoint: //GoTo checkPoint
            Console.Write("Enter Temperature in decimal format: ");
            try
            {
                value = Convert.ToDecimal(Console.ReadLine());

                switch (value)
                {
                    case decimal t when (t < 0):
                        Console.WriteLine("Freezing Weather...!");
                        break;
                    case decimal t when (t < 10):
                        Console.WriteLine("Very Cold Weather...!");
                        break;
                    case decimal t when (t < 20):
                        Console.WriteLine("Cold Weather...!");
                        break;
                    case decimal t when (t < 30):
                        Console.WriteLine("Normal in Temp...!");
                        break;
                    case decimal t when (t <= 40):
                        Console.WriteLine("its Hot...!");
                        break;
                    case decimal t when (t > 40):
                        Console.WriteLine("its Very Hot...!");
                        break;
                    default:
                        Console.WriteLine("Please Enter correct temperature value");
                        break;

                }

            }
            catch (System.Exception)
            {
                Console.WriteLine("Alert! Please Input correct Temperature value in decimal Format");
                goto checkPoint;
            }
        }
    }
}
     
