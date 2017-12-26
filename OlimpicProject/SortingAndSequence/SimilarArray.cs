using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.SortingAndSequence
{
    class SimilarArray
    {
        public static void X()
        {
             
            string[] _2count = Console.ReadLine().Split(' ');

            List<int> Array1 = Console.ReadLine().Replace("  ", " ").Trim().Split().ToList().Distinct().ToList().ConvertAll(asertew => int.Parse(asertew));
            List<int> Array2 = Console.ReadLine().Replace("  ", " ").Trim().Split().ToList().Distinct().ToList().ConvertAll(asertew => int.Parse(asertew));

            Array1.Sort();
            Array2.Sort();
            bool yes = true;
            if (Array1.Count!=Array2.Count)
            {
                yes = false;
            }
            else
            {
                for (int i = 0; i < Array1.Count(); i++)
                {
                    if (Array1[i]!=Array2[i])
                    {
                        yes = false;
                        break;
                    }
                }
            }



            if (yes)
            {
                Console.WriteLine(1);
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
