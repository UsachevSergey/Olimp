using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.BasicMAthematic
{
    class Riddle
    { public static void X()
        {
            string[] s = Console.ReadLine().Split();

            int A = int.Parse(s[0]);
            int B = int.Parse(s[1]);
            for (int i = 1; i < A; i++)
            {
                int a1 = A - i; 
                if (a1*i==B)
                {
                    
                    Console.WriteLine(i+" "+a1);break;
                } 
            }
        }
    }
}
