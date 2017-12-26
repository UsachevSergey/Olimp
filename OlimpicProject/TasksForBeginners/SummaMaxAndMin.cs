using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.TasksForBeginners
{
    /// <summary>
    /// ВЫДАЕТ НЕХВАТКУ ПАМЯТИ ДАЖЕ ПРИ РЕШЕНОМ ПРИМЕРЕ
    /// </summary>
    class SummaMaxAndMin
    {
        public static void X()
        { 
            List<int> S = Console.ReadLine().Split(' ').ToList().ConvertAll(sa=>int.Parse(sa));
            int maxch = -99999;
            int minncch = 99999;
            for (int i = 0; i < S.Count(); i++)
            { 
                if (i%2==0 )
                {
                    if ( minncch > S[i])
                    {
                        minncch = S[i];
                    }
                }
                else  
                {
                    if (maxch < S[i])
                    {
                        maxch = S[i];
                    }
                }
            } 
            Console.WriteLine(maxch + minncch);
        }
    }
}
