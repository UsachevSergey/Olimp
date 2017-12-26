using System; 

namespace OlimpicProject.Combinatorics
{
    class Salads
    { 
        public static void X()
        {
            int CountIngtredients = int.Parse(Console.ReadLine());
            double result = CountIngtredients>1?1:0;
            for (int i = 2; i < CountIngtredients; i++)
            {
                result += WhatFactorial(CountIngtredients) / (WhatFactorial(i) * WhatFactorial(CountIngtredients - i));
            }
            Console.WriteLine(result);



        }

       public static double WhatFactorial(double numb)
        {
            double ret = 1;
            for (int i = 2; i < numb+1; i++)
            {
                ret *= i;
            }
            return ret;

        }

    }
}
