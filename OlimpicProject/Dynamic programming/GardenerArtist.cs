using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.Dynamic_programming
{
    class GardenerArtist
    {
        public static void X()
        {
            int a = 3;
            int counttree = int.Parse(Console.ReadLine());
            for (int i = 1; i < counttree; i++)
            {
                a *= 2;
            }
            Console.WriteLine(a);
        }
    }
}
