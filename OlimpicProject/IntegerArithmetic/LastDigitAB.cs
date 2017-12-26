using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.IntegerArithmetic
{
    class LastDigitAB
    {
        public static void X()
        {
            string[] s = Console.ReadLine().Split(' ');
            int A = int.Parse(s[0][s[0].Count()-1].ToString());
            int a = A;
            int B = int.Parse(s[1]); 
            for (int i = 0; i < B-1; i++)
            {
                A = (A *a) % 10;
            }
            Console.WriteLine(A);


        }
    }
}
