using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.ParsingString
{
    class BullsAbdCow
    {
        public static void X()
        {
            string[] s = Console.ReadLine().Split();
            string A = s[0];
            string B = s[1];
            int bulls = 0;
            int cow = 0;
            for (int i = 0; i < 4; i++)
            {
                if (A[i]==B[i])
                {
                    bulls++;
                }
                else if (A.Contains(B[i]))
                {
                    cow++;
                }
            }
            Console.WriteLine(bulls+" "+cow);


        }
    }
}
