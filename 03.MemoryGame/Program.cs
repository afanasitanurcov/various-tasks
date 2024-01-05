using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MemoryGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split(" ").ToList();

            list.RemoveAll(x => x == "");



            int countOfWins = 0;
            int countOfMoves = 0;


            while (true)
            {

                string input = Console.ReadLine();

                if (input == "end") break;
                if (list.Count == 0) continue;

                countOfMoves++;
                List<int> command = input.Split(" ").Select(int.Parse).OrderBy(x => x).ToList();




                if (command[0] >= 0 && command[1] >= 0 && command[0] < list.Count && command[1] < list.Count && command[0] != command[1])
                {
                    string firstElement = list[command[0]];
                    string secondElement = list[command[1]];

                    if (firstElement == secondElement)
                    {
                        Console.WriteLine($"Congrats! You have found matching elements - {firstElement}!");
                        list.RemoveAt(command[1]);
                        list.RemoveAt(command[0]);

                        countOfWins++;
                    }
                    else
                    {
                        Console.WriteLine("Try again!");
                    }

                }
                else
                {

                    string addElement = $"-{countOfMoves}a";
                    list.Insert(list.Count / 2, addElement);
                    list.Insert(list.Count / 2, addElement);


                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                }


            }
            if (list.Count == 0)
            {
                Console.WriteLine($"You have won in {countOfWins} turns!");
            }
            else
            {
                Console.WriteLine("Sorry you lose :(");
                Console.WriteLine(string.Join(" ", list));
            }
        }
    }
}
