using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int monthlyWage = 6000;
            int months = 6;

            //CalcualteYearlyWage(monthlyWage, months);
            int yearlyWage = CalcualteYearlyWage(monthlyWage, months);
            CalculateAverageWage(1, 3, 5, 7);
            CalculateAverageWage(1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 1, 2, 3, 4, 5, 1235, 3245, 13, 4231, 43, 123, 1);

            Console.ReadLine();
        }

        public static int CalcualteYearlyWage(int monthlyWage, int numberOfMonthsWorked)
        {
            //Console.WriteLine($"Yearly wage: {monthlyWage * numberOfMonthsWorked}");
            if (numberOfMonthsWorked == 12)
            {
                return monthlyWage * (numberOfMonthsWorked + 1);
            }

            return monthlyWage * numberOfMonthsWorked;
        }
        private static int CalculateAverageWage(params int[] wages)
        {
            int total = 0;
            int numberOfWages = wages.Length;

            for (int i = 0; i < numberOfWages; i++)
            {
                total += wages[i];
            }

            Console.WriteLine(total / numberOfWages);
            return total / numberOfWages;
        }
    }
}
 