using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.TwoDimensionalArray
{
    class SadlePoints
    {
        public static void X()
        {
            string[] input = Console.ReadLine().Split();
            int str = int.Parse(input[0]);
            int col = int.Parse(input[1]);
            int[,] Matrix = new int[str,col];
            int[] minstr = new int[str];
            int[] maxcol = new int[col];
            for (int i = 0; i < minstr.Count(); i++)
            {
                minstr[i] = 9999;
            }
            for (int i = 0; i < maxcol.Count(); i++)
            { 
                maxcol[i] = -9999;
            } 
            for (int i = 0; i < str; i++)
            {
                string[] currentstr = Console.ReadLine().Replace("  "," ").Split();
                for (int j = 0; j < col; j++)
                {
                    //заполняем матрицу и заполняем минимум и максимум по строкам и столбцам
                    int current = int.Parse(currentstr[j]); 
                    Matrix[i, j] = current; 
                    if (current > maxcol[j])
                    {
                        maxcol[j] = current;
                    }
                    if (current < minstr[i])
                    {
                        minstr[i] = current;
                    }
                }
            }

            int result = 0;
            //проходим по максимумам в  строкаx
            for (int i = 0; i < str; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (Matrix[i, j] == minstr[i] && Matrix[i, j] == maxcol[j])
                    {
                        result++;
                    }
                }
            }
            if (str==1 && col==1)
            {
                result = 0;
            }
                Console.WriteLine(result);
        }
    }
}
