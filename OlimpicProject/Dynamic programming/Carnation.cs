using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.Dynamic_programming
{
    class Carnation
    {
        public static void X()
        {

            int CountCarnation = int.Parse(Console.ReadLine());


            List<string> ArrayCarnation0 = Console.ReadLine().Split(' ').ToList();
            ArrayCarnation0.Remove("");
           List<int> ArrayCarnation= ArrayCarnation0.ConvertAll(ssd => int.Parse(ssd));
            
                ArrayCarnation.Sort();
                if (CountCarnation == 2)
                {
                    Console.WriteLine(ArrayCarnation[1] - ArrayCarnation[0]);
                }
                else
                {
                    int[] resultRazn = new int[CountCarnation + 1];

                    for (int i = 1; i < CountCarnation; i++)
                    {
                        resultRazn[i] = ArrayCarnation[i] - ArrayCarnation[i - 1];
                    }
                    int[] result = new int[CountCarnation + 1];
                    result[1] = resultRazn[1];
                    result[2] = result[1] + resultRazn[2];
                    for (int i = 3; i < CountCarnation; i++)
                    {
                        result[i] = Math.Min(result[i - 2], result[i - 1]) + resultRazn[i];
                    }
                    Console.WriteLine(result[CountCarnation - 1]);
                }
            
        }

    }
}
