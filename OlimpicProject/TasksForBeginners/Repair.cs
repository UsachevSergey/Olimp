using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.TasksForBeginners
{
    class Repair
    {
        public static void X()
        {
            string[] s = Console.ReadLine().Split(' ');
            int s1 = int.Parse(s[0]); int s2 = int.Parse(s[1]); int s3 = int.Parse(s[2]);
            int res = ((s1 + s2) * 2 * s3) / 16;
            if (((s1 + s2) * 2 * s3) % 16>0)
            {
                res++;
            }
            Console.WriteLine(res);
        }
    }
}
