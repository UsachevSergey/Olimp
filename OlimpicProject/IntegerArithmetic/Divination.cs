using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.IntegerArithmetic
{
    class Divination
    {
        public static void X()
        {
            int N = int.Parse(Console.ReadLine());
            int result = 0;
            for (int i = 1; i < N+1; i++)
            {
                if (N%i==0)
                {
                   result+=i;
                }
            } 
            Console.WriteLine(result);
        }
    }
}
