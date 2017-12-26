using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.Dynamic_programming
{
    class Route
    {
        public static void X()
        {

            int P = int.Parse(Console.ReadLine()); 
            int[,] table = new int[P, P];
            for (int i = 0; i < P; i++)
            {
                string currentstr = Console.ReadLine();
                for (int j = 0; j < P; j++)
                {
                   table[i, j] = int.Parse(currentstr[j].ToString());
                }
            }
            string[,] result = new string[P, P];
            for (int i = 0; i < P; i++)
            {
                
                for (int j = 0; j < P; j++)
                {
                    result[i, j] = ".";
                    int curentstrmax = 0;
                    int curentcolmax = 0;
                    if (j != 0)
                    {
                        curentstrmax = table[i, j] + table[i, j - 1];
                    }
                    else
                    {
                        curentstrmax = 999999;
                    }
                    if (i != 0)
                    {
                        curentcolmax = table[i, j] + table[i - 1, j];
                    }
                    else
                    {
                        curentcolmax = 999999;
                    }

                    if (i == 0 && j == 0)
                    {
                        curentcolmax = table[i, j];
                        curentstrmax = table[i, j];
                    }
                    table[i, j] = Math.Min(curentcolmax, curentstrmax);
                }
            }
            
            
            int a = P-1;//ctrok
            int b = P-1;//stolb
            bool re = true;

            while (re)
            {
                result[a, b] = "#";
                if (a==0)
                {
                    b = b - 1;

                }
                else if (b==0)
                {
                    a = a - 1;
                } else 
                if (table[a-1,b]<table[a,b-1])
                {
                    a = a - 1;
                }
                else
                {
                    b = b - 1;
                }

                if (a==0 && b==0 )
                {
                    re = false;
                }
            }
            result[a, b] = "#";


            for (int i = 0; i < P; i++)
            {
                string curstr = "";
                for (int j = 0; j < P; j++)
                {
                    curstr += result[i, j];
                }
                Console.WriteLine(curstr);
            }
             
        }
    }
}
