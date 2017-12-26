using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.ParsingString
{
    class Permutation
    {
        public static void X()
        {
            string[] s = Console.ReadLine().Split();
            List<char> Str1 = s[0].ToLower().ToCharArray().ToList();
            List<char> Str2 = s[1].ToLower().ToCharArray().ToList();
            Str1.Sort();
            Str2.Sort();
            bool res = true;
            if (Str1.Count == Str2.Count)
            {
                for (int i = 0; i < Str1.Count; i++)
                {
                    if (Str1[i]!=Str2[i])
                    {
                        res = false;
                    }
                }
            }
            else
            {
                res = false;
            }

            Console.WriteLine(res?"Yes":"No");
 
            

        }
    }
}
