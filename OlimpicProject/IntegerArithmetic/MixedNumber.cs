using System;
using System.Collections.Generic;
using System.Linq; 

namespace OlimpicProject.IntegerArithmetic
{
    class MixedNumber
    {
        public static void X()
        {
            int a = int.Parse(Console.ReadLine());

            for (int i = 0; i < a; i++)
            {
                int var1 = a + i;
                int var2 = a - i;
                List<char> currentVar2 = var2.ToString().ToCharArray().ToList();
                if (currentVar2.Distinct().Count() < 3)
                {
                    Console.WriteLine(var2);
                    break;
                }
                List<char> currentVar1 = var1.ToString().ToCharArray().ToList();
                if (currentVar1.Distinct().Count()<3)
                {
                    Console.WriteLine(var1);
                    break;
                } 
            }
        }
    }
}
