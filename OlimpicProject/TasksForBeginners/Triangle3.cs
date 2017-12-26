using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.TasksForBeginners
{
    class Triangle3
    {
        public static void X()
        {
            string[] s = Console.ReadLine().Split(' ');
            int a = int.Parse(s[0]);
            int b = int.Parse(s[1]);
            int c = int.Parse(s[2]);
            int MaxSide = Math.Max(a, Math.Max(b, c));
            int summinside = Math.Min(a, b) + Math.Min(b, c);
            if (summinside<=MaxSide)
            {
                Console.WriteLine("NO");
            }
            else{
                Console.WriteLine("YES");
            }
        }
    }
}
