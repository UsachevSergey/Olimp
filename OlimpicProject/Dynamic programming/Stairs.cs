using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.Dynamic_programming
{
    class Stairs
    {
        public static void X()
        {
            int N =int.Parse(Console.ReadLine());
            List<int> L = Console.ReadLine().Split(' ').ToList().ConvertAll(s => int.Parse(s));
            List<string> path = new List<string>();
            path.Add("1");
            if (L[0]>0)
            {
                path.Add("1 2");
            }
            else
            {
                path.Add("2");
            }
            L[1] = Math.Max(L[1], L[1] + L[0]);
              
            for (int i = 2; i < N; i++)
            {
                L[i] = L[i] + Math.Max(L[i - 1], L[i - 2]);
                if (L[i - 1]>L[i - 2])
                {
                    path.Add( path[i - 1]+" "+ (i+1));
                }
                else
                {
                    path.Add(path[i - 2] + " " + (i+1));
                }
            }
            Console.WriteLine(L[N-1]);
            Console.WriteLine(path[N - 1]);
        }
    }
}
