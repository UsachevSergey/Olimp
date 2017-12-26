using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.GraphTheory
{
    class AlgoritmFordaBelmana
    {
        public static void X()
        {

            string[] CountMN = Console.ReadLine().Split(' ');
            //количество вершин
            int TopCount = int.Parse(CountMN[0]);
            //количество ребер
            
            int EdgeCount = 0;
            // ИЗ ЗА ОШИБКИ НА ACMP НУЖНО СЧИТЫВАТЬ В ОДНОМ ИЗ ТЕСТОВ С НОВОЙ СТРОКИ
            try
            {
                EdgeCount = int.Parse(CountMN[1]);
            }
            catch { EdgeCount = int.Parse(Console.ReadLine());  }
            List<Edge> ArrayEdge = new List<Edge>();
            List<int> ArrayTop = new List<int>();
            //8 по 9
            int infinity = 99999999;
            //заполняем масив результатов бесконечными значениями
            for (int i = 0; i < TopCount; i++)
            {
                ArrayTop.Add(infinity);
            }
            //начальное положение( откуда искать)
            ArrayTop[0] = 0;

            //заполняем колекцию граней
            for (int i = 0; i < EdgeCount; i++)
            {
                string[] CurrentEdge = Console.ReadLine().Split(' ');
                ArrayEdge.Add(
                              new Edge() {
                                  start = int.Parse(CurrentEdge[0])-1,
                                  end = int.Parse(CurrentEdge[1])-1,
                                  cost = int.Parse(CurrentEdge[2]) 
                              }); 
            }

            //сам алгоритм
            for (int i = 0; i < TopCount-1; i++)
            {
                for (int j = 0; j < EdgeCount; j++)
                {
                    //если у текущей вершины начальная точка меньше бесконечности
                    if (ArrayTop[ArrayEdge[j].start]<infinity)
                    {
                        ArrayTop[ArrayEdge[j].end] = Math.Min(
                            ArrayTop[ArrayEdge[j].end],
                            ArrayTop[ArrayEdge[j].start] + ArrayEdge[j].cost
                            );
                    }
                }
            }

            string ForWrite = "";
            for (int i = 0; i < ArrayTop.Count; i++)
            {
                ForWrite += (ArrayTop[i] == infinity ? 30000 : ArrayTop[i]) + " ";
            }
            Console.WriteLine(ForWrite.Trim());







        }

        struct Edge
        { 
         public   int start, end, cost;
        }


    }
}
