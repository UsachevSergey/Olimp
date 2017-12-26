using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.TwoDimensionalArray
{
    class WarBase
    {
        public static void X()
        {
            string[] coordinatefield = Console.ReadLine().Split();
            int str = int.Parse(coordinatefield[0]);
            int col = int.Parse(coordinatefield[1]);
            char[,] Matrix = new char[str + 1, col + 1];
            //рисуем
            for (int i = 0; i < str; i++)
            {
                string current = Console.ReadLine();
                for (int j = 0; j < col; j++)
                {
                    Matrix[i, j] = current[j];
                }
            }

            int result = 0;
            //проверяем
            for (int i = 0; i < str; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (Matrix[i, j].ToString() == "#")
                    {
                        int minlenght = 1;
                        bool end = false;
                        //пока не всё считать длину постойки
                        while (!end)
                        {//если следующий решетка и весь ряд под ними решетка то добавить размер
                            if (Matrix[i, j + minlenght].ToString() == "#")
                            {
                                int countbase = 0;
                                for (int a = j; a < j + minlenght + 1; a++)
                                {
                                    if (Matrix[i + minlenght, a].ToString() == "#")
                                    {
                                        countbase++;
                                    }
                                }
                                //если во всей строке решетки
                                if (countbase == (j + minlenght + 1) - j)
                                {
                                    minlenght++;
                                }
                                else {
                                    end = true;
                                }
                            }
                            else {
                                end = true;
                            }

                            //если всё то провереные данные стереть
                            if (end)
                            {
                                result++;
                                for (int ii = i; ii < i + minlenght; ii++)
                                {
                                    for (int jj = j; jj < j + minlenght; jj++)
                                    {
                                        Matrix[ii, jj] = '.';
                                    }
                                }
                            }
                        }
                    }
                } 
            }

            Console.WriteLine(result);
        }
    }
}