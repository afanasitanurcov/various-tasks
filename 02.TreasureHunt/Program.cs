using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.TreasureHunt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split('|').ToList();

            string input = Console.ReadLine();

            decimal sum = 0;

            while (input != "Yohoho!")
            {

                List<string> command = input.Split().ToList();

                switch (command[0])
                {
                    case "Loot":
                        list = LootOperation(list, command);
                        break;


                    case "Drop":
                        list = DropOperation(list, command);
                        break;




                    case "Steal":
                        list = StealOperation(list, command);
                        break;
                }
                input = Console.ReadLine();
            }

            MoneyCouting(sum, list);


        }

        static List<string> LootOperation(List<string> list, List<string> command)
        {
            for (int i = 1; i < command.Count; i++)
            {
                if (!list.Contains(command[i]))
                {
                    list.Insert(0, command[i]);
                }
            }
            return list;
        }

        static List<string> DropOperation(List<string> list, List<string> command)
        {
            int index = int.Parse(command[1]);


            if (index >= 0 && index < list.Count - 1)
            {
                string element = list[index];

                list.RemoveAt(index);
                list.Add(element);

            }

            return list;
        }
        static List<string> StealOperation(List<string> list, List<string> command)
        {
            List<string> steal = new List<string>();

            int index = int.Parse(command[1]);

            while (index > 0 && list.Count > 0)
            {
                string currentElement = list[list.Count - 1];
                steal.Add(currentElement);
                list.RemoveAt(list.Count - 1);
                index--;
            }
            steal.Reverse();
            Console.WriteLine(string.Join(", ", steal));



            return list;
        }

        static decimal MoneyCouting(decimal sum, List<string> list)
        {
            list.RemoveAll(x => x == "");
            if (list.Count < 1)
            {
                Console.WriteLine("Failed treasure hunt.");
                return sum;
            }

            string length = string.Empty;

            foreach (var i in list)
            {
                length += i;

            }
            List<char> chars = length.ToCharArray().ToList();

            decimal x = chars.Count;
            decimal y = list.Count;

            sum = x / y;
            Console.WriteLine($"Average treasure gain: {sum:F2} pirate credits.");


            return sum;
        }
    }
}

