using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.GraphTheory
{
    class MinCostTravel
    {
        public static void X()
        {

            //список растояний //граней
            List<Edge> Edges = new List<Edge>();

            int CountStation = int.Parse(Console.ReadLine())+1;

            //i - номер станции отправления
            for (int i = 0; i < CountStation-1; i++)
            {

                string[] CurrentCostTable = Console.ReadLine().Split(' ');
                // j номер станции прибытия //от следующей станции и до последней
                for (int j = 0; j < CurrentCostTable.Count(); j++)
                {
                    Edges.Add(new Edge() {
                        start = i,
                        end = i+1+j,
                        cost = int.Parse(CurrentCostTable[j]) 
                    } );
                } 
            }
            //тут заполнен список 
            List<int> ArrayResult = new List<int>();
            int infinity = 9999999;
            for (int i = 0; i < CountStation; i++)
            {
                ArrayResult.Add(infinity);
            }
            //станция с которой будем двигатся
            ArrayResult[0] = 0;

            //проходим столько раз сколько станций
            for (int i = 0; i < CountStation; i++)
            { 
                //проходим по всем путям
                for (int j = 0; j < Edges.Count; j++)
                {
                    //если эта станция уже достижима 
                    //станция из которой выходит грань j 
                    if (ArrayResult[Edges[j].start]<infinity)
                    {
                        ArrayResult[Edges[j].end] = Math.Min(
                            ArrayResult[Edges[j].end],
                            ArrayResult[Edges[j].start] + Edges[j].cost
                            );
                    } 
                }
            } 
            Console.WriteLine(ArrayResult[CountStation-1]); 
        }

        struct Edge
        {
            public int start, end, cost; 
        }
    }
}
