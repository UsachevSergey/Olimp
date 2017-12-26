using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.Dynamic_programming
{
    class WithoutTwoZeroInRow
    {
        public static void X()
        {
            string[] s = Console.ReadLine().Split(' ');
            int CountNumber = int.Parse(s[0]);
            int SystenEnum = int.Parse(s[1]);  
           int[]  resultToStep = new int[CountNumber]; 
            int[] CountZero = new int[CountNumber]; 
            resultToStep[0] = SystenEnum - 1; 
            resultToStep[1] = resultToStep[0] * SystenEnum;
            CountZero[0] = 0; 
            CountZero[1] = resultToStep[0];
             
            for (int i = 2; i < CountNumber; i++)
            {
                resultToStep[i] = resultToStep[i - 1] * SystenEnum - (CountZero[i - 1]);

                CountZero[i] = resultToStep[i - 1] - CountZero[i - 1];
            }
            Console.WriteLine(resultToStep[CountNumber-1]);
        }
    }
}
