using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.TwoDimensionalArray
{
    class MaxThree
    {
        public static void X()
        {
            short X = short.Parse(Console.ReadLine());
            short[,] Matrix = new short[X+3, X+3];
            for (short i = 0; i < X+3; i++)
            { 
                //первые и последние строки столбцы = -999
                Matrix[i, 0] = -999;
                Matrix[i, 1] = -999; 
                Matrix[1, i] = -999;
                Matrix[0, i] = -999;
                Matrix[i, X+2] = -999;  
            }
            int Max = -999;
            //начинаем со второго и до последнего //чтобы исключить первые
            for (short i = 2; i < X+2; i++)
            {
                string[] currentstr = Console.ReadLine().Split(' ');
                for (short j = 2; j < X+2; j++)
                {
                    //первый =  третьему символу со смещением 2
                    Matrix[i, j] = short.Parse(currentstr[j - 2]);
                    int CurrentMax = -999;
                    if (Matrix[i, j] + Matrix[i - 1, j] + Matrix[i - 2, j] > CurrentMax)//uu
                    { CurrentMax = Matrix[i, j] + Matrix[i - 1, j] + Matrix[i - 2, j]; }
                    if (Matrix[i, j] + Matrix[i - 1, j] + Matrix[i - 1, j - 1] > CurrentMax)//ul
                    { CurrentMax = Matrix[i, j] + Matrix[i - 1, j] + Matrix[i - 1, j - 1]; }
                    if (Matrix[i, j] + Matrix[i - 1, j] + Matrix[i - 1, j + 1] > CurrentMax)//ur
                    { CurrentMax = Matrix[i, j] + Matrix[i - 1, j] + Matrix[i - 1, j + 1]; }
                    if (Matrix[i, j] + Matrix[i, j - 1] + Matrix[i, j - 2] > CurrentMax)//ll
                    { CurrentMax = Matrix[i, j] + Matrix[i, j - 1] + Matrix[i, j - 2]; }
                    if (Matrix[i, j] + Matrix[i, j - 1] + Matrix[i - 1, j - 1] > CurrentMax)//lu
                    { CurrentMax = Matrix[i, j] + Matrix[i, j - 1] + Matrix[i - 1, j - 1]; }
                    if (Matrix[i, j] + Matrix[i, j - 1] + Matrix[i - 1, j] > CurrentMax)//l c u
                    { CurrentMax = Matrix[i, j] + Matrix[i, j - 1] + Matrix[i - 1, j]; }
                    if (CurrentMax>Max)
                    {
                        Max = CurrentMax;
                    } 
                }
            }
            Console.WriteLine(Max);




        }
    }
}
