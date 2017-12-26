using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.BasicMAthematic
{
    class Cells
    {
        public static void X()
        {
            string S = Console.ReadLine();
            string a = "_ABCDEFGH";
            int A = int.Parse(S[1].ToString());
            int B = a.IndexOf(S[0]);
            if (A%2==B%2)
            {
                Console.WriteLine("BLACK");
            }
            else
            {
                Console.WriteLine("WHITE");
            }
        }
    }
}
