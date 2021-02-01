using System;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int subjects = 0;
        check1:
            Console.WriteLine("Enter number of subjects");
            try
            {
                subjects = Convert.ToInt32(Console.ReadLine());
            }
            catch (System.Exception)
            {
                Console.WriteLine("Enter valid number of subjects");
                goto check1;
            }
            decimal[] grades = new decimal[subjects];
            for (int i = 0; i < subjects; i++)
            {
            check2:
                Console.WriteLine($"Enter marks of your {i + 1} subject");
                try
                {
                    grades[i] = Convert.ToDecimal(Console.ReadLine());

                }
                catch (Exception)
                {
                    Console.WriteLine("Enter valid marks of subject");
                    goto check2;
                }

            }
            GPACalculator(grades, subjects);
        }
        static void GPACalculator(decimal[] grades, int CountOfSubjects)
        {
            int CreditHours = 3;
            double gradesPoint = 0;
            double totalMarks = 0;
            double grandTotal = 0;
            double result = 0;
            for (int i = 0; i < CountOfSubjects; i++)
            {

                if (grades[i] < 50)
                {
                    gradesPoint = 0;
                }
                else if (grades[i] >= 50 && grades[i] < 55)
                {
                    gradesPoint = 1.00;
                }
                else if (grades[i] >= 55 && grades[i] < 58)
                {
                    gradesPoint = 1.70;
                }
                else if (grades[i] >= 58 && grades[i] < 61)
                {
                    gradesPoint = 2.00;
                }
                else if (grades[i] >= 61 && grades[i] < 65)
                {
                    gradesPoint = 2.30;
                }
                else if (grades[i] >= 65 && grades[i] < 70)
                {
                    gradesPoint = 2.70;
                }
                else if (grades[i] >= 70 && grades[i] < 75)
                {
                    gradesPoint = 3.00;
                }
                else if (grades[i] >= 75 && grades[i] < 80)
                {
                    gradesPoint = 3.30;
                }
                else if (grades[i] >= 80 && grades[i] < 85)
                {
                    gradesPoint = 3.7;
                }
                else if (grades[i] >= 85)
                {
                    gradesPoint = 4.00;
                }
                else
                {
                    Console.Write("You entered invalid value");

                }
                totalMarks = Convert.ToDouble(gradesPoint * CreditHours);
                grandTotal = grandTotal + totalMarks;

            }
            int totalCreditHours = CreditHours * CountOfSubjects;
            result = grandTotal / totalCreditHours;
            Console.WriteLine($"Your GPA is:{Math.Round(result,2, mode: MidpointRounding.AwayFromZero)} ");

        }

    }
}
    
