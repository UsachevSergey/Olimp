using System;
using System.Collections.Generic;

namespace OlimpicProject.GraphTheory
{
    class CycleNegativeWeight
    {
        public static void X()
        { 
            
            int Size = int.Parse(Console.ReadLine());
            List<Edge> ListEdge = new List<Edge>();
            bool yes = false;
            int infinity = 1000000000;
            for (int i = 0; i < Size; i++)
            {
                
                string[] currentstr = Console.ReadLine().Replace("  ", " ").Trim().Split(); 
                for (int j = 0; j < Size; j++)
                {
                    int add = int.Parse(currentstr[j]);
                    //если грани нет
                    if (add == 100000)
                    {

                    }
                    else
                    {
                        ListEdge.Add(new Edge()
                        {
                            start = i,
                            end = j,
                            cost = add
                        });
                    }
                } 
            }


            int lastiteration = Size - 1;

            //поиск наименьшего пути с каждой вершины
            for (int ever = 0; ever < Size; ever++)
            {
                int[] ArrayResult = new int[Size];
                for (int i = 0; i < Size; i++)
                {
                    ArrayResult[i] = infinity;
                }
                ArrayResult[ever] = 0; 
                //по всем вершинам
                for (int i = 0; i < Size; i++)
                {
                    //по всем граням
                    for (int j = 0; j < ListEdge.Count; j++)
                    {
                        if (ArrayResult[ListEdge[j].start]<infinity)
                        {
                            if (ArrayResult[ListEdge[j].end] > ArrayResult[ListEdge[j].start]+ListEdge[j].cost )
                            {
                                ArrayResult[ListEdge[j].end] = ArrayResult[ListEdge[j].start] + ListEdge[j].cost;

                                //если последняя итерация
                                if (i == lastiteration)
                                {
                                    yes = true;i = 99999;j = 99999;ever = 99999;
                                }
                            }
                        }

                    }
                }
            }
            if (yes)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }



        }
        struct Edge
        {
            public int end, start, cost;
        }
    }
}
