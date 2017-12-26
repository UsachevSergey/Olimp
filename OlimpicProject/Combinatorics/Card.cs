using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.Combinatorics
{
    class Card
    { 
        public static void X()
        {
            string s = Console.ReadLine();
            long lenghtString = s.Length;
            Dictionary<string, long> DicLetter = new Dictionary<string, long>();
            for (int i = 0; i < s.Count(); i++)
            {
                string currentletter = s[i].ToString();
                if (!DicLetter.ContainsKey(currentletter))
                {
                    DicLetter.Add(currentletter, 0);
                }
                DicLetter[currentletter]++;  
            }
            long Divider = 1;
            foreach (var item in DicLetter)
            {
                Divider *= Fact(item.Value);
            }


            long result = Fact(lenghtString) / Divider;
            Console.WriteLine(result);

        }
        public static long Fact(long a)
        {
            long result = 1;
            for (long i = 1; i < a+1; i++)
            {
                result *= i;
            }
            return result;
        } 
    }
}
