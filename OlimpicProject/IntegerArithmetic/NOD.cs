using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.IntegerArithmetic
{
    class NOD
    {
        public static void X()
        {
            string[] s = Console.ReadLine().Split(' ');
            int A = int.Parse(s[0]);
            int B = int.Parse(s[1]);
            if (A<B)
            {
                int p = A;
                A = B;
                B = p;
            }
            bool t = true;
            int result = 0;
            while (t)
            {
                if (B == 0)
                {
                    result = A;
                    t = false;
                }
                else
                {
                    int ost = A%B; 
                    A = B;
                    B = ost;
                     
                }
            }
            Console.WriteLine(A);


        }
    }
}
