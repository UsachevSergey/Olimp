using System;
using System.Collections.Generic;
using System.Linq;

namespace OlimpicProject.GraphTheory
{
    class Bus
    {
        struct Edge
        {

            public int start, end;
            //время прибытия
            public int TimeArive;

            public int TimeStart;
        }
        public static void X()
        {


            //количество деревень
            int CountVilage = int.Parse(Console.ReadLine());
            //начальная конечная станция
            string[] se = Console.ReadLine().Split(' ');
            int StartVilage = int.Parse(se[0]);
            int EndSVilage = int.Parse(se[1]);
            //количество автобусов
            long CountBus = long.Parse(Console.ReadLine());
            //список смежности
            List<Edge> Edge = new List<Edge>();
            //временые интервалы в которые автобус отправляется из деревни
            List<int> TimeInterval = new List<int>();


            for (int i = 0; i < CountBus; i++)
            {
                List<int> CurrentBus = Console.ReadLine().Replace("  ", " ").Trim().Split().ToList().ConvertAll(asertew => int.Parse(asertew));

                Edge.Add(new Edge()
                {
                    start = CurrentBus[0],
                    end = CurrentBus[2],
                    TimeArive = CurrentBus[3],
                    TimeStart = CurrentBus[1]
                });
                TimeInterval.Add(CurrentBus[1]);
            }


        TimeInterval = TimeInterval.Distinct().ToList();
        TimeInterval.Sort();

            //список посещеных деревень
            int[] FirstVisit = new int[CountVilage + 2];
            for (int i = 0; i< CountVilage + 2; i++)
            {
                FirstVisit[i] = 2000000000;
            }
            FirstVisit[StartVilage] = -1;

             
            //проходим по всем временым интервалам 
            foreach (var item in TimeInterval)
            {
                //по всем маршрутам
                for (int i = 0; i<Edge.Count; i++)
                {
                    //если время отправления совпадает c текущим
                    if (Edge[i].TimeStart == item)
                    {
                        //и время первого посещения деревни меньше текущего
                        if (FirstVisit[Edge[i].start] <= item )
                        {
                            FirstVisit[Edge[i].end] = Math.Min(FirstVisit[Edge[i].end], Edge[i].TimeArive);
                        }
                    }
                }
            }

            if (FirstVisit[EndSVilage] == 2000000000)
            {
                FirstVisit[EndSVilage] = -1;
            }
            if (EndSVilage==StartVilage)
            {
                FirstVisit[EndSVilage] = 0;
            }

            Console.WriteLine(FirstVisit[EndSVilage]); 
        }
    }
}
