using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.IntegerArithmetic
{
    class FoxAliceAndCatBasilio
    {
        public static void X()
        {
            int N = int.Parse(Console.ReadLine());
            if (N % 5 == 0)
            {
                Console.WriteLine(N / 5 +" "+ 0);
            }else
            if (N % 5 == 1)
            {
                Console.WriteLine(((N / 5)-1) +" "+ 2);
            }else
            if (N % 5 == 2)
            {
                Console.WriteLine((N / 5) - 2 + " " + 4);
            }else
            if (N % 5 == 3)
            {
                Console.WriteLine((N / 5) + " " + 1);
            }else
            if (N % 5 == 4)
            {
                Console.WriteLine((N / 5) - 1 + " " + 3);
            }

        }
    }
}
