using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.IntegerArithmetic
{
    class FriendsNumbers
    {
        public static void X()
        {
            int CountTest = int.Parse(Console.ReadLine());
            for (int i = 0; i < CountTest; i++)
            {
                string[] S = Console.ReadLine().Split(' ');
                List<char> A = S[0].ToCharArray().Distinct().ToList();
                List<char> B = S[1].ToCharArray().Distinct().ToList();
                A.Sort();
                B.Sort();
                bool yes = true;

                if (A.Count != B.Count)
                {
                    yes = false;
                }
                else
                {
                    for (int l = 0; l < B.Count; l++)
                    {
                        if (A[l] != B[l])
                        {
                            yes = false;
                            break;
                        }
                    }
                }

                if (yes) { 
                Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                } 
            }



        }
    }
}
