using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.Combinatorics
{
    class PointsOnBonesDominoes
    {
        public static void X()
        {
            ulong a = ulong.Parse(Console.ReadLine());
            ulong result = 0;
            for (ulong i = 0; i < a+1; i++)
            {
                result += (i * (i + 1)) + (i * (i + 1) / 2);
            }
            Console.WriteLine(result);
        }
    }
}
