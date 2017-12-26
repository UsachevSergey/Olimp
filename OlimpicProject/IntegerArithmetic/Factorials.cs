using System;
using System.Linq;

namespace OlimpicProject.IntegerArithmetic
{
    internal class Factorials
    {
        internal static void X()
        {
            string[] s = Console.ReadLine().Split();
            int Number = int.Parse(s[0]);
            int CountExclamationPoint = s[1].Count(a => a == '!');
            int result = Number; 
            for (int i = Number-CountExclamationPoint; i >= (Number%CountExclamationPoint==2? Number % CountExclamationPoint:CountExclamationPoint); i-=CountExclamationPoint)
            { 
                result *= i;
            }
            Console.WriteLine(result);

        }
    }
}