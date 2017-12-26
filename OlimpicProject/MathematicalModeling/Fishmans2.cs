using System; 

namespace OlimpicProject.MathematicalModeling
{
    class Fishmans2
    {
        public static void X()
        { 
            string[] s = Console.ReadLine().Split(' ');
            
            ulong CountFishMan = ulong.Parse(s[0]);
            ulong Remainder = ulong.Parse(s[1]); 
            ulong res = CountFishMan;   
            for (ulong i = 0; i < CountFishMan-1; i++)
            {
                res *= CountFishMan;
            }
            res -= (CountFishMan - 1) * Remainder;

            Console.WriteLine(res.ToString());
        }
    }
}
