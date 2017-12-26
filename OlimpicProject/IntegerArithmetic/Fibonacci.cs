using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.IntegerArithmetic
{
    class Fibonacci
    {
        public static void X()
        {
            int A = int.Parse(Console.ReadLine());
            int[] res = new int[A+1];
            if (A == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                res[0] = 0;
                res[1] = 1;
                for (int i = 2; i < A + 1; i++)
                {
                    res[i] = res[i - 1] + res[i - 2];
                }
                Console.WriteLine(res[A]);
            }
        }
    }
}
