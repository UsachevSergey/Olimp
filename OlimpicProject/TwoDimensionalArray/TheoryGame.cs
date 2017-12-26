using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.TwoDimensionalArray
{
    class TheoryGame
    {
        public static void X()
        {
            //находит максимальное значение из списка минимальных значений строк
            // и находит минимальное значение среди максимальных значений столбцов

            string[] s = Console.ReadLine().Split(' ');
            int str = Convert.ToInt32(s[0]);
            int col = Convert.ToInt32(s[1]);
            int[] MinInStr = new int[str];
            int[] MaxInCol = new int[col];
            for (int i = 0; i < str; i++)
            {
                MinInStr[i] = 1001;
            }
            for (int i = 0; i < col; i++)
            {
                MaxInCol[i] = -1001;
            }

            for (int i = 0; i < str; i++)
            {
                string[] current = Console.ReadLine().Split(' ');
                for (int j = 0; j < col; j++)
                {
                    int currentNumber = int.Parse(current[j]);
                    //если текущее меньше минимального сделать его минимальной
                    if (currentNumber < MinInStr[i])
                    {
                        MinInStr[i] = currentNumber;
                    }
                    if (currentNumber > MaxInCol[j])
                    {
                        MaxInCol[j] = currentNumber;
                    }
                }
            }
            Console.WriteLine(MinInStr.Max() + " " + MaxInCol.Min());
        }
    }
}
