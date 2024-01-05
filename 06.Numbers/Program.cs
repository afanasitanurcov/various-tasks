using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(" ").Select(int.Parse).OrderByDescending(x => x).ToList();

            List<int> result = new List<int>();

            double sum = list.Sum();
            double averageValue = sum / list.Count;

            for (int i = 0; i < list.Count; i++)
            {
                if (averageValue < list[i])
                {
                    result.Add(list[i]);

                    if (result.Count == 5) break;
                }

            }
            if (result.Count == 0) Console.WriteLine("No");
            else Console.WriteLine(string.Join(" ", result));

        }
    }
}
