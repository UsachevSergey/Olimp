using System;
using System.Collections.Generic;
using System.Linq; 

namespace OlimpicProject.SortingAndSequence
{
    class Statistics
    {
        public static void X()
        {

            int CountDay = int.Parse(Console.ReadLine()); 
            List<int> ArrayDay = Console.ReadLine().Replace("  ", " ").Trim().Split().ToList().ConvertAll(asertew => int.Parse(asertew));
            //тройки
            List<int> Three = new List<int>();
            //четверки  
            List<int> Four  = new List<int>();

            foreach (var item in ArrayDay)
            {
                //если четный день
                if (item%2==0)
                {
                    Four.Add(item);
                }
                else
                {
                    Three.Add(item);
                }
            }
            foreach (var item in Three)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            foreach (var item in Four)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            if (Three.Count()>Four.Count())
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine("YES");
            } 
        }
    }
}
