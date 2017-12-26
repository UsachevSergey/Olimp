using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlimpicProject.GraphTheory
{
    class Refills
    {
        public static void X()
        {

            int CountTown = int.Parse(Console.ReadLine());
            List<int> Costs = Console.ReadLine().Replace("  ", " ").Trim().Split().ToList().ConvertAll(x => int.Parse(x));
            int CountRoad = int.Parse(Console.ReadLine());
            List<Edge> Road = new List<Edge>();
            for (int i = 0; i < CountRoad; i++)
            { 
                string[] CurrentString = Console.ReadLine().Split(' ');
                int starttown = int.Parse(CurrentString[0]) - 1;
                int endtown = int.Parse(CurrentString[1]) - 1;

                Road.Add(new Edge()
                {
                    Start = starttown,
                    End = endtown,
                    Cost = Costs[endtown]
                });
                Road.Add(new Edge()
                {
                    Start = endtown,
                    End = starttown,
                    Cost = Costs[starttown]
                });

            }
            //данные внесены теперь нужно применить алгоритм форда белмана
            //так как надо найти минимальный путь от A до Z в ориентированом графе
            List<int> Result = new List<int>();
            int infinity = 999999;
            for (int i = 0; i < CountTown; i++)
            {
                Result.Add(infinity);
            }
            Result[0] = 0;

            for (int i = 0; i < CountTown-1; i++)
            {
                for (int j = 0; j < Road.Count; j++)
                {
                    //если из текущего города есть путь
                    if (Result[Road[j].Start]<infinity)
                    {
                        Result[Road[j].End] = Math.Min(
                            Result[Road[j].End],
                        Result[Road[j].Start] + Road[j].Cost
                        );
                    }
                }
            }

            if (Result.Last()==infinity)
            {
                Console.WriteLine(-1);
            }
            else
            {
                //вывести значение прибытия в последний город - заправку в последнем городе + заправку в первом
                int resultcwl = Result.Last() - Costs.Last() + Costs[0]; 
                Console.WriteLine( resultcwl );
            }


        }

        struct Edge
        {
            public int Start, End, Cost;
        }
    }
}
