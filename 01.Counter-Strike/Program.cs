using System;

namespace _01.Counter_Strike
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int myEnergy = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            int count = 0;

            bool hasEnoughEnergy = true;

            while (command != "End of battle")
            {
                int distance = int.Parse(command);
                if (myEnergy - distance < 0)
                {
                    hasEnoughEnergy = false;
                    break;
                }

                myEnergy -= distance;
                count++;

                if (count % 3 == 0)
                {
                    myEnergy += count;
                }
                command = Console.ReadLine();
            }
            if (hasEnoughEnergy)
            {
                Console.WriteLine($"Won battles: {count}. Energy left: {myEnergy}");
            }
            else
            {
                Console.WriteLine($"Not enough energy! Game ends with {count} won battles and {myEnergy} energy");
            }
        }
    }
}
