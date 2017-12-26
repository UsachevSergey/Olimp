using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.TasksForBeginners
{
    class GoldSand
    {
        public static void X()
        {
            string[] s = Console.ReadLine().Split(' ');
            int A1 = int.Parse(s[0]);
            int A2 = int.Parse(s[1]);
            int A3 = int.Parse(s[2]);
            int B1 = int.Parse(s[3]);
            int B2 = int.Parse(s[4]);
            int B3 = int.Parse(s[5]);
            List<int> kA = new List<int>();
            List<int> kB = new List<int>();
            kA.Add(A1); kA.Add(A2); kA.Add(A3);
            kB.Add(B1); kB.Add(B2); kB.Add(B3);
            kA.Sort();
            kB.Sort();
            int result = kA[0] * kB[0] + kA[1] * kB[1] + kA[2] * kB[2];
            Console.WriteLine(result);
        }
    }
}
