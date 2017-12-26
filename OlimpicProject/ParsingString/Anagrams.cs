using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.ParsingString
{
    class Anagrams
    {
        public static void X()
        {
            List<char> A = Console.ReadLine().ToCharArray().ToList(); A.Sort();
            List<char> B = Console.ReadLine().ToCharArray().ToList(); B.Sort();
            string result = "YES";
            if (A.Count==B.Count)
            {
                for (int i = 0; i < A.Count; i++)
                {
                    if (A[i]!=B[i])
                    {
                        result = "NO";
                        break;
                    }
                }
            }
            else
            {
                result = "NO";
            }

            Console.WriteLine(result);

        }
    }
}
