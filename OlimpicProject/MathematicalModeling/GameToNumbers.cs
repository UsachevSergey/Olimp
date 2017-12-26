using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.MathematicalModeling
{
    class GameToNumbers
    {
        public static void X()
        {
            int countN =int.Parse(Console.ReadLine());
            List<int> Numbers = Console.ReadLine().Replace("  "," ").Replace("   "," ").Trim().Split(' ').ToList().ConvertAll(sd => int.Parse(sd));
            int a = 0;
            int b = 0;

            bool CurentA = true;
            while (Numbers.Count>0)
            {
                if (Numbers[0]>=Numbers[Numbers.Count-1])
                {
                    if (CurentA)
                    {
                        a += Numbers[0];
                    }
                    else
                    {
                        b += Numbers[0];
                    }
                    Numbers.RemoveAt(0);
                    CurentA  = !CurentA;
                }
                else
                {
                    if (CurentA)
                    {
                        a += Numbers[Numbers.Count - 1];
                    }
                    else
                    {
                        b += Numbers[Numbers.Count - 1];
                    }
                    Numbers.RemoveAt(Numbers.Count - 1);

                    CurentA  = !CurentA;
                }
            }
            Console.WriteLine(a+":"+b);

        }
    }
}
