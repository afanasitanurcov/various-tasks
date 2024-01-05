using System;
using System.Linq;
using System.Collections.Generic;

namespace _08.BonusScoringSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int studentsCount = int.Parse(Console.ReadLine());
            int lecturesCount = int.Parse(Console.ReadLine());
            int additionalBonus = int.Parse(Console.ReadLine());

            decimal maxBonus = 0;
            int maxAttendances = 0;

            for (int i = 0; i < studentsCount; i++)
            {
                int attendances = int.Parse(Console.ReadLine());

                decimal bonus = Math.Ceiling((decimal)attendances / lecturesCount * (5 + additionalBonus));

                if (maxBonus < bonus)
                {
                    maxBonus = bonus;
                    maxAttendances = attendances;
                }
            }           

            Console.WriteLine($"Max Bonus: {maxBonus}."
);
            Console.WriteLine($"The student has attended {maxAttendances} lectures.");
        }
    }
}
