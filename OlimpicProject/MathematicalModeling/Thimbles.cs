using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.MathematicalModeling
{
    class Thimbles
    {
        public static void X()
        {
            int a, b, c;
            a = 1;  b = 0; c = 0;
            string s = Console.ReadLine();
            for (int i = 0; i < s.Length; i++)
            {
                int dop;
                if (s[i].ToString() == "A")
                {
                    dop = a; a = b; b = dop;
                }
                else if (s[i].ToString() == "B")
                {
                    dop = c; c = b; b = dop;
                }
                else
                {
                    dop = a; a = c; c = dop;
                }
            }
            if (a==1)
            {
                Console.WriteLine(1);
            }
            else if (b==1)
            {
                Console.WriteLine(2);
            }
            else
            {
                Console.WriteLine(3);
            }

        }
    }
}
