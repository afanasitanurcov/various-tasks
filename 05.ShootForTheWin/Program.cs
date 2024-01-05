using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.ShootForTheWin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            int succesifullShoots = 0;

            for (int i = 0; i < list.Count; i++)
            {
                string shoot = Console.ReadLine();
                if (shoot == "End") break;

                int index = int.Parse(shoot);

                if (index >= 0 && index < list.Count)
                {
                    int currentTarget = list[index];

                    list[index] = -1;

                    for (int j = 0; j < list.Count; j++)
                    {
                        if (list[j] == -1) continue;

                        if (list[j] > currentTarget)
                        {
                            list[j] -= currentTarget;
                        }
                        else
                        {
                            list[j] += currentTarget;
                        }

                    }
                    succesifullShoots++;

                }


            }
            Console.WriteLine($"Shot targets: {succesifullShoots} -> " + (string.Join(" ", list)));
        }
    }
}
