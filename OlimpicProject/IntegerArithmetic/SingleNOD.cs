using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.IntegerArithmetic
{
    class SingleNOD
    {
        public static void X()
        {
            string[] s = Console.ReadLine().Split(' ');
            int A = Convert.ToInt32(s[0]);
            int B = Convert.ToInt32(s[1]);

            while (A * B != 0)
            {
                if (A > B)
                    A = A % B;
                else
                    B = B % A;
            }
            int res = A + B;
            for (int i = 0; i < res; i++)
            {
                Console.Write(1);
            }


        }
    }
}
