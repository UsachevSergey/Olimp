using System;
using System.Collections.Generic;
using System.Linq; 

namespace OlimpicProject.SortingAndSequence
{
    class Bell
    {
        public static void X()
        {

            int CountNumber = int.Parse(Console.ReadLine());
            List<int> LIST = Console.ReadLine().Replace("  ", " ").Trim().Split().ToList().ConvertAll(asertew => int.Parse(asertew));
            List<int> ListSTART = new List<int>();
            List<int> ListEND = new List<int>();
            LIST.Sort();
            for (int i = 0; i < CountNumber; i++)
            {
                if (i%2==0)
                {
                    ListSTART.Add(LIST[i]);
                }
                else
                {
                    ListEND.Add(LIST[i]);
                }
            }
            ListEND = ListEND.OrderByDescending(a => a).ToList();
            for (int i = 0; i < ListSTART.Count; i++)
            {
                Console.Write(ListSTART[i] + " ");
            }
            for (int i = 0; i < ListEND.Count; i++)
            {
                Console.Write(ListEND[i] + " ");
            }
            Console.WriteLine();

        }
    }
}
