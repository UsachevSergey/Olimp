using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.GraphTheory
{
    class AlgorithmDeikstra
    {
        public static void X()
        {
            string[] SizeStartEnd = Console.ReadLine().Split(' ');
            int Size  = int.Parse(SizeStartEnd[0]);
            int Start = int.Parse(SizeStartEnd[1])-1;
            int End   = int.Parse(SizeStartEnd[2])-1;
            int[,] Matrix = new int[Size, Size];
            //масив кратчайших путей из точки statr
            int[] ArrayMinLenght = new int[Size];
            //масив посещеных узлов
            bool[] Visited = new bool[Size];
            int infinity = 99999;
            for (int i = 0; i < Size; i++)
            {
                ArrayMinLenght[i] = infinity;
                string[] currentStr = Console.ReadLine().Split(' ');
                for (int j = 0; j < Size; j++)
                {
                    Matrix[i, j] = int.Parse(currentStr[j]);
                }
            }
            //данные внесены
            //начальная точка равна 0 //до нее растояние ровно 0 
            ArrayMinLenght[Start  ] = 0;
            //текущий узел
            int CurrentNode = Start  ;

            //пока не будет посещена конечная точка
            while (!Visited[End])
            {
                //проходим по всем вершинам
                for (int i = 0; i < Size; i++)
                {
                    //если текущая вершина достижима
                    if (Matrix[CurrentNode,i]>-1)
                    {
                        ArrayMinLenght[i] = Math.Min(
                            ArrayMinLenght[i],
                            ArrayMinLenght[CurrentNode] + Matrix[CurrentNode, i]
                            );
                    }
                }
                //отмечаем узел как пройденый
                Visited[CurrentNode] = true;
                //делаем текущий минимум крайне большим
                int CurrentMin = infinity+1;
                //делаем текущий узел =0 
                CurrentNode = 0;
                for (int i = 0; i < Size; i++)
                {
                    //если вершина ещё не посещена и минимум не установлен 
                    //тоесть ищем вершину которую не посещали и в которой наименьший путь
                    if (Visited[i]==false &&CurrentMin>ArrayMinLenght[i] )
                    {
                        CurrentNode = i;
                        CurrentMin = ArrayMinLenght[i]; 
                    }
                } 
            }

            //если недосягаема то -1
            if (ArrayMinLenght[End]== infinity)
            {
                ArrayMinLenght[End] = -1;
            }
            Console.WriteLine(ArrayMinLenght[End]);




        }
    }
}
