using System;
using System.Collections.Generic;
using System.Linq;

namespace _12.Inventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> inventory = Console.ReadLine().Split(", ").ToList();

            string command;

            while ((command = Console.ReadLine()) != "Craft!")
            {
                List<string> arguments = command.Split(" - ").ToList();
                switch (arguments[0])
                {
                    case "Collect":

                        if (!inventory.Contains(arguments[1]))
                        {
                            inventory.Add(arguments[1]);
                        }
                        break;

                    case "Drop":
                        if (inventory.Contains(arguments[1]))
                        {
                            inventory.Remove(arguments[1]);
                        }
                        break;

                    case "Combine Items":
                        string[] items = arguments[1].Split(":");
                        int oldItemIndex = inventory.IndexOf(items[0]);
                        if (oldItemIndex >= 0)
                        {
                            if (oldItemIndex >= inventory.Count)
                            {
                                inventory.Add(items[1]);
                            }
                            else
                            {
                                inventory.Insert(oldItemIndex + 1, items[1]);
                            }

                        }
                        break;
                    case "Renew":
                        int index = inventory.IndexOf(arguments[1]);

                        if (index != -1)
                        {
                            string item = inventory[index];
                            inventory.RemoveAt(index);
                            inventory.Add(item);

                        }

                        break;

                }
            }
            Console.WriteLine(string.Join(", ", inventory));
        }
    }
}
