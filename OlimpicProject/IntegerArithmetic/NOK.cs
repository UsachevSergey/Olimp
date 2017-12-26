using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.IntegerArithmetic
{
    class NOK
    {
        public static void X()
        {
            string[] s = Console.ReadLine().Split();
            int A = Math.Min(int.Parse(s[0]), int.Parse(s[1])); 
            int B = Math.Max(int.Parse(s[0]), int.Parse(s[1]));
            int Plus = A;
            while (A % B != 0)
            {
                A+=Plus;
            }
            Console.WriteLine(A);
        }
    }
}
