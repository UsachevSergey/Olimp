using System;
using System.Collections.Generic;
using System.Linq; 

namespace OlimpicProject.SortingAndSequence
{
    class GamblingShrek
    {
        public static void X()
        {

            int CountCard = int.Parse(Console.ReadLine());

            List<int> ArrayCard = Console.ReadLine().Replace("  ", " ").Trim().Split().ToList().ConvertAll(asertew => int.Parse(asertew));
            ArrayCard.Sort();
            int MaxSum = 0;
            for (int i = 0; i < ArrayCard.Count/2; i++)
            {
                MaxSum += (ArrayCard[ArrayCard.Count - 1 - i] - ArrayCard[i]);
            }
            Console.WriteLine(MaxSum);

        }
    }
}
