using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.Dynamic_programming
{
    class MinimalPathInTable
    {
        public static void X()
        {
            string[] s = Console.ReadLine().Split(' ');
            int str = int.Parse(s[0]); int col = int.Parse(s[1]);
            int[,] table = new int[str, col];
            for (int i = 0; i < str; i++)
            {
                string[] currentstr = Console.ReadLine().Split(' ');
                for (int j = 0; j < col; j++)
                {
                    table[i, j] = int.Parse(currentstr[j]);
                } 
            }
            for (int i = 0; i < str; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    int curentstrmax = 0;
                    int curentcolmax = 0;
                    if (j != 0)
                    {
                        curentstrmax = table[i, j] + table[i, j-1];
                    }
                    else
                    {
                        curentstrmax = 999999;
                    }
                    if (i!=0)
                    {
                        curentcolmax = table[i, j] + table[i - 1, j];
                    }
                    else
                    {
                        curentcolmax = 999999;
                    }

                    if (i==0 && j==0)
                    {
                        curentcolmax = table[i, j];
                        curentstrmax = table[i, j];
                    }
                    table[i, j] = Math.Min(curentcolmax, curentstrmax);
                }
            }

            Console.WriteLine(table[str-1,col-1]);
        }
    }
}
