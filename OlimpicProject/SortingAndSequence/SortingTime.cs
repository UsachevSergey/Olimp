using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.SortingAndSequence
{
    class SortingTime
    {
        public static void X()
        {
            int N = int.Parse(Console.ReadLine());
            List<DateTime> DT = new List<DateTime>();
            for (int i = 0; i < N; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                DateTime currentdt = new DateTime(1,1,1, int.Parse(s[0]), int.Parse(s[1]), int.Parse(s[2]));
                DT.Add(currentdt);
            }
           DT.Sort();
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine( DT[i].Hour+" "+DT[i].Minute + " " + DT[i].Second);
            }
        }
    }
}
