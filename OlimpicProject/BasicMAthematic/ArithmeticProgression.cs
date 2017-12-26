using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.BasicMAthematic
{
    class ArithmeticProgression
    {
        public static void X()
        {
            string[] s = Console.ReadLine().Split();
            int A = int.Parse(s[0]);
            int B = int.Parse(s[1]);
            int Number = int.Parse(s[2]);
            int result = A;
            for (int i = 0; i < Number-1; i++)
            {
                result += B - A;
            }
            Console.WriteLine(result);
        } 
    }
}
