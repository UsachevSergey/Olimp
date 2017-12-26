using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.TasksForBeginners
{
    class Salary
    {
        public static void X()
        {
            string[] s = Console.ReadLine().Split(' ');
            int a = int.Parse(s[0]);
            int b = int.Parse(s[1]);
            int c = int.Parse(s[2]);
            int ab = a - b;
            if (ab<0)
            {
                ab = b - a;
            }
            int ac = a - c;
            if (ac<0)
            {
                ac = c - a;
            }
            int bc = b - c;
            if (bc<0)
            {
                bc = c - b;
            }
            Console.WriteLine(Math.Max(Math.Max(ab, ac), bc));

        }
    }
}
