using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.TulaCodeCup2017.Round3
{
    class CoinOnAChessboard
    {
        public static void X()
        {
            int Size = int.Parse(Console.ReadLine());
            long[,] Matrix = new long[Size, Size];
            long[,] MatrixSumLeft = new long[Size, Size];
            long[,] MatrixSumRight = new long[Size, Size];

            for (int i = 0; i < Size; i++)
            {
                string[] s = Console.ReadLine().Split();
                for (int j = 0; j < Size; j++)
                {
                    int CurremtMoney = int.Parse(s[j]);
                    Matrix[i, j] = CurremtMoney;

                    if (j == 0 || i == 0)
                    {

                        MatrixSumLeft[i, j] = CurremtMoney;
                    }
                    else
                    {
                        MatrixSumLeft[i, j] = CurremtMoney + MatrixSumLeft[i - 1, j - 1];
                    }

                    if (i == 0 || j == Size - 1)
                    {
                        MatrixSumRight[i, j] = CurremtMoney;
                    }
                    else
                    {
                        MatrixSumRight[i, j] = MatrixSumRight[i - 1, j + 1] + CurremtMoney;
                    }
                }
            }
            //endinp

            long Max1 = 0;
            long Max2 = 0;
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    //левую проекцию  
                    int lpr = Math.Min(Size - (i + 1), Size - j - 1);
                    //правая
                    int rpr = Math.Min(j, Size - (i + 1));
                    long CURrentMAX = MatrixSumLeft[i + lpr, j + lpr] + MatrixSumRight[i + rpr, j - rpr] - Matrix[i, j];

                    if ((i + j) % 2 == 0)
                    {
                        Max1 = Math.Max(Max1, CURrentMAX);
                    }
                    else
                    {
                        Max2 = Math.Max(Max2, CURrentMAX);
                    }

                }
            }
            Console.WriteLine(Max1 + Max2);
        }
    }
}
