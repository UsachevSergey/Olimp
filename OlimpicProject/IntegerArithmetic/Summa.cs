using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.IntegerArithmetic
{
    class Summa
    {
        public static void X()
        {
            int S = int.Parse(Console.ReadLine());
            int res = 0;
            if (S > 0)
            {
                for (int i = 0; i < S + 1; i++)
                {
                    res += i;
                }
                Console.WriteLine(res);
            }
            else
            {
                for (int i = S; i < 2; i++)
                {
                    res += i;
                }
                Console.WriteLine(res);
            }
        }
    }
}
