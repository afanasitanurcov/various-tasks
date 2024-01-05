using System;

namespace _04.BlackFlag
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int moneyPerDay = int.Parse(Console.ReadLine());
            double expectedMoney = double.Parse(Console.ReadLine());
            double sum = 0;
            for (int i = 1; i <= days; i++)
            {
                if (i % 3 == 0)
                {
                    sum += moneyPerDay * 1.5;
                    if (i % 5 == 0)
                    {
                        sum = sum * 0.7;
                    }
                    continue;

                }
                sum += moneyPerDay;

                if (i % 5 == 0)
                {
                    sum = sum * 0.7;
                }
            }
            if (sum >= expectedMoney)
            {
                Console.WriteLine($"Ahoy! {sum:f2} plunder gained.");
            }
            else
            {
                double procent = sum / expectedMoney * 100;
                Console.WriteLine($"Collected only {procent:f2}% of the plunder.");
            }
        }
    }
}
