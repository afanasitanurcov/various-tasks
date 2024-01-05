using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.HeartDelivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> houses = Console.ReadLine().Split("@").Select(int.Parse).ToList();

            int landingIndex = 0;
            while (true)
            {
                int counterOfJumps = 0;
                List<string> command = Console.ReadLine().Split(" ").ToList();

                switch (command[0])
                {
                    case "Love!":

                        houses.RemoveAll(x => x == 0);

                        Console.WriteLine($"Cupid's last position was {landingIndex}.");

                        if (houses.Count == 0)
                        {
                            Console.WriteLine("Mission was successful.");
                        }
                        else
                        {
                            Console.WriteLine($"Cupid has failed {houses.Count} places.");
                        }
                        return;


                    case "Jump":

                        int jumpLength = int.Parse(command[1]);

                        for (int i = landingIndex + 1; i <= houses.Count && counterOfJumps < jumpLength; i++)
                        {
                            landingIndex = i;
                            if (landingIndex == houses.Count) landingIndex = 0;
                            counterOfJumps++;
                        }

                        if (houses[landingIndex] <= 0)
                        {
                            Console.WriteLine($"Place {landingIndex} already had Valentine's day.");
                            continue;
                        }

                        houses[landingIndex] -= 2;

                        if (houses[landingIndex] <= 0)
                        {
                            houses[landingIndex] = 0;
                            Console.WriteLine($"Place {landingIndex} has Valentine's day.");
                        }
                        break;
                }
            }
        }
    }
}
