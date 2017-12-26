using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.SortingAndSequence
{
    class Elections
    { public static void X()
        { 
            int Count_party = int.Parse(Console.ReadLine()); 
            if (Count_party == 0)
            {
                Console.WriteLine("1");
            }
            else
            {
                //для победы нужно на 1 больше чем половина
                int CountpartyForWin = (Count_party / 2) + 1;
               
                List<int> Count_people_in_party = Console.ReadLine().Replace("  "," ").Trim().Split().ToList().ConvertAll(a=>int.Parse(a));
                 
                Count_people_in_party.Sort();

                int result = 0;
                //проходим по наименьшим партиям в количестве достаточном для победы
                for (int i = 0; i < CountpartyForWin; i++)
                {
                    result += (Count_people_in_party[i] / 2) + 1;
                }
                Console.WriteLine(result);
            }



        }
    }
}
