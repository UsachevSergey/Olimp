using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.BasicMAthematic
{
    class Equation
    {
        public static void X()
        {string[] S = Console.ReadLine().Split();
            long A = long.Parse(S[0]);
            long B = long.Parse(S[1]);
            long C = long.Parse(S[2]);
            long D = long.Parse(S[3]);
            string result = "";
            for (int i = -100; i < 101; i++)
            { 
                if (A*i*i*i +B*i*i+C*i+D ==0)
                {
                    result += i + " ";
                }
            }
            result.Trim();
            Console.WriteLine(result);
            
        }
    }
}
