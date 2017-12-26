using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.BasicMAthematic
{
    class PuzzleQueens
    {
        public static void X()
        {
            int N = int.Parse(Console.ReadLine());
            int result = N*N -(3*(N-1))-1;
            if (result<0)
            {
                result = 0;
            }
            Console.WriteLine(result);

        }
    }
}
