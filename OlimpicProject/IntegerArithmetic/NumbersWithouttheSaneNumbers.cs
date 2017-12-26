using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.IntegerArithmetic
{
    class NumbersWithouttheSaneNumbers
    {
        public static void X()
        {
            int N = int.Parse(Console.ReadLine());
            int Result = 0; 
            
            for (int i = 1; Result < N; i++)
            {
                int a = i.ToString().Count();
                int b = i.ToString().Distinct().Count();
                if (a==b)
                {
                    Result++;
                    if (Result==N)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
           
        }
    }
}
