using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.TwoDimensionalArray
{
    class Sudoku
    {
        public static void X()
        {
            int MatrixSize = int.Parse(Console.ReadLine());

            int[,] Matrix = new int[MatrixSize* MatrixSize, MatrixSize* MatrixSize];

            for (int i = 0; i < MatrixSize* MatrixSize; i++)
            {
                string[] currentstring = Console.ReadLine().Split();
                for (int j = 0; j < MatrixSize* MatrixSize; j++)
                {
                    Matrix[i, j] = int.Parse(currentstring[j]);
                }
            }
            string result = "Correct"; 
            for (int i = 0; i < MatrixSize* MatrixSize; i++)
            {// проверяем строки и столбцы 
                List<int> StrDifferent = new List<int>();
                List<int> CollumnDifferent = new List<int>();
                for (int j = 0; j < MatrixSize* MatrixSize; j++)
                {
                    //строку
                    StrDifferent.Add(Matrix[i,j]);
                    //столбец
                    CollumnDifferent.Add(Matrix[j,i]);
                }
                StrDifferent.Sort();
                CollumnDifferent.Sort();
                //если количество разных элементов не равно размеру матрицы то не корректно
                if (StrDifferent.Distinct().Count()< MatrixSize* MatrixSize ||
                    CollumnDifferent.Distinct().Count()<MatrixSize* MatrixSize || 
                   StrDifferent.Max()!=MatrixSize* MatrixSize ||
                   CollumnDifferent.Max()!=MatrixSize* MatrixSize
                   ) 
                {
                    result = "Incorrect";
                    break;
                } 
            }
            for (int c = 0; c < MatrixSize; c++)
            {
                
                for (int c2 = 0; c2 < MatrixSize; c2++)
                {
                    List<int> CurrentSquare = new List<int>();

                    for (int i = c*MatrixSize; i < (c*MatrixSize)+MatrixSize; i++)
                    {
                        for (int j = c2 * MatrixSize; j < (c2 * MatrixSize )+ MatrixSize; j++)
                        {
                            CurrentSquare.Add(Matrix[i, j]);
                        }
                    }

                    //если количество разных элементов не равно размеру матрицы то не корректно
                    if (CurrentSquare.Distinct().Count() < MatrixSize*MatrixSize )
                    {
                        result = "Incorrect";
                        break;
                    }

                } 
            } 
            Console.WriteLine(result);
        }
    }
}
