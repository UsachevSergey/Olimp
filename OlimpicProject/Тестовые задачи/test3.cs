using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.Тестовые_задачи
{
    class test3
    {

        public static void X2qsort()
        {
            int[] ar = new int[5000];

            Random r = new Random();
            for (int i = 0; i < ar.Count(); i++)
            {
                ar[i] = r.Next(1, 1000000);
            }

            //            ALGORITHM.SORT.QuickSort AQS = new ALGORITHM.SORT.QuickSort();
            ALGORITHM.SORT.MergeSort AQS = new ALGORITHM.SORT.MergeSort();

            ar = AQS.GO(ar); 

            int s = 12;

                }
        public static void X()
        {
            int[,] mat = new int[10, 10];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    mat[i, j] = -1;
                }
            }
            mat[0, 1] = 5; mat[0, 2] = 14; mat[0, 3] = 10;
            mat[1, 0] = 5; mat[1, 2] = 19; mat[1, 5] = 3;
            mat[2, 0] = 14; mat[2, 1] = 19; mat[2, 3] = 6; mat[2, 4] = 6; mat[2, 5] = 5; mat[2, 6] = 8;
            mat[3, 0] = 10; mat[3, 2] = 6; mat[3, 4] = 11;
            mat[4, 2] = 6; mat[4, 3] = 11; mat[4, 6] = 10; mat[4, 8] = 7;
            mat[5, 1] = 3; mat[5, 2] = 5; mat[5, 6] = 9; mat[5, 7] = 8;
            mat[6, 2] = 8; mat[6, 4] = 10; mat[6, 5] = 9; mat[6, 7] = 3; mat[6, 8] = 8; mat[6, 8] = 14;
            mat[7, 5] = 8; mat[7, 6] = 3; mat[7, 9] = 2;
            mat[8, 4] = 7; mat[8, 6] = 8; mat[8, 9] = 3;
            mat[9, 6] = 14; mat[9, 7] = 2; mat[9, 8] = 3;


            int count = ALGORITHM.GRAPH.Dijkstra.X(mat, 3, 9);
            Console.WriteLine("Результат работы Дейкстры " + count);
        }

    }
}
