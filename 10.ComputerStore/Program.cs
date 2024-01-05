using System;

namespace _10.ComputerStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double totalPriceWithoutTax = 0;
            bool isSpecial = false;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "special" || input == "regular")
                {
                    if (input == "special")
                    {
                        isSpecial = true;
                        break;
                    }
                    break;
                }
                double currentPrice = double.Parse(input);
                if (currentPrice <= 0)
                {
                    Console.WriteLine("Invalid price!");
                    continue;
                }
                totalPriceWithoutTax += currentPrice;
            }
            if (totalPriceWithoutTax ==  0)
            {
                Console.WriteLine("Invalid order!");
                return;
            }
            double tax = totalPriceWithoutTax * 0.2;
            Console.WriteLine($"Congratulations you've just bought a new computer!");
            Console.WriteLine($"Price without taxes: {totalPriceWithoutTax:f2}$");
            Console.WriteLine($"Taxes: {tax:f2}$");
            Console.WriteLine("-----------");
            double totalPrice = totalPriceWithoutTax + tax;

            if (isSpecial)
            {
                Console.WriteLine($"Total price: {(totalPrice * 0.9):f2}$");
                return;
            }

            Console.WriteLine($"Total price: {totalPrice:f2}$");
        }
    }
}
