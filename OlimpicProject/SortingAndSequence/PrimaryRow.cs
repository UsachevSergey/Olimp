using System;
using System.Collections.Generic;
using System.Linq; 

namespace OlimpicProject.SortingAndSequence
{
    class PrimaryRow
    {
        public static void X()
        {
            List<int> primaryNumber = new List<int>() {2,3};
            string PrimaryRow = "23";
            int iter = 5;
            //пока длина ряда менее 10000 
            while (PrimaryRow.Count()<10000)
            {
                bool yes = true;
                for (int i = 0; i < primaryNumber.Count; i++)
                {
                    if (iter%primaryNumber[i]==0)
                    {
                        iter+=2;
                        yes = false;
                        break;
                    }
                }

                if (yes)
                {
                    primaryNumber.Add(iter);
                    PrimaryRow += iter.ToString();
                    iter += 2;
                } 
            }

            int CountTest = int.Parse(Console.ReadLine()); 
            List<int> ArrayIndex = Console.ReadLine().Replace("  ", " ").Trim().Split().ToList().ConvertAll(asertew => int.Parse(asertew));
            for (int i = 0; i < CountTest; i++)
            {
                Console.Write(PrimaryRow[ArrayIndex[i] - 1].ToString());
            }
            Console.WriteLine();

        }
    }
}
