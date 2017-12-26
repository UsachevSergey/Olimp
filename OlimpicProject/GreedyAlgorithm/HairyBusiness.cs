using System;
using System.Collections.Generic;
using System.Linq; 

namespace OlimpicProject.GreedyAlgorithm
{
    class HairyBusiness
    {
        public static void X()
        {
            int countDay = int.Parse(Console.ReadLine()); 
            List<int> CostEveryDay = Console.ReadLine().Replace("  ", " ").Trim().Split().ToList().ConvertAll(asertew => int.Parse(asertew));
            int result = 0;
            while (CostEveryDay.Count>0)
            {
                int currentmaxcost = CostEveryDay.Max();
                int indexmax = CostEveryDay.LastIndexOf(currentmaxcost);
                result += (indexmax + 1) * currentmaxcost;
                CostEveryDay.RemoveRange(0, indexmax+1);
            }
            Console.WriteLine(result);



        }
    }
}
