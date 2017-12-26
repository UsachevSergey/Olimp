using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.TulaCodeCup2017.Round3
{
    class HereAreTheLetter
    {
        public static void X()
        {
            string s = Console.ReadLine();
            int A = 0;
            int a = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] > 96)
                {
                    a++;
                }
                else
                {
                    A++;
                }
            }
            if (A > a)
            {
                Console.WriteLine(s.ToUpper());
            }
            else
            {
                Console.WriteLine(s.ToLower());
            }
        }
    }
}
