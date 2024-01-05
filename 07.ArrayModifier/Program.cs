using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.ArrayModifier
{
    internal class Program
    {
        static void Main(string[] args)
        {


            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            while (true)
            {
                List<string> command = Console.ReadLine().Split(" ").ToList();

                switch (command[0])
                {
                    case "end":
                        Console.WriteLine(string.Join(", ", numbers));
                        return;


                    case "swap":
                        numbers = SwapOperation(numbers, command);
                        break;


                    case "multiply":
                        numbers = MultiplyOperation(numbers, command);
                        break;


                    case "decrease":
                        numbers = DecreaseOperation(numbers, command);
                        break;
                }
            }
        }
        static List<int> SwapOperation(List<int> numbers, List<string> command)
        {
            int firstIndex = int.Parse(command[1]);
            int secondIndex = int.Parse(command[2]);


            int firstValue = numbers[firstIndex];
            int secondValue = numbers[secondIndex];

            numbers.RemoveAt(firstIndex);
            numbers.Insert(firstIndex, secondValue);

            numbers.RemoveAt(secondIndex);
            numbers.Insert(secondIndex, firstValue);


            return numbers;
        }
        static List<int> MultiplyOperation(List<int> numbers, List<string> command)
        {
            int result = 0;

            int firstIndex = int.Parse(command[1]);
            int secondIndex = int.Parse(command[2]);


            int firstValue = numbers[firstIndex];
            int secondValue = numbers[secondIndex];

            result = firstValue * secondValue;

            numbers.RemoveAt(firstIndex);
            numbers.Insert(firstIndex, result);


            return numbers;
        }
        static List<int> DecreaseOperation(List<int> numbers, List<string> command)
        {
            numbers = numbers.Select(x => x - 1).ToList();
            return numbers;
        }
    }
}
