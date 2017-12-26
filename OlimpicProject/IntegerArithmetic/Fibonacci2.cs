using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.IntegerArithmetic
{
    class Fibonacci2
    {
        public static void X()
        {
            int N = int.Parse(Console.ReadLine());
            List<int> ArrFib = new List<int>();
            ArrFib.Add(0); ArrFib.Add(1);
            int curent = 2;
            while (ArrFib[ArrFib.Count-1]<=N)
            {
                ArrFib.Add(ArrFib[curent - 1] + ArrFib[curent - 2]);
                curent++;
            }
            //если последний равен фибаначи
            if (ArrFib[ArrFib.Count - 2] == N)
            { 
                Console.WriteLine(1);
                Console.WriteLine(curent-2);
            }
            else
            {
                Console.WriteLine(0);
            }

        }
    }
}
