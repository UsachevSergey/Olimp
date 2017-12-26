using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.SortingAndSequence
{
    class CrisisBusiness
    {
        public static void X()
        {
            string[] s = Console.ReadLine().Split(' ');
            int CountAuto = int.Parse(s[0]);
            int Money = int.Parse(s[1]);
            List<int> ListAuto = Console.ReadLine().Split(' ').ToList().ConvertAll(df => int.Parse(df));
            ListAuto.Sort(); 
            int res = 0;
            foreach (var item in ListAuto)
            {
                if (item<=Money)
                {
                    Money -= item;
                    res++;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(res);
        }
    }
}
