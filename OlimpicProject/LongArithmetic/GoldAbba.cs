using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.LongArithmetic
{
    class GoldAbba
    {
        public static void X()
        {
            string[] S = Console.ReadLine().Split();
            string S1 = S[0];
            string S2 = S[1];
            string S3 = S[2];
            List<string> Smax = new List<string>() { S1, S2, S3 };
            string result = Smax.OrderBy(x => x.Count()).ThenBy(x => x).Last();
            Console.WriteLine(result);
        }
    }
}
