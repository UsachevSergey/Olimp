using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.TwoDimensionalArray
{
    class Construction
    {
        public static void X()
        {
            string[] s = Console.ReadLine().Split();
            int ai = int.Parse(s[0]);
            int aj = int.Parse(s[1]);
            string[,] Matrix = new string[ai, aj];
            for (int i = 0; i < ai; i++)
            {
                string[] current = Console.ReadLine().Split();
                for (int j = 0; j < aj; j++)
                {
                    Matrix[i, j] = current[j];
                }
            }
            //данные внесены
            //угол при разнице по диагонали 
            const int LittleAngle = 300 * 20 * 20;
            //при разнице по осям
            const int Wall = 300 * 80 * 10;
            double result = 0;
            for (int i = 0; i < ai; i++)
            {
                for (int j = 0; j < aj; j++)
                {
                    //проверяем на стены
                    int currentvolume = 0;
                    try
                    {
                        if (Matrix[i, j] != Matrix[i + 1, j])
                        {
                            currentvolume += Wall;
                        }
                    }
                    catch { }
                    try
                    {
                        if (Matrix[i, j] != Matrix[i - 1, j])
                        {
                            currentvolume += Wall;
                        }
                    }
                    catch { }
                    try
                    {
                        if (Matrix[i, j] != Matrix[i, j+1])
                        {
                            currentvolume += Wall;
                        }
                    }
                    catch { }
                    try
                    {
                        if (Matrix[i, j] != Matrix[i, j-1])
                        {
                            currentvolume += Wall;
                        }
                    }
                    catch { }
                    //Поверяем на углы 
                    try
                    {
                        if (Matrix[i, j] != Matrix[i + 1, j + 1])
                        {
                            currentvolume += LittleAngle;
                        }
                    }
                    catch { }
                    try
                    {
                        if (Matrix[i, j] != Matrix[i + 1, j - 1] && Matrix[i, j-1] == Matrix[i+1, j])
                        {
                            currentvolume += LittleAngle;
                        }
                    }
                    catch { }
                    result += currentvolume;
                }
            }
            Console.WriteLine((result/1000000).ToString().Replace(',','.'));
        }
    }
}
