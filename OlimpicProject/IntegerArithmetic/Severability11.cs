using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.IntegerArithmetic
{
    class Severability11
    {
        public static void X()
        {
            string s = Console.ReadLine();
            int count = s.Length;
            int sch = 0;
            int snch = 0;
            for (int i = 0; i < count; i += 2)
            {
                snch += int.Parse(s[i].ToString());
            }
            for (int i = 1; i < count; i += 2)
            {
                sch += int.Parse(s[i].ToString());
            }
            if (Math.Abs(sch - snch) % 11 == 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
