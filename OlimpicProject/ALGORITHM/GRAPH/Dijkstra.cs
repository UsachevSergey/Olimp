using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.ALGORITHM.GRAPH
{
    class Dijkstra
    {
        //метод возвращает минимальную длину пути
        //на входе принимает двумерный масив(матрицу смежности)
        //если в матрице пути нет то он должен быть помечен -1;
        //начальная и конечная позиция
        public static int X(int[,] matrix ,int start,int end)
        {
            
            // +бесконечность
            int infinity = 9999999;
            //количество узлов
            int CountNode = (int)Math.Sqrt(matrix.Length); 
            //масив отметок о посещениях
            bool[] VisitNode = new bool[CountNode];
            //масив минимальных растояний до узла
            int[] MinPath = new int[CountNode];
            //заполняем пути бесконечностью
            for (int i = 0; i < CountNode; i++)
            {
                MinPath[i] = infinity;
            }
            //устанавливаем начальную позицию
            MinPath[start] = 0;
            int CurrentNode = start;

            //пока конечная вершина не посещена
            while (!VisitNode[end])
            {
                //проходим по всем вершинам и изменяем минимальный путь если он действительно минимаен
                for (int j = 0; j < CountNode; j++)
                {
                    if (matrix[CurrentNode, j] > -1)
                    {
                        MinPath[j] = Math.Min(MinPath[j], MinPath[CurrentNode] + matrix[CurrentNode, j]);
                    }
                }
                //помечаем вершину как посешеную
                VisitNode[CurrentNode] = true;
                //текущий минимум  = на 1 бальше чем бесконечность // для сравнения с оставшимися вершинами
                int curr_min = infinity + 1;
                //устанавливаем текущую вершину как 0;
                CurrentNode = 0;
                for (int i = 0; i <CountNode ; i++)
                {
                    //если вершина не посещена и является минимальной среди оставшихся
                    //то берем её за основу на следующий цикл
                    if (VisitNode[i] == false && MinPath[i] < curr_min)
                    {
                        CurrentNode = i;
                        curr_min = MinPath[i];
                    }
                }
            }



            //если вершина не досягаема то возвращаем -1 иначе возвращаем минимальный путь до этой вершины
            if (MinPath[end]==infinity)
            {
                return -1;
            }
            else
            {
                return MinPath[end];
            }
             
        }
    }
}
