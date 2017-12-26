using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.Dynamic_programming
{
    class BallOnStairs
    {
        public static void X()
        {
            int N = int.Parse(Console.ReadLine());
            int countstais = N;
            if (countstais<3)
            {
                countstais = 3;
            } 
            ulong[] d = new ulong[countstais];
            d[0] = 1;
            d[1] = 2;
            d[2] = 4;
            for (int i = 3; i < N; i++)
            {
                d[i] = d[i - 1] + d[i - 2] + d[i - 3];
            }
            Console.WriteLine(d[N-1]);
        }
    }
}
